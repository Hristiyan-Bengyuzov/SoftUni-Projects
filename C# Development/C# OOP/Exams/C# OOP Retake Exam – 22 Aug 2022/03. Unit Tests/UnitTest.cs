using FrontDeskApp;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BookigApp.Tests
{
    public class Tests
    {
        private Room room;
        private Hotel hotel;
        private Booking booking;
        private int bedCapacity = 3;
        private int pricePerNight = 50;
        private string hotelName = "Pirin";
        private int category = 4;
        private int bookingNumber = 6;
        private int residenceDuration = 200;

        [SetUp]
        public void Setup()
        {
            room = new Room(bedCapacity, pricePerNight);
            hotel = new Hotel(hotelName, category);
            booking = new Booking(bookingNumber, room, residenceDuration);
        }

        [Test]
        public void Test_RoomConstructorShouldWorkProperly()
        {
            Assert.AreEqual(bedCapacity, room.BedCapacity);
            Assert.AreEqual(pricePerNight, room.PricePerNight);
        }

        [Test]
        [TestCase(0, 5)]
        [TestCase(-5, 5)]
        [TestCase(5, 0)]
        [TestCase(5, -5)]
        public void Test_RoomConstructorShouldThrowForInvalidInput(int bedCapacity, int pricePerNight)
        {
            Assert.Throws<ArgumentException>(() => new Room(bedCapacity, pricePerNight));
        }

        [Test]
        public void Test_HotelConstructorShouldWorkProperly()
        {
            Assert.AreEqual(hotelName, hotel.FullName);
            Assert.AreEqual(category, hotel.Category);
            Assert.AreEqual(0, hotel.Rooms.Count);
            Assert.AreEqual(0, hotel.Bookings.Count);
            Assert.AreEqual(0, hotel.Turnover);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("      ")]
        public void Test_HotelConstructorShouldThrowForInvalidName(string name)
        {
            Assert.Throws<ArgumentNullException>(() => new Hotel(name, category));
        }

        [Test]
        [TestCase(-10)]
        [TestCase(0)]
        [TestCase(6)]
        [TestCase(100)]
        public void Test_HotelConstructorShouldThrowForInvalidCategory(int category)
        {
            Assert.Throws<ArgumentException>(() => new Hotel(hotelName, category));
        }

        [Test]
        public void Test_AddRoomShouldWorkProperly()
        {
            hotel.AddRoom(room);
            Assert.AreEqual(1, hotel.Rooms.Count);
        }

        [Test]
        [TestCase(0, 2, 2)]
        [TestCase(-3, 2, 2)]
        [TestCase(2, -3, 2)]
        [TestCase(2, 2, 0)]
        [TestCase(2, 2, -3)]
        public void Test_BookRoomShouldThrowForInvalidInput(int adults, int children, int duration)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(adults, children, duration, 2000);
            });
        }

        [Test]
        public void Test_BookRoomShouldWorkProperly()
        {
            hotel.AddRoom(room);
            hotel.BookRoom(2, 0, residenceDuration, 20000000);
            Assert.AreEqual(1, hotel.Bookings.Count);
            Assert.AreEqual(residenceDuration * room.PricePerNight, hotel.Turnover);
        }

        [Test]
        public void Test_BookingConstructorShouldWorkProperly()
        {
            Assert.AreEqual(bookingNumber, booking.BookingNumber);
            Assert.AreEqual(room, booking.Room);
            Assert.AreEqual(residenceDuration, booking.ResidenceDuration);
        }
    }
}