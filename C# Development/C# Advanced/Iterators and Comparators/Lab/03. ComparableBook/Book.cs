﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors);
        }

        public override string ToString() => $"{this.Title} - {this.Year}";

        public int CompareTo([AllowNull] Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if (result == 0) result = this.Title.CompareTo(other.Title);
            return result;
        }
    }
}
