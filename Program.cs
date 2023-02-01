string selection; int nu1 = 0, nu2 = 0, nu3 = 0;
do
{
    Console.Clear();
    Console.WriteLine("What do you want to execute?");
    Console.WriteLine("============================");
    Console.WriteLine();
    Console.WriteLine("0. Calculate Circle Area");
    Console.WriteLine("1. Random in Range");
    Console.WriteLine("2. To FizzBuzz");
    Console.WriteLine("3. Fibonacci by Index");
    Console.WriteLine("4. Ask for Number in Range");
    Console.WriteLine("5. Is palindrome?");
    Console.WriteLine("6. Is palindrome? (advanced)");
    Console.WriteLine("7. Chart Bar");
    Console.WriteLine("8. Count Smiling Faces");
    Console.WriteLine("q to Quit");
    selection = Console.ReadLine()!;

    if (selection != "q")
    {
        Console.Clear();
        switch (selection)
        {
            case "0": RunCalculateCircleArea(); break;

            case "1":
                for (int i = 0; i < 1000000; i++)
                {
                    Console.WriteLine(RandomInRange(0, 2));
                }
                break;
            case "2": Console.WriteLine(ToFizzBuzz(0)); break;
            case "3": Console.WriteLine(FibonacciByIndex(0)); break;
            case "4": Console.WriteLine(AskForNumberInRange(0, 0)); break;
            case "5": Console.WriteLine(IsPalindrome("")); break;
            case "6": Console.WriteLine(IsPalindromeAdvanced("")); break;
            case "7": Console.WriteLine(ChartBar(0)); break;
            default: break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
while (selection != "q");
#region Calculate Circle Area
void RunCalculateCircleArea()
{
    Console.Write("Enter radius:");
    var radius = double.Parse(Console.ReadLine()!);
    var area = CalculateCircleArea(radius);
    Console.WriteLine($"Area of circle with radius {radius} is {area}");
}
double CalculateCircleArea(double radius)
{
    return radius * radius * Math.PI;
}
#endregion
string RandomInRange(int min, int max)
{
    /*Console.Write("Enter min: ");
    min = int.Parse(Console.ReadLine()!);
    Console.Write("Enter max: ");
    max = int.Parse(Console.ReadLine()!);*/
    int randomNumber = Random.Shared.Next(min, max + 1);
    if (randomNumber == 0) { nu1++; return $"{randomNumber}, {nu1}"; }
    else if (randomNumber == 1) { nu2++; return $"{randomNumber}, {nu2}"; }
    else { nu3++; return $"{randomNumber}, {nu3}"; }
}
string ToFizzBuzz(int input)
{
    Console.Write("Please enter your number: ");
    input = int.Parse(Console.ReadLine()!);
    if (input % 3 == 0 && input % 5 == 0)
    {
        return "FizzBuzz"; ;
    }
    else if (input % 3 == 0)
    {
        return "Fizz";
    }
    else if (input % 5 == 0)
    {
        return "Buzz";
    }
    else
    {
        return $" {input} ";
    }
}
string FibonacciByIndex(double index)
{
    Console.Write("Please enter your index: ");
    index = double.Parse(Console.ReadLine()!);
    double number1 = 0;
    double number2 = 1;
    for (int i = 1; i <= index; i++)
    {

        double number3 = number1 + number2;
        number1 = number2;
        number2 = number3;
    }
    return $"{number1}";
}
int AskForNumberInRange(int min, int max)
{
    int input = 0;
    Console.Write("Please enter your min: ");
    min = int.Parse(Console.ReadLine()!);
    Console.Write("Please enter your max: ");
    max = int.Parse(Console.ReadLine()!);
    do
    {
        Console.Write($"Please enter a number between {min} and {max}: ");
        input = int.Parse(Console.ReadLine()!);
        if (input < min || input > max) { Console.WriteLine("Incorrect input please try again"); }
    } while (input < min || input > max);
    return input;
}
bool IsPalindrome(string word)
{
    Console.Write("Please enter your word: ");
    word = Console.ReadLine()!.ToLower();
    string reversed = string.Join("", word.Reverse());
    if (reversed == word) { return true; }
    else { return false; }
}
bool IsPalindromeAdvanced(string word)
{
    Console.Write("Please enter your word: ");
    word = Console.ReadLine()!.ToLower();
    word = word.Replace(" ", "").Replace(",", "").Replace(".", "");
    string reversed = string.Join("", word.Reverse());
    if (reversed == word) { return true; }
    else { return false; }
}
string ChartBar(double number)
{
    Console.Write("Please enter your number [between 0 and 1]: ");
    number = double.Parse(Console.ReadLine()!);
    if (number < 0 || number > 1) { return ""; }
    else if (number >= 0 && number < 0.1) { return ".........."; }
    else if (number >= 0.1 && number < 0.2) { return "o........."; }
    else if (number >= 0.2 && number < 0.3) { return "oo........"; }
    else if (number >= 0.3 && number < 0.4) { return "ooo......."; }
    else if (number >= 0.4 && number < 0.5) { return "oooo......"; }
    else if (number >= 0.5 && number < 0.6) { return "ooooo....."; }
    else if (number >= 0.6 && number < 0.7) { return "oooooo...."; }
    else if (number >= 0.7 && number < 0.8) { return "ooooooo..."; }
    else if (number >= 0.8 && number < 0.9) { return "oooooooo.."; }
    else if (number >= 0.9 && number < 1.0) { return "ooooooooo."; }
    else { return "oooooooooo"; }
}