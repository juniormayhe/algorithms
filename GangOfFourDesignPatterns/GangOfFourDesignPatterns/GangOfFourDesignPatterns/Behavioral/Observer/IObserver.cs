namespace GangOfFourDesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// Observer class that will have Update() called 
    /// when the subject's state changes.
    /// </summary>
    public interface IObserver
    {
        void Update();
    }
}