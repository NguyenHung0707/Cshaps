// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.ComponentModel.DataAnnotations;

class Atomic
{
    private string number;
    private string symbol;
    private string fullname;
    private string weight;

    public Atomic(string number, string symbol, string fullname, string weight)
    {
        this.number = number;
        this.symbol = symbol;
        this.fullname = fullname;
        this.weight = weight;
    }

    public Atomic()
    {
    }

    ArrayList array = new ArrayList();

     public Boolean accept()
    {
        System.Console.WriteLine("Enter atomic number : ");
        number = Console.ReadLine();

        System.Console.WriteLine("Enter symbol : ");
        symbol = Console.ReadLine();

        System.Console.WriteLine("Enter full name : ");
        fullname = Console.ReadLine();

        System.Console.WriteLine("Enter automic weight : ");
        weight = Console.ReadLine();

        Atomic at = new Atomic(number, symbol, fullname, weight);
        array.Add(at);
        return true;
    }

    public void Display()
    {
        foreach(Atomic at in array)
        {
            System.Console.WriteLine(at.number + " " + at.symbol + " " + at.fullname + " " + at.weight );
        }
    }
}