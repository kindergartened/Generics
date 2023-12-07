using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum SecurityType
{
    DoorLock,
    Camera,
    Detector
}

namespace Generics
{
    abstract class SecurityService : IComparable<SecurityService>
    {
        string brandName;
        SecurityType type;
        int price;

        protected SecurityService(SecurityType type, int price, string brandName)
        {
            this.brandName = brandName;
            this.type = type;
            this.price = price;
        }

        public static SecurityService Generate()
        {
            Random rnd = new Random();
            int cleaningN = rnd.Next(0, 2);
            int typeN = rnd.Next(1, 4);
            SecurityService cleaning = cleaningN == 1 ?
                new AQARASecurityService(
                    typeN == 1 ?
                    SecurityType.DoorLock :
                    typeN == 2 ?
                    SecurityType.Camera :
                    SecurityType.Detector
                    , rnd.Next(1000, 3000)) :
                new XiaomiSecurityService(
                    typeN == 1 ?
                    SecurityType.DoorLock :
                    typeN == 2 ?
                    SecurityType.Camera :
                    SecurityType.Detector
                    , rnd.Next(500, 10000));
            return cleaning;
        }

        public int CompareTo(SecurityService? other)
        {
            return price.CompareTo(other?.price);
        }
    }

    class XiaomiSecurityService : SecurityService
    {
        string brandName;
        SecurityType type;
        int price;

        public XiaomiSecurityService(SecurityType type, int price, string brandName = "Xiaomi") : base(type, price, brandName)
        {
            this.brandName = brandName;
            this.type = type;
            this.price = price;
        }
    }

    class AQARASecurityService : SecurityService
    {
        string brandName;
        SecurityType type;
        int price;

        public AQARASecurityService(SecurityType type, int price, string brandName = "AQARA") : base(type, price, brandName)
        {
            this.brandName = brandName;
            this.type = type;
            this.price = price;
        }
    }
}
