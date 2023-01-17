using System.Collections;

List<int> List = new List<int>();
List.Add(137);
List.Add(1000);
List.Add(-200);
var list = List.ToArray();

IEnumerator enumerator = List.GetEnumerator();
foreach (var item in List)
{
    Console.WriteLine(item);
}