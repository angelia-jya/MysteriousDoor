string secretCode ="1992";
string attempt ="";

int tries = 3;

while (attempt != secretCode && tries > 0)
{
    tries--;

    Console.Write("Enter the secret code: ");
    attempt = Console.ReadLine();
   
    if (attempt != secretCode)
    {
    Console.WriteLine("wrong code,try again");
    Console.WriteLine($"\n {tries} attempt(s) remaining");
    }
    else
    {
        Console.WriteLine("The door is unlocked. Congratulations!");
    }
}

