using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_Classwork__Drink_
{
    public enum DrinkType { Sparkling, Still };
    class Drink : IComparable, IComparable<Drink>, IEquatable<Drink>
    {
        public string DrinkName { get; set; }
        public DrinkType DrinkType { get; set; }
        public string Manufacturer { get; set; }
        public int KkalQty { get; set; }
        public int Price { get; set; }
        public Drink(string drinkName, DrinkType drinkType, string manufacturer, int kkalQty, int price)
        {
            DrinkName = drinkName;
            DrinkType = drinkType;
            Manufacturer = manufacturer;
            KkalQty = kkalQty;
            Price = price;

        }
        public override string ToString()
        {
            return $"Drink: {DrinkName},\tDrink type: {DrinkType},\tManufacturer: {Manufacturer},\tCalorific value: {KkalQty},\tPrice: {Price}";
        }

        public int CompareTo(object obj)
        {
            //if (this.DrinkType > ((Drink)obj).DrinkType)
            //    return -1;
            if (this.DrinkType == ((Drink)obj).DrinkType)
            {
                return this.DrinkName.CompareTo(((Drink)obj).DrinkName);
            }
            return this.DrinkType.CompareTo(((Drink)obj).DrinkType);
        }

        public int CompareTo(Drink other)
        {
            if (this.DrinkType == (other).DrinkType)
            {
                return this.DrinkName.CompareTo(other.DrinkName);
            }
            return this.DrinkType.CompareTo(other.DrinkType);
        }

        public bool Equals(Drink other)
        {
            if (other == null)
                return false;
            if (this.DrinkName == other.DrinkName)
                return true;
            else
                return false;
        }
    }
    class CompareByPriceAsc : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Drink)x).Price.CompareTo(((Drink)y).Price);
        }
    }
    class CompareByPriceDesc : IComparer<Drink>
    {
        public int Compare(Drink x, Drink y)
        {
            return -x.Price.CompareTo(y.Price);
        }
    }
    class CompareByKkalDesc : IComparer
    {
        public int Compare(object x, object y)
        {
            return -((Drink)x).KkalQty.CompareTo(((Drink)y).KkalQty);
        }
    }
    class CompareByKkalAsc : IComparer<Drink>
    {
        public int Compare(Drink x, Drink y)
        {
            return x.KkalQty.CompareTo(y.KkalQty);
        }
    }
    class CompareByManDesc : IComparer
    {
        public int Compare(object x, object y)
        {
            return -((Drink)x).Manufacturer.CompareTo(((Drink)y).Manufacturer);
        }
    }
    class CompareByManAsc : IComparer<Drink>
    {
        public int Compare(Drink x, Drink y)
        {
            return x.Manufacturer.CompareTo(y.Manufacturer);
        }
    }
}
