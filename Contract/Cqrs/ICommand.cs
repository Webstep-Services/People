namespace Wss.Cqrs
{
    public interface ICommand<T> where T : class
    {
        void Add(T instance);
        void Update(T instance);
        void Delete(T instance);
    }
}
