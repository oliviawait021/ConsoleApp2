namespace MoreCsharpFun;

public class PrintStuff
{
    private string language;
    
    // Constructor for if they don't pass in a langauge (overloaded)
    public PrintStuff()
    {
        language = "EN";
    }
    
    // Constructor for if they DO pass in a language
    public PrintStuff(string temp)
    {
        language = temp;
    }
    public void PrintName(string n)
    {
        if (language == "EN")
        {
            System.Console.WriteLine("Hello " + n + "!");
        }

        if (language == "ES")
        {
            System.Console.WriteLine("iHola " + n + "!");
        }
    }
    // This method overloads the one above, if a name isn't passed
    public void PrintName()
    {
        if (language == "EN")
        {
            System.Console.WriteLine("Hello John or Jane Doe!");
        }

        if (language == "ES")
        {
            System.Console.WriteLine("iHola Juan o Juana!");
        }
    }
}