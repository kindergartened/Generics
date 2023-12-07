using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    abstract class AssistantSpeaker : IComparable<AssistantSpeaker>
    {
        string brandName;
        int volume;
        int price;

        public AssistantSpeaker(int volume, int price, string brandName)
        {
            this.brandName = brandName;
            this.volume = volume;
            this.price = price;
        }

        public static AssistantSpeaker Generate()
        {
            Random rnd = new Random();
            int assistantN = rnd.Next(0, 3);
            AssistantSpeaker assistant = assistantN == 1 ?
                new XiaomiAssistantSpeaker(rnd.Next(1, 101), rnd.Next(1000, 3000)) :
                assistantN == 2 ?
                new AppleAssistantSpeaker(rnd.Next(15, 101), rnd.Next(10000, 30000)) :
                new YandexAssistantSpeaker(rnd.Next(15, 101), rnd.Next(500, 10000));
            return assistant;
        }

        public int CompareTo(AssistantSpeaker? other)
        {
            return price.CompareTo(other?.price);
        }
    }

    class YandexAssistantSpeaker : AssistantSpeaker
    {
        string brandName;
        int volume;
        int price;
        string name;

        public YandexAssistantSpeaker(int volume, int price, string name = "Alice", string brandName = "Yandex") : base(volume, price, brandName)
        {
            this.brandName = brandName;
            this.volume = volume;
            this.price = price;
            this.name = name;
        }
    }

    class AppleAssistantSpeaker : AssistantSpeaker
    {
        string brandName;
        int volume;
        int price;
        string name;

        public AppleAssistantSpeaker(int volume, int price, string name = "Siri", string brandName = "Apple") : base(volume, price, brandName)
        {
            this.brandName = brandName;
            this.volume = volume;
            this.price = price;
            this.name = name;
        }
    }

    class XiaomiAssistantSpeaker : AssistantSpeaker
    {
        string brandName;
        int volume;
        int price;
        string name;

        public XiaomiAssistantSpeaker(int volume, int price, string name = "MiHome", string brandName = "Xiaomi") : base(volume, price, brandName)
        {
            this.brandName = brandName;
            this.volume = volume;
            this.price = price;
            this.name = name;
        }
    }
}
