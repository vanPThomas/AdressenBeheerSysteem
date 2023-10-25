using AdressClassLibrary;
namespace ConsoleAsker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataManager dataManager = new DataManager();
            ShowMenu(dataManager);
        }
        static void ShowMenu(DataManager dataManager)
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Make a choice: [1] Add Adress, [2] Show Adress, [3] Stop");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    FillInfo(dataManager);
                }
                else if (choice == 2)
                {

                }
                else if (choice == 3)
                {
                    keepRunning = false;
                }
            }
        }
        static void FillInfo (DataManager dataManager)
        {
            Console.WriteLine("Give a town name: ");
            string townName = Console.ReadLine();
            Console.WriteLine("Give a Street Name: ");
            string streetName = Console.ReadLine();

            bool validHouseNumber = false;
            string houseNumber;
            while (!validHouseNumber)
            {
                Console.WriteLine("Give a House Number: ");
                houseNumber = Console.ReadLine();
                Adress.ValidHouseNumber(houseNumber);
            }
            
            dataManager.AddAdress(townName, streetName, houseNumber);
            
        }
    }
}