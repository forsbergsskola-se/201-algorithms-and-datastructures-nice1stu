//Create a Project named P1_2_Collections
//Create a List to store the numbers 137,1000, -200
//Use a for-Loop and the index-Operator [] to print all values in the List
//Create an ArrayList to store the values true, "Forsbergs", 'a', 1000, .12f;
//Use a for-Loop and the index-Operator [] to print all values in the ArrayList

using System.Collections;

List<int> numbers = new List<int>();
numbers.Add(137);
numbers.Add(1000);
numbers.Add(-200);

ArrayList forsbergs = new ArrayList();
forsbergs.Add(true);
forsbergs.Add("Forsbergs");
forsbergs.Add('a');
forsbergs.Add(1000);
forsbergs.Add(0.12f);

foreach (var item in numbers)
{
    Console.WriteLine(item);
}

IEnumerator enumerator = forsbergs.GetEnumerator();
foreach (var item in forsbergs)
{
    Console.WriteLine(item);
}

for (int i = 0; i < forsbergs.Count; i++)
{
    Console.WriteLine(forsbergs[i]);
}
