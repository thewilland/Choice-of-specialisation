# Choice-of-specialisation
Final project

#Описание основных компонентов#

*a* - начальный массив
*result* - результирующий массив

*initial array* - подпрограмма заполнения начального массива значениями
*result_array* - подпрограмма получения результирующего массива
*print_result_array* - подпрограмма вывода результирующего массива

#Описание подпрограмм#

##initial_array##
    string[] a = new string[size];
С помощью *new* создается новый массив
    System.Console.WriteLine("Enter array elements: ");
*System.Console.WriteLine* печатает приглашение для ввода значений массива
    for(int i = 0; i < size; i ++)
        a[i] = Console.ReadLine();
В цикле *for* с помощью *Console.ReadLine()* последовательно вводятся с клавиатуры строки массива
    return a;
*return* возвращает массив в основную программу

##result_array##