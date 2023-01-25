public class MyLibrary
{

    // 1. Вывод сообщения + Спрашиваем из скольких элементов будет состоять массив
    public static int WriteLine(string text)
    {
        Console.WriteLine(text);
        int numbers = int.Parse(Console.ReadLine());
        return numbers;
    }

    // 2. Создаем массив
    public static string[] CreateArray(int numbers)
    {
        return new string[numbers];
    }

    // 3. Заполняем массив данными от пользователя
    public static void ArrayFill(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($" Введите {i + 1} строку: ");

            array[i] = Console.ReadLine();
        }

    }

    // 4. Сколько данных в массиве содержат количество символов, указанных в теле задачи 
    public static int CheckArray(string[] array, int length)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= length) result++;
        }
        return result;
    }

    //5. Заполнение нового массива данными с новым количеством символов
    public static void NewArray(string[] array, string[] arrNew, int result)
    {
        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= result)
            {
                arrNew[temp] = array[i];
                temp++;
            }
        }
    }

    //6. Вывод массива
    public static string PrintArray(string[] array)
    {
        return String.Join(' ', array);
    }

}