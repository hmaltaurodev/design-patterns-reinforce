using DesignPatterns.ObserverPattern.Observers;
using DesignPatterns.ObserverPattern.Subjects;

namespace DesignPatterns.ObserverPattern
{
    public class ObserverExample
    {
        public static void Execute()
        {
            Console.WriteLine("# Observer Example\r\n");

            WeatherStation weatherStation = new();

            NewsAgency newsAgencyToledo = new("Toledo");
            NewsAgency newsAgencyMCR = new("Marechal Cândido Rondon");

            weatherStation.Attach(newsAgencyToledo);
            weatherStation.Attach(newsAgencyMCR);

            weatherStation.Temperature = 13f;
            weatherStation.Temperature = 15.5f;
        }
    }
}
