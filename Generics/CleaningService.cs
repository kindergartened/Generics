using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum CleaningType
{
    VacuumCleaner,
    Fan,
    Purifier,
    Freshener
}

namespace Generics
{
    public abstract class CleaningService : IComparable<CleaningService>
    {
        string brandName;
        CleaningType type;
        int price;

        public CleaningService(CleaningType type, int price, string brandName)
        {
            this.brandName = brandName;
            this.type = type;
            this.price = price;
        }

        public string BrandName { get => brandName; set => brandName = value; }
        public CleaningType Type { get => type; set => type = value; }
        public int Price { get => price; set => price = value; }

        public static CleaningService Generate()
        {
            Random rnd = new Random();
            int cleaningN = rnd.Next(0, 2);
            int typeN = rnd.Next(1, 4);
            CleaningService cleaning = cleaningN == 1 ?
                new XiaomiCleaningService(
                    typeN == 1 ? 
                    CleaningType.Purifier :
                    typeN == 2 ?
                    CleaningType.Fan :
                    typeN == 0 ? 
                    CleaningType.Freshener :
                    CleaningType.VacuumCleaner
                    , rnd.Next(1000, 3000)) :
                new RoborockCleaningService(
                    typeN == 1 ?
                    CleaningType.Purifier :
                    typeN == 2 ?
                    CleaningType.Fan :
                    typeN == 0 ?
                    CleaningType.Freshener :
                    CleaningType.VacuumCleaner
                    , rnd.Next(500, 10000));
            return cleaning;
        }

        public int CompareTo(CleaningService? other)
        {
            return price.CompareTo(other?.price);
        }

        public override string ToString()
        {
            return $"{'{'}\t \n \t \t Бренд:  {brandName} ,\n \t \t Тип:  {type} ,\n \t \t Цена:  {price}  \n \t{'}'}";
        }
    }

    class XiaomiCleaningService : CleaningService
    {
        string brandName;
        CleaningType type;
        int price;

        public XiaomiCleaningService(CleaningType type, int price, string brandName = "Xiaomi") : base(type, price, brandName)
        {
            this.brandName = brandName;
            this.type = type;
            this.price = price;
        }
    }

    class RoborockCleaningService : CleaningService
    {
        string brandName;
        CleaningType type;
        int price;

        public RoborockCleaningService(CleaningType type, int price, string brandName = "Roborock") : base(type, price, brandName)
        {
            this.brandName = brandName;
            this.type = type;
            this.price = price;
        }
    }
}
