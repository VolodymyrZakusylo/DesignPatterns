using System.ComponentModel.DataAnnotations;
using task4;

internal class Program
{
    private static void Main(string[] args)
    {
        Virus child2 = new Virus(1, 1, "Second Child", "Type 3", null);
        Virus child = new Virus(2, 2, "First Child", "Type 2", child2);
        Virus parent = new Virus(3, 3, "Parent Virus", "Type 1", child);


        Console.WriteLine("Original parent and its children:");
        parent.DisplayVirus();
        foreach (var childVirus in parent.Children)
        {
            childVirus.DisplayVirus();
        }
        Virus clone = (Virus)parent.Clone();
        Console.WriteLine("Cloned parent and its children:");
        clone.DisplayVirus();
        foreach (var childVirus in clone.Children)
        {
            childVirus.DisplayVirus();
        }
    }
}