// See https://aka.ms/new-console-template for more information
using MoreCsharpFun;
internal class Program
{
    public static void Main(string[] args)
    {
        PrintStuff ps;
        ps = new PrintStuff("EN");
        string name = "";
        
        System.Console.WriteLine("Please enter you name");
        name = System.Console.ReadLine();
        
        ps.PrintName(name);
    }
}