public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("");

        User blogger= new Blogger(1,"erfan");
        var author =new Author(2,"tina");
        author.CreateDraft(1, "why should we learn C#?", "bla bla bla bla...");
        author.CreateDraft(2, "why should we learn Python?", "bla bla bla bla...");
    }
}
