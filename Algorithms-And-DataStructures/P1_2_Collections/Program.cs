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

ArrayList Forsbergs = new ArrayList();
Forsbergs.Add(true);
Forsbergs.Add("Forsbergs");
Forsbergs.Add('a');
Forsbergs.Add(1000);
Forsbergs.Add(0.12f);

foreach (var item in Numbers)
{
    Console.WriteLine(item);
}

IEnumerator enumerator = Forsbergs.GetEnumerator();
foreach (var item in Forsbergs)
{
    Console.WriteLine(item);
}

for (int i = 0; i < Forsbergs.Count; i++)
{
    Console.WriteLine(Forsbergs[i]);
}
