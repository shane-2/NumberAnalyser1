Console.WriteLine("Hello, what is your name?");
string name = Console.ReadLine();

int loop = -1;

do
{
    

    Console.WriteLine(name + " Please enter a number 1-100 or 0 to leave");
    int userNum = int.Parse(Console.ReadLine());

    if (userNum > 100 || userNum < 0)
        break;

    //"odd and less than 60"
    else if (userNum < 60 && userNum % 2 == 1)
        Console.WriteLine("Odd and less than 60");

    //2-24 and even "even and less than 25"
   else if (userNum > 1 && userNum < 25 && userNum % 2 == 0)
        Console.WriteLine("Even and less than 25");

    //"even and between 26 and 60"
   else if (userNum > 25 && userNum < 61 && userNum % 2 == 0)
        Console.WriteLine("Even and between 26 and 60");

    //even and greater than 60
    else if (userNum > 60 && userNum % 2 == 0)
        Console.WriteLine("Even and greater than 60");

    //odd and greater than 60
   else if (userNum > 60 && userNum % 2 == 1)
        Console.WriteLine("Odd and greater than 60");

   else if (userNum == 0)
    {
        Console.WriteLine("Goodbye!");
        loop++;
    }
}
while (loop != 0);

