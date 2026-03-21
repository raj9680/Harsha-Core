public class BankProject
{
    public void BankPro()
    {
        Console.WriteLine("*********Common Bank***********");
        Console.WriteLine("::Login Page::");
        Console.WriteLine("Press enter to exit.");
        Console.WriteLine("username: ");

        string username = null; string password = null;
        username = Console.ReadLine();
        if (username != "")
        {
            Console.WriteLine("password: ");
            password = Console.ReadLine();
        }

        if(username == "system" && password == "manager")
        {
            int mainMenuChoice = -1;
            do
            {
                Console.WriteLine(":::Main Menu:::");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Funds Transfer");
                Console.WriteLine("4. Funds Transfer Statement");
                Console.WriteLine("5. Account Statement");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter Choice");
                mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1: customerMenu();
                        break;
                    case 2: accountMenu();
                        break;
                    case 3: //
                        break;
                    case 4: //
                        break;
                    case 5: //
                        break;
                    default: // Exit
                        break;
                }

            } while (mainMenuChoice != 0);
        } else
        {
            Console.WriteLine("Invalid username or password");
        }
        Console.WriteLine("Thank you! Visit again.");
        Console.ReadKey();
    }

    // Customer Menu
    static void customerMenu()
    {
        int customerMenuChoice = -1;
        do
        {
            Console.WriteLine("\n :::Customer Menu:::");
            Console.WriteLine("1.Add Customer");
            Console.WriteLine("2.Delete Customer");
            Console.WriteLine("3.Update Customer");
            Console.WriteLine("4.View Customer");
            Console.WriteLine("0.Back to Main Menu");
            Console.WriteLine("Enter Choice: ");
            customerMenuChoice = Convert.ToInt32(Console.ReadLine());
            switch(customerMenuChoice)
            {
                case 1: //
                    break;
                case 2: //
                    break;
                case 3: //
                    break;
                case 4: //
                    break;
                default : //
                    break;
            }
        } while (customerMenuChoice != 0);
    }

    // Accounts Menu
    static void accountMenu()
    {
        int accountMenuChoice = -1;
        do
        {
            Console.WriteLine("\n :::Accounts Menu:::");
            Console.WriteLine("1.Add Account");
            Console.WriteLine("2.Delete Account");
            Console.WriteLine("3.Update Account");
            Console.WriteLine("4.View Account");
            Console.WriteLine("0.Back to Main Menu");
            Console.WriteLine("Enter Choice: ");
            accountMenuChoice = Convert.ToInt32(Console.ReadLine());
            switch (accountMenuChoice)
            {
                case 1: //
                    break;
                case 2: //
                    break;
                case 3: //
                    break;
                case 4: //
                    break;
                default: //
                    break;
            }
        } while (accountMenuChoice != 0);
    }
}