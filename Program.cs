string secretCode ="1992";
string attempt ="";

while (attempt != secretCode)
{
    Console.Write("Enter the secret code: ");
    attempt = Console.ReadLine();
    if (attempt != secretCode);
    Console.WriteLine("wrong code,try again");
}

Console.WriteLine("The door is unlocked. Congratulations!");