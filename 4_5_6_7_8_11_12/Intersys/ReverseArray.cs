namespace Intersys;
public class ReverseArray
{
    private string[] _array = Array.Empty<string>();
    public void Start()
    {
        int n;
        bool correctFormat = Int32.TryParse(Console.ReadLine(), out n);
        if (!correctFormat)
        {
            Console.WriteLine("Wrong n format");
            return;
        }

        _array = Console.ReadLine().Split(' ');
        if (_array.Length != n)
        {
            Console.WriteLine("n does not match with number of elements in array");
            return;
        }
        else
            Reverse();
    }

    private void Reverse()
    {
        Array.Reverse(_array);
        for (int i = 0; i < _array.Length; i++)
            Console.Write($"{_array[i]} ");
    }
}
