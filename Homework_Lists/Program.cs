
// Add students to a class roster List until there are no more students.
// Then print out the count of students to the Console.

List<string> roster = new List<string>();
string name;

do
{
    //ask for users name (exit to stop)
    Console.Write("Add student to roster: ");
    name = Console.ReadLine();
    roster.Add(name);
} while (name.ToLower() != "exit");

Console.WriteLine(roster.Count());