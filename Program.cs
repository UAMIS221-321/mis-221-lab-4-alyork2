
int input;

//start main

Console.WriteLine("Please enter 1, 2, or 3: ");
input = int.Parse(Console.ReadLine());

while(input != 3)
{
    Console.WriteLine();
    if(input == 1)
    {
        GetFull();
    }
    else if(input == 2)
    {
        GetPartial();
    }
    else 
    {
        Console.WriteLine("Please enter a valid number. ");
    }
    Console.WriteLine();

    Console.WriteLine("Please enter 1, 2, or 3: ");
    input = int.Parse(Console.ReadLine());
}

//end main

static void GetFull()
{
    Random rnd = new Random();
    int circle = rnd.Next(3,9);
    
    for(int i = 0; i <= circle; i++)
    {
        for(int j = 0; j <= i; j++)
        {
            Console.Write("O ");
        } 
        Console.WriteLine();
    }
}

static void GetPartial()
{
    Random rnd = new Random();
    int circle = rnd.Next(3,9);

    for(int i = 0; i <= circle; i++)
    {
        for(int j = 0; j <= i; j++)
        {
            Random rnd2 = new Random();
            int gap = rnd2.Next(3);
            if(gap == 0)
            Console.Write(" ");
            else
            Console.Write("O ");
        }
        Console.WriteLine();
    }

}
