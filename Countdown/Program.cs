// This is challenge work for the "C# Players Guide"
// Level 13 the countdown Challenge
// This is a simple task to create a countdown from 10 to 1 without using loops.
// The goal is to use recursion

int countDownNumber = 10;

CountDownMethod(countDownNumber);

void CountDownMethod(int countDownNumber)
{
    Console.WriteLine(countDownNumber);

   if (countDownNumber == 1) 
    {
        return;
    }
   else
    {
        countDownNumber--;
        CountDownMethod(countDownNumber);
    }
}

Console.WriteLine("Press any key to end recursive countdown program");
Console.ReadKey();
