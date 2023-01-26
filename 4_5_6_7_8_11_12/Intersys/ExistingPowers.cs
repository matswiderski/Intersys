namespace Intersys;
public class ExistingPowers
{
    public void Start()
    {
        List<uint> list = new();
        try
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                    break;
                list.Add(UInt32.Parse(input));
            }
            DisplayPowers(FindPowers(list));
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private List<uint> FindPowers(List<uint> list)
    {
        List<uint> results = new();
        for (int i = 0; i < list.Count; i++)
        {
            int exponent = 0;
            while (true)
            {
                uint pow = (uint)Math.Pow(2, exponent);
                if (pow > list[i])
                    break;
                exponent++;
                if (!results.Contains(pow))
                    results.Add(pow);
            }
        }
        return results;
    }

    private void DisplayPowers(List<uint> results)
    {
        if (results.Count == 0)
            Console.WriteLine("NA");
        else
        {
            for (int i = 0; i < results.Count - 1; i++)
            {
                Console.Write($"{results[i]}, ");
            }
            Console.Write($"{results[results.Count - 1]}");
        }
    }
}
