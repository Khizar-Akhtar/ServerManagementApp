

using System.ComponentModel;

List<string> movies = new List<string>(3);
List <int> number=new List<int>(4);



number.AddRange(new int[] { 1, 2, 3, 4 });


foreach (int num in number)
{
    Console.WriteLine(num);
}

