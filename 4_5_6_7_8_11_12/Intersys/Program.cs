namespace Intersys;
public class Program
{
    static void Main(string[] args)
    {
        ReverseArray reverse = new();
        reverse.Start();

        Palindrome palindrome = new();
        palindrome.Start();

        Permutation permutation = new();
        permutation.Start();

        ExistingPowers existingPowers = new();
        existingPowers.Start();

        FindingPrimes findingPrimes = new();
        findingPrimes.Start();

        CommonDigit commonDigit = new();
        commonDigit.Start();

        DigitSum digitSum = new();
        digitSum.Start();
    }
}