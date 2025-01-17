﻿public class Test // Написать программу, которая из имеющегося массива строк формирует массив из строк,
                  // длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
                  // либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
                  // лучше обойтись исключительно массивами.
{
    static void Main(string[] args)
    {
        string[] initialArray = new string[] {"Russia", "123", "123456789$%^", "goose", "89", "@#", "98", "Elena", "Sqrt", "la", "fa" };

        string[] newArray = CreateNewArray(initialArray); // method call

        Console.WriteLine(String.Join(" ", newArray)); // printing elements of the newArray
    }

    public static string[] CreateNewArray (string[] array) 
    {
        string[] newArray;

        int counter = 0;

        for (int i = 0; i < array.Length; i++) // counting the quantity of strings with length <= 3
        {
            if (array[i].Length <= 3) 
            { 
                counter++; 
            }
        }

        newArray = new string[counter]; // new array initialization
        counter = 0;

        for (int i = 0; i < array.Length; i++) // adding the valid strings to the newArray
        {
            if (array[i].Length <= 3) 
            {
                newArray[counter++] = array[i];
            }
        }

        return newArray; // returning
    }
}