namespace DesignPatterns.ObserverPattern.Interfaces
{
    public interface ISubject
    {
        public void Attach(IObserver observer);

        public void Notify();
    }
}
