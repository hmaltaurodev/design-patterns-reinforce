using DesignPatterns.Behavioral.Observer.Interfaces;

namespace DesignPatterns.Behavioral.Observer.Subjects
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
