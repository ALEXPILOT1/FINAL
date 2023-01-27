// //Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//   При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



void Massiv(string array)
{
    string[] Array = array.Split(' '); 
    string[] Array2 = new string[Array.Length];
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if(  Array[i].Length <= 3)
        {
            System.Console.WriteLine(Array[i]);
            Array2[j]=Array[i];
            j++;
        }
    }
    
}

// System.Console.WriteLine("Введи пару слов ");
// string word = Console.ReadLine();
// Massiv(word);


