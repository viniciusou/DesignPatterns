namespace AbstractFactory.Interfaces
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
