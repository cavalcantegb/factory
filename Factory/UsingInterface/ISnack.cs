namespace Fabrica.Factory.UsaingInterface
{
    public interface ISnack
    {
        bool IsRefrigirationRequired { get; }
        void Eat();
    }
}