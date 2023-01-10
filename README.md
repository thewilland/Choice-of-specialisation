# Choice-of-specialisation
Final project

# Описание основных компонентов

**a** - начальный массив

**result** - результирующий массив

**initial array** - подпрограмма заполнения начального массива значениями

**result_array** - подпрограмма получения результирующего массива

**print_result_array** - подпрограмма вывода результирующего массива

# Описание подпрограмм #

## initial_array

```
    string[] initial_array(int size)
{
    string[] a = new string[size];
    System.Console.WriteLine("Enter array elements: ");
    for(int i = 0; i < size; i ++)
        a[i] = Console.ReadLine();
    return a;
}

```

С помощью **new** создается новый массив строк

**System.Console.WriteLine** печатает приглашение для ввода значений массива

В цикле **for** с помощью *Console.ReadLine()* последовательно вводятся с клавиатуры строки массива

**return** возвращает массив в основную программу

## result_array

````
string[] result_array(string[] a)
{
    string[] result = new string[a.Length];
    for(int i = 0; i < a.Length; i ++)
        if (a[i].Length <= 3)
            result[i] = a[i];
   
    return result;
}

````

С помощью **new** создается результирующий массив

**System.Console.WriteLine** печатает приглашение для ввода значений массива

В цикле **for** с помощью **Length** получаем длину строки (текущий элемент массива) и помещаем в результирующий только те строки, длина которых не больше 3-х

**return** возвращает массив строк в основную программу

## print_result_array


````
void print_result_array(string[] a)
{
    for(int i = 0; i < a.Length; i ++)
        if (a[i] != null)
            System.Console.Write($"{a[i],5}");;
}

````

Подпрограмма **print_result_array** ничего в основную программу не возвращает? поэтому она **void**

В цикле **for** с помощью **Length** выбираем непустые строки (**a[i] != null**) и печатаем их в консоль

## The End :)