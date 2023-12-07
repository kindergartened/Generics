using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class SmartHome<V, U, T, S> : IComparable<SmartHome<V, U, T, S>>
    {
        protected U lights;
        protected V voiceAssistantSpeaker;
        protected T cleaningService;
        protected S securityService;

        public SmartHome(V assistant, U lights, T cleaning, S security)
        {
            voiceAssistantSpeaker = assistant;
            lights = lights;
            cleaningService = cleaning;
            securityService = security;
        }

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
            return this.CompareTo(other);
        }
    }
}
