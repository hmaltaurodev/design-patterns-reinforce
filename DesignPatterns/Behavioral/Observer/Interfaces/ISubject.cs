namespace DesignPatterns.Behavioral.Observer.Interfaces
{
    public interface ISubject
    {
        public void Attach(IObserver observer);

        public void Notify();
    }
}
