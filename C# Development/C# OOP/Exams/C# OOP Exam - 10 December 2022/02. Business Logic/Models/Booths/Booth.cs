using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Repositories.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Text;

namespace ChristmasPastryShop.Models.Booths
{
    public class Booth : IBooth
    {
        public Booth(int boothId, int capacity)
        {
            BoothId = boothId;
            Capacity = capacity;
            delicacyMenu = new DelicacyRepository();
            cocktailMenu = new CocktailRepository();
        }

        private int boothId;

        public int BoothId
        {
            get { return boothId; }
            private set { boothId = value; }
        }


        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.CapacityLessThanOne);
                }

                capacity = value;
            }
        }

        private DelicacyRepository delicacyMenu;
        public IRepository<IDelicacy> DelicacyMenu => delicacyMenu;


        private CocktailRepository cocktailMenu;
        public IRepository<ICocktail> CocktailMenu => cocktailMenu;

        private double currentBill;

        public double CurrentBill
        {
            get { return currentBill; }
            private set { currentBill = value; }
        }

        private double turnover;

        public double Turnover
        {
            get { return turnover; }
            private set { turnover = value; }
        }

        private bool isReserved;

        public bool IsReserved
        {
            get { return isReserved; }
            private set { isReserved = value; }
        }

        public void ChangeStatus()
        {
            IsReserved = !IsReserved;
        }

        public void Charge()
        {
            Turnover += CurrentBill;
            CurrentBill = 0;
        }

        public void UpdateCurrentBill(double amount)
        {
            CurrentBill += amount;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Booth: {BoothId}");
            sb.AppendLine($"Capacity: {Capacity}");
            sb.AppendLine($"Turnover: {Turnover:f2} lv");

            sb.AppendLine("-Cocktail menu:");
            foreach (var cocktail in cocktailMenu.Models)
            {
                sb.AppendLine($"--{cocktail.ToString()}");
            }

            sb.AppendLine("-Delicacy menu:");
            foreach (var delicacy in delicacyMenu.Models)
            {
                sb.AppendLine($"--{delicacy.ToString()}");
            }

            return sb.ToString().Trim();
        }
    }
}
