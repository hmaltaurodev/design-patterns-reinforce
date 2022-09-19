using DesignPatterns.ObserverPattern.Interfaces;
using DesignPatterns.ObserverPattern.Subjects;

namespace DesignPatterns.ObserverPattern.Observers
{
    public class NewsAgency : IObserver
    {
        public string AgencyName { get; set; }

        public NewsAgency(string agencyName)
        {
            AgencyName = agencyName;
        }

        public void Update(ISubject subject)
        {
            if (subject is WeatherStation weatherStation)
                Console.WriteLine($"News Agency {AgencyName} reports a temperature of {weatherStation.Temperature} degrees celsius");
        }
    }
}
