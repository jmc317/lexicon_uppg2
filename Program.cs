int age;
int setCost;
int sum=0;
int company;
string selection;
string loop;

{
    bool run = true;
    do //Keeps menu alive throughout the interaction with the app
    {
        Console.WriteLine("Welcome to 'CinemApp'. Enter the corresponding number to begin using the application:");
        Console.WriteLine("1. Show prices");
        Console.WriteLine("2. Price calculator");
        Console.WriteLine("3. For loop");
        Console.WriteLine("0. Exit");

        selection = Console.ReadLine();
        int selectionValue = int.Parse(selection);


        switch (selection) //Determine the cost for each age category through a switch statement
        {

            case "0":
                Console.WriteLine("Exiting application");
                run = false;
                break;

            case "1":
                Console.WriteLine("Enter your age to determine the ticket price: ");
                Console.WriteLine("Below 20: 80:-");
                Console.WriteLine("Regular: 120:-");
                Console.WriteLine("Above 64: 90:-");

                age = Convert.ToInt32(Console.ReadLine());

                if (age < 20)
                {
                    Console.WriteLine("Price is: 80:-");
                    setCost = 80;
                }

                else if (age > 64)

                {
                    Console.WriteLine("Price is: 90:-");
                    setCost = 90;
                }

                else
                {
                    Console.WriteLine("Price is: 120:-");
                    setCost = 120;
                }

                break;

            case "2":
                Console.WriteLine("How many are in the company? ");
                company = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < company; i++) //For every person specified in the company, add one age input, then add the total
                {
                    Console.WriteLine("Add age for this person: ");

                    age = Convert.ToInt32(Console.ReadLine());

                    if (age < 20)
                    {
                        setCost = 80;
                    }

                    else if (age > 64)

                    {
                        setCost = 90;
                    }

                    else
                    {
                        setCost = 120;
                    }
                    sum = sum + setCost;

                }

                Console.Write("The sum of the company's tickets = " + sum);

                break;

            case "3":
                Console.WriteLine("Enter text to be looped 10 times: ");
                loop = Console.ReadLine();
                for (int n = 0; n < 10; n++)
                {
                    Console.Write(n);
                }
                break;


            default:
                Console.WriteLine("Faulty input");
                run = false;
                break;
        }
    }
    while (run == true);


}