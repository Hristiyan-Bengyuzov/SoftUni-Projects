using System;

namespace DefiningClasses
{
    public class DateModifier
    {
        public int SubtractDates(string first, string second)
        {
            DateTime firstDate = DateTime.Parse(first);
            DateTime secondDate = DateTime.Parse(second);

            return Math.Abs((firstDate - secondDate).Days);
        }
    }
}
