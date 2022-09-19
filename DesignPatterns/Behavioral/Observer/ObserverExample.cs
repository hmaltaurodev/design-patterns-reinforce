using DesignPatterns.Behavioral.Observer.Observers;
using DesignPatterns.Behavioral.Observer.Subjects;

namespace DesignPatterns.Behavioral.Observer
{
    public class ObserverExample
    {
        public static void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Observer Example");
            Console.ForegroundColor = ConsoleColor.DarkGray;

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
