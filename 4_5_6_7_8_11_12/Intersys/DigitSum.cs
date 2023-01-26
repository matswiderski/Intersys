namespace Intersys;
public class DigitSum
{
    public void Start()
    {
        uint N;
        bool correctFormat = UInt32.TryParse(Console.ReadLine(), out N);
        if (!correctFormat)
        {
            Console.WriteLine("Wrong N format");
            return;
        }

        uint[] array = new uint[N];
        try
        {
            array = GetInputArray(N);
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine(FindIndex(array));
    }

    private uint[] GetInputArray(uint N)
    {
        uint[] inputArray = Console.ReadLine().Split(' ').Select(n => UInt32.Parse(n)).ToArray();
        if (inputArray.Length != N)
            throw new FormatException();
        return inputArray;
    }

    private int FindIndex(uint[] array)
    {
        int maxIndex = 0;
        int maxValue = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int tmp = (int)array[i].ToString().Sum(x => Char.GetNumericValue(x));
            if (tmp >= maxValue)
            {
                maxIndex = i;
                maxValue = tmp;
            }
        }
        return maxIndex;
    }
}
