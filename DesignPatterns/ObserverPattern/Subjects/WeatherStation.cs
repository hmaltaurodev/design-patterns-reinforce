using DesignPatterns.ObserverPattern.Interfaces;

namespace DesignPatterns.ObserverPattern.Subjects
{
    public class WeatherStation : ISubject
    {
        private readonly List<IObserver> Observers;
        private float _temperature;

        public float Temperature
        {
            get { return _temperature; }
            set { _temperature = value; Notify(); }
        }

        public WeatherStation()
        {
            this.Observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Notify()
        {
            Observers.ForEach(o =>
            {
                o.Update(this);
            });
        }
    }
}
