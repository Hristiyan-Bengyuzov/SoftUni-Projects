using ChristmasPastryShop.Core.Contracts;
using ChristmasPastryShop.Models.Booths;
using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ChristmasPastryShop.Core
{
    public class Controller : IController
    {
        private BoothRepository booths;

        public Controller()
        {
            booths = new BoothRepository();
        }

        public string AddBooth(int capacity)
        {
            int boothId = booths.Models.Count + 1;
            booths.AddModel(new Booth(boothId, capacity));
            return String.Format(OutputMessages.NewBoothAdded, boothId, capacity);
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            ICocktail cocktail;
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            switch (cocktailTypeName)
            {
                case "Hibernation": cocktail = new Hibernation(cocktailName, size); break;
                case "MulledWine": cocktail = new MulledWine(cocktailName, size); break;
                default: return String.Format(OutputMessages.InvalidCocktailType, cocktailTypeName);
            }

            if (!new string[] { "Small", "Middle", "Large" }.Contains(size))
            {
                return String.Format(OutputMessages.InvalidCocktailSize, size);
            }

            if (booth.CocktailMenu.Models.Any(c => c.Name == cocktailName && c.Size == size))
            {
                return String.Format(OutputMessages.CocktailAlreadyAdded, size, cocktailName);
            }

            booth.CocktailMenu.AddModel(cocktail);
            return String.Format(OutputMessages.NewCocktailAdded, size, cocktailName, cocktailTypeName);
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            IDelicacy delicacy;
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            switch (delicacyTypeName)
            {
                case "Gingerbread": delicacy = new Gingerbread(delicacyName); break;
                case "Stolen": delicacy = new Stolen(delicacyName); break;
                default: return String.Format(OutputMessages.InvalidDelicacyType, delicacyTypeName);
            }

            if (booth.DelicacyMenu.Models.Any(d => d.Name == delicacyName))
            {
                return String.Format(OutputMessages.DelicacyAlreadyAdded, delicacyName);
            }

            booth.DelicacyMenu.AddModel(delicacy);
            return String.Format(OutputMessages.NewDelicacyAdded, delicacyTypeName, delicacyName);
        }

        public string BoothReport(int boothId)
        {
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            return booth.ToString();
        }

        public string LeaveBooth(int boothId)
        {
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);
            double currentBill = booth.CurrentBill;
            booth.Charge();
            booth.ChangeStatus();

            var sb = new StringBuilder();

            sb.AppendLine($"Bill {currentBill:f2} lv");
            sb.AppendLine($"Booth {boothId} is now available!");

            return sb.ToString().Trim();
        }

        public string ReserveBooth(int countOfPeople)
        {
            IBooth booth = booths.Models.
                Where(b => !b.IsReserved && b.Capacity >= countOfPeople).
                OrderBy(b => b.Capacity).
                ThenByDescending(b => b.BoothId).
                FirstOrDefault();

            if (booth == null)
            {
                return String.Format(OutputMessages.NoAvailableBooth, countOfPeople);
            }

            booth.ChangeStatus();
            return String.Format(OutputMessages.BoothReservedSuccessfully, booth.BoothId, countOfPeople);
        }

        public string TryOrder(int boothId, string order)
        {
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            string[] orderArr = order.Split("/");
            string itemTypeName = orderArr[0];
            string itemName = orderArr[1];
            int countOfOrderedPieces = int.Parse(orderArr[2]);
            string size = null;

            if (orderArr.Length == 4)
            {
                size = orderArr[3];
            }

            if (!new string[] { "Gingerbread", "Stolen", "Hibernation", "MulledWine" }.Contains(itemTypeName))
            {
                return String.Format(OutputMessages.NotRecognizedType, itemTypeName);
            }


            if (!booth.DelicacyMenu.Models.Any(d => d.GetType().Name == itemTypeName && d.Name == itemName) &&
                !booth.CocktailMenu.Models.Any(c => c.GetType().Name == itemTypeName && c.Name == itemName))
            {
                return String.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
            }

            switch (itemTypeName)
            {
                case "Hibernation":
                case "MulledWine":
                    ICocktail cocktail = booth.CocktailMenu.Models.FirstOrDefault(c => c.Name == itemName && c.Size == size);
                    if (cocktail == null)
                    {
                        return String.Format(OutputMessages.NotRecognizedItemName, size, itemName);
                    }
                    booth.UpdateCurrentBill(cocktail.Price * countOfOrderedPieces);
                    return String.Format(OutputMessages.SuccessfullyOrdered, booth.BoothId, countOfOrderedPieces, itemName);
                case "Gingerbread":
                case "Stolen":
                    IDelicacy delicacy = booth.DelicacyMenu.Models.FirstOrDefault(c => c.Name == itemName);
                    if (delicacy == null)
                    {
                        return String.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
                    }
                    booth.UpdateCurrentBill(delicacy.Price * countOfOrderedPieces);
                    return String.Format(OutputMessages.SuccessfullyOrdered, booth.BoothId, countOfOrderedPieces, itemName);
                default: return "no way you get here";
            }


        }
    }
}
