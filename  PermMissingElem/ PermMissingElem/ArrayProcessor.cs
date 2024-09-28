namespace PermMissingElem;

public static class ArrayProcessor
{
    public static int SeekMissing(int[] input)
    {
        const int first = 1;
        long last = input.Length + 1;

        var sum = (first + last) * last / 2;

        for (var i = 0; i < input.Length; i++)
        {
            sum -= input[i];
        }

        return (int)sum;
    }
}