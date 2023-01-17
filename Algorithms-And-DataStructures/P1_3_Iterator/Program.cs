﻿//Create a Project named 1_3_Iterator
//Create a List with 5 numbers: 1, 1, 2, 3, 5.
//Assign it to a Variable of Type IEnumerable.
//Use GetEnumerator() and a while-Loop to print all elements of the IEnumerable-Variable.
//Can you also add up all numbers of the List using IEnumerable and then print the sum? If not, then what do you need to change?
//Implement the functions GetOddNumbers and GetOddNumbersList documented below within your TurboMaths class
//Hint: use yield within GetOddNumbers
//Add Unit Tests for both Functions (Use the test cases documented above the function as a base)
//Invoke each functions within Program in your 1_3_Iterator Project and pass 12 as an argument
//Use foreach to iterate over the result and print each number of the result
//Invoke GetOddNumbers with 1_000_000_000 as an argument. No Problem, right?
//Invoke GetOddNumbersList with 1_000_000_000 as an argument. Observe the result.

using System.Collections;
using TurboCollections;

List<int> iterator = new List<int>();
iterator.Add(1);
iterator.Add(1);
iterator.Add(2);
iterator.Add(3);
iterator.Add(5);

IEnumerator enumerator = iterator.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine(iterator.Sum());
}

List<int> NumbersOdd = TurboMaths.GetOddNumbersList(12);

foreach (var item in NumbersOdd)
{
    Console.WriteLine(item);
}

foreach (var item in TurboMaths.GetOddNumbers(12))
{
    Console.WriteLine(item);
}