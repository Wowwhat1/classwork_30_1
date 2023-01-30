// See https://aka.ms/new-console-template for more information
using ConsoleApp3;

var lines = int.Parse(Console.ReadLine());
var people = new List<Person>();
for (int i = 0; i < lines; i++)
{
    var cmdArgs = Console.ReadLine().Split();
    string name = cmdArgs[0];
    int age = int.Parse(cmdArgs[1]);
    double salary = double.Parse(cmdArgs[2]);
    Person person= new Person(name, age, salary);
    people.Add(person);
}

var sorted = people.OrderBy(p => p.Name).ThenBy(p => p.Age).ToList();

Console.WriteLine(string.Join(Environment.NewLine, sorted));
