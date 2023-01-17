//Create a Project named P1_2_Collections
//Create a List to store the numbers 137,1000, -200
//Use a for-Loop and the index-Operator [] to print all values in the List
//Create an ArrayList to store the values true, "Forsbergs", 'a', 1000, .12f;
//Use a for-Loop and the index-Operator [] to print all values in the ArrayList

using System.Collections;

List<int> Numbers = new List<int>();
Numbers.Add(137);
Numbers.Add(1000);
Numbers.Add(-200);

IEnumerator enumerator = Numbers.GetEnumerator();
foreach (int item in Numbers)
{
    Console.WriteLine(item);
}

