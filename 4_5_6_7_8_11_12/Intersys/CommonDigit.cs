namespace Intersys;
public class CommonDigit
{
    public void Start()
    {
        int N;
        bool correctFormat = Int32.TryParse(Console.ReadLine(), out N);
        if (!correctFormat)
        {
            Console.WriteLine("Wrong N format");
            return;
        }

        string concatedArray = String.Empty;
        try
        {
            concatedArray = GetInputArray(N);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine(FindCommonDigit(concatedArray));

    }

    private string GetInputArray(int N)
    {
        int[] inputArray = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();
        if (inputArray.Length != N)
            throw new FormatException();
        return String.Concat(inputArray);
    }

    private int FindCommonDigit(string concatedArray)
    {
        var distinct = concatedArray.Distinct();
        Dictionary<char, int> countDict = new();
        foreach (var character in distinct)
            countDict.Add(character, concatedArray.Count(c => c.Equals(character)));
        int common = (Int32)Char.GetNumericValue(countDict.OrderBy(x => x.Value)
            .Where(x => x.Value == countDict.FirstOrDefault().Value)
            .OrderByDescending(x => x.Key)
            .FirstOrDefault().Key);
        return common;
    }
}