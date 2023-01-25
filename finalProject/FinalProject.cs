using static MyLibrary;
public class FinalProject
{
    public static void FinalTask()
    {
        int count = WriteLine("Введите количество элементов массива");
        string[] arr = CreateArray(count);
        ArrayFill(arr);
        // Console.WriteLine(PrintArray(arr));
        int length = 3;
        int countNew = CheckArray(arr, length);
        string[] arrNew = CreateArray(countNew);
        NewArray(arr, arrNew, length);
        Console.WriteLine(PrintArray(arrNew));
    }
}