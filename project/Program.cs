//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] initial_array(int size)
{
    string[] a = new string[size];
    System.Console.WriteLine("Enter array elements: ");
    for(int i = 0; i < size; i ++)
        a[i] = Console.ReadLine();
    return a;
}

string[] result_array(string[] a)
{
    string[] result = new string[a.Length];
    for(int i = 0; i < a.Length; i ++)
        if (a[i].Length <= 3)
            result[i] = a[i];
   
    return result;
}

void print_result_array(string[] a)
{
    for(int i = 0; i < a.Length; i ++)
        if (a[i] != null)
            System.Console.Write($"{a[i],5}");;
}

string[] a = initial_array(4);
string[] result = result_array(a);
System.Console.WriteLine("The result array is: ");
print_result_array(result);
System.Console.WriteLine();
