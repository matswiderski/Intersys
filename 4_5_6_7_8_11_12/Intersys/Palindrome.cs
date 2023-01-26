using System.Text;

namespace Intersys;
public class Palindrome
{
    public void Start()
    {
        string input = Console.ReadLine();
        if (String.IsNullOrEmpty(input))
        {
            Console.WriteLine("Wrong input provided");
            return;
        }

        input = NormalizeInput(input);
        TruePalindrome(input);
    }

    private string NormalizeInput(string input)
    {
        StringBuilder reversedInput = new();
        for (int i = input.Length - 1; i >= 0; i--)
            if (Char.IsLetter(input[i]))
                reversedInput.Append(Char.ToLower(input[i]));

        return reversedInput.ToString();
    }

    private void TruePalindrome(string input)
    {
        StringBuilder reversedInput = new();
        for (int i = input.Length - 1; i >= 0; i--)
            reversedInput.Append(input[i]);

        Console.WriteLine(reversedInput.ToString().Equals(input) ? "YES" : "NO");
    }
}
