using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum LightType
{
    Bulb,
    Strip,
    Lamp,
    CeilingLamp
}

// TODO: сделать по разным полям сортировку

namespace Generics
{
    public abstract class Lights : IComparable<Lights>
    {
        string brandName;
        LightType type;
        int price;

        public Lights(LightType type, int price, string brandName)
        {
            this.brandName = brandName;
            this.type = type;
            this.price = price;
        }

        public int Price { get => price; set => price = value; }
        public LightType Type { get => type; set => type = value; }
        public string BrandName { get => brandName; set => brandName = value; }

        public static Lights Generate()
        {
            Random rnd = new Random();
            int cleaningN = rnd.Next(0, 2);
            int typeN = rnd.Next(1, 4);
            Lights cleaning = cleaningN == 1 ?
                new YEELights(
                    typeN == 1 ?
                    LightType.Bulb :
                    typeN == 2 ?
                    LightType.Strip :
                    typeN == 0 ?
                    LightType.Lamp :
                    LightType.CeilingLamp
                    , rnd.Next(1000, 3000)) :
                new PhilipsLights(
                    typeN == 1 ?
                    LightType.Bulb :
                    typeN == 2 ?
                    LightType.Strip :
                    typeN == 0 ?
                    LightType.Lamp :
                    LightType.CeilingLamp
                    , rnd.Next(500, 10000));
            return cleaning;
        }

        public int CompareTo(Lights? other)
        {
            return price.CompareTo(other?.price);
        }

        public override string ToString()
        {
            return $"{'{'}\t \n \t \t Бренд: {brandName},\n \t \t Тип: {type},\n \t \t Цена: {price} \n \t{'}'}";
        }
    }

    class PhilipsLights : Lights
    {
        string brandName;
        LightType type;
        int price;

        public PhilipsLights(LightType type, int price, string brandName = "Philips") : base(type, price, brandName)
        {
            this.brandName = brandName;
            this.type = type;
            this.price = price;
        }
    }

    class YEELights : Lights
    {
        string brandName;
        LightType type;
        int price;

        public YEELights(LightType type, int price, string brandName = "YEELight") : base(type, price, brandName)
        {
            this.brandName = brandName;
            this.type = type;
            this.price = price;
        }
    }

}
