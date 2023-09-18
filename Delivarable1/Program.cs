using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to restocking tool.");
        //FULL STOCK AND RESTOCK NUMBERS
        int initialsodasStock = 100;
        int sodasRestock = 40;

        int initialchipsStock = 40;
        int chipsRestock = 20;

        int initialcandyStock = 60;
        int candyRestock = 40;

        Console.Write("How many Sodas have been sold today?  100 are in stock  ");
        string usersodasInput = Console.ReadLine();
        if (int.TryParse(usersodasInput, out int sodasSold))
        {
            if (sodasSold > initialsodasStock)
            {
                Console.WriteLine("Too high ! You cannot sell more sodas than are in stock.");
            }
            else
            {
                //whats left in stock
                int remainingsodasStock = initialsodasStock - sodasSold;
                Console.WriteLine("There are " + remainingsodasStock + " sodas left. ");
                //restock
                if (remainingsodasStock <= sodasRestock)
                {
                    initialsodasStock = remainingsodasStock;

                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        //CHIPS

        Console.Write("How many Chips have been sold today? 40 are in stock  ");
        string userchipsInput = Console.ReadLine();
        if (int.TryParse(userchipsInput, out int chipsSold))
        {
            if (chipsSold > initialchipsStock)
            {
                Console.WriteLine("Too High! You cannot sell more chips than are in stock.");
            }
            else
            {
                int remainingchipsStock = initialchipsStock - chipsSold;
                Console.WriteLine("There are " + remainingchipsStock + " chips left. ");
                //RESTOCK
                if (remainingchipsStock <= chipsRestock)
                {
                    initialchipsStock = remainingchipsStock;

                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        //CANDY

        Console.Write("How many Candy have been sold today? 60 are in stock ");
        string usercandyInput = Console.ReadLine();
        if (int.TryParse(usercandyInput, out int candySold))
        {
            if (candySold > initialcandyStock)
            {
                Console.WriteLine("Too high! You cannot sell more candy than are in stock.");
            }
            else
            {
                int remainingcandyStock = initialcandyStock - candySold;
                Console.WriteLine("There are " + remainingcandyStock + " candy left. ");
                //CANDY RESTOCK
                if (remainingcandyStock <= candyRestock)
                {
                    initialcandyStock = remainingcandyStock ;

                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        //restock
        bool needtorestockSodas = initialsodasStock <= sodasRestock;
        bool needtorestockChips = initialchipsStock <= chipsRestock;
        bool needtorestockCandy = initialcandyStock <= candyRestock;

        //close out
        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked:");
        if (needtorestockSodas)
        {
            Console.WriteLine("Sodas need to be restocked");
        }
        if (needtorestockChips)
        {
            Console.WriteLine("Chips need to be restocked");
        }
        if (needtorestockCandy)
        {
            Console.WriteLine("Candy needs to be restocked");
        }
        if (!needtorestockSodas && !needtorestockChips && !needtorestockCandy)
        {
            Console.WriteLine("No items need to be restocked");
        }

        Console.WriteLine("Goodbye!");
    }
}