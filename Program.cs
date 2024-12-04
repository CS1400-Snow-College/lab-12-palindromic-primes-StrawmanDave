//David Barlow 12/3/24 Lab-12 Palindromic primes

//setup
using System.Diagnostics;
Console.Clear();
//Debug.Assert(isPalindromic(ReadNumber()) == true);
Console.WriteLine("This program will find the Nth Palindromic Prime.");
Console.WriteLine("All you have to do is enter a number for the nth prime you would like to see.");
Console.WriteLine("What Nth Palindromic Prime whould you like to see");
Console.WriteLine(NthPalindromicPrime(ReadNumber()));

long NthPalindromicPrime(long n)
{
    long nth = 0;
    int i = 1;
    int x = 0;
    do
    {
        i++;
        if(isPrime(i) == true && isPalindromic(i) == true)
        {
            x++;
            if(x > n)
            {
                break;
            }
            nth = i;
        }
    }while(true);
    return nth;
}

// to check if the number is prime
bool isPrime (long num)
{
    double squar = Math.Sqrt(num);
    for(int i = 2; i <= squar; i++)
    {
        if(num % i == 0)
            return false;
    }
    return true;
}

// to check if the number is palindromic
bool isPalindromic(long num)
{
    string NumString = num.ToString();
    if(writeBackwards(NumString) == NumString)
    {
        return true;
    }else
    {
        return false;
    }
    return false;
}

long ReadNumber()
{
    long number = -1;
    do
    {
        try
        {
            Console.Write("Please enter a number ");
            string num = Console.ReadLine();
            number = Convert.ToInt64(num);
            return number;
        }catch(FormatException)
        {
            number = -1;
            //Console.WriteLine("That was not a number try again");
        }
    }while(number == -1);
    return number;
}

string writeBackwards(string forwards)
{
    List<char> Characters = new List<char>();
    string newString = "";
    foreach(char a in forwards)
    {
        Characters.Add(a);
    }
    Characters.Reverse();
    for(int i = 0; i<Characters.Count; i++)
    {
        //Console.Write(Characters[i]);
        newString = newString + Characters[i];
    }
    return newString;
}