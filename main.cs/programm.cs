namespace Drink_All
{
    /**
     *  торговый автомат
     *  напитки (имя, обем) ,  -> горячий
     */


    internal class Program 
    {
        static void Main(string[] args)
        {
            UI uI = new UI();

            uI.PushVendingDrinks();

            uI.AskDrinks();
            uI.AskDrinks();
            uI.AskDrinks();
            uI.AskDrinks();
            uI.AskDrinks();
        }
    }
}