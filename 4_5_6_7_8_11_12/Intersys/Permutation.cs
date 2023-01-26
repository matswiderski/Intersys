namespace Intersys;
public class Permutation
{
    public void Start()
    {
        int[] firstArray = new int[11], secondArray = new int[11];
        try
        {
            firstArray = GetInputArray(firstArray);
            secondArray = GetInputArray(secondArray);
            Console.WriteLine(IsPermutation(firstArray, secondArray) ? "YES" : "NO");

        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }


    private int[] GetInputArray(int[] array)
    {
        var inputArray = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();
        if (inputArray.Length != array.Length)
            throw new FormatException();
        return inputArray;
    }

    private bool IsPermutation(int[] firstArray, int[] secondArray)
    {
        Array.Sort(firstArray);
        Array.Sort(secondArray);
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
                return false;
        }
        return true;
    }
}
