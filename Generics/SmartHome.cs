using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generics
{
    public class SmartHome<V, U, T, S> : IComparable<SmartHome<V, U, T, S>>
    {
        protected U lights;
        protected V voiceAssistantSpeaker;
        protected T cleaningService;
        protected S securityService;
        private int totalSum;

        public SmartHome(V assistant, U lights, T cleaning, S security)
        {
            voiceAssistantSpeaker = assistant;
            this.lights = lights;
            cleaningService = cleaning;
            securityService = security;
            totalSum = 0;
            AssistantSpeaker? assistantCast = voiceAssistantSpeaker as AssistantSpeaker;
            if (assistantCast != null)
                totalSum += assistantCast.Price;
            Lights? lightsCast = this.lights as Lights;
            if (lightsCast != null)
                totalSum += lightsCast.Price;
            CleaningService? cleaningCast = cleaningService as CleaningService;
            if (cleaningCast != null)
                totalSum += cleaningCast.Price;
            SecurityService? securityCast = securityService as SecurityService;
            if (securityCast != null)
                totalSum += securityCast.Price;
        }

        public int TotalSum { get => totalSum; set => totalSum = value; }

        public static SmartHome<
            AssistantSpeaker,
            Lights,
            CleaningService,
            SecurityService
        > Generate()
        {
            return new SmartHome<
                AssistantSpeaker, 
                Lights, 
                CleaningService,
                SecurityService
            >(
                AssistantSpeaker.Generate(),
                Lights.Generate(), 
                CleaningService.Generate(), 
                SecurityService.Generate()
            );
        }

        public int CompareTo(SmartHome<V, U, T, S>? other)
        {
            return this.TotalSum.CompareTo(other?.TotalSum);
        }

        public override string ToString()
        {
            return $"Общая стоимость аппаратуры: {TotalSum}\n {'{'}\n \t Свет: {lights},\n \t Голосовой помощник: {voiceAssistantSpeaker},\n \t Уборка: {cleaningService},\n \t Система безопасности: {securityService} \n{'}'}";
        }
    }
}
