int age;
int amount;
int setCost;
int company;
string selection;
string loop;

//Menu options
{
    Console.WriteLine("Welcome to 'CinemApp'. Enter the corresponding number to begin using the application:");
    Console.WriteLine("1. Show prices");
    Console.WriteLine("2. Price calculator");
    Console.WriteLine("3. For loop");
    Console.WriteLine("0. Exit");

    selection = Console.ReadLine();
    int selectionValue = int.Parse(selection);

    switch (selection)
    {
        case "0":

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
            int costSum;
            Console.WriteLine("Add a person's age: ");
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

            Console.WriteLine("The sum of the company's tickets = " setcost +" :-");

            break;

        case "3":
            Console.WriteLine("Enter text to be looped 10 times: ");
            loop = Console.ReadLine();
            for (int i = 0; i < 10; i++)
                {
                    Console.Write(i);
                }
            break;

        default:
            break;
    }
 
}