public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("");

        var blogger = new Blogger(1, "erfan");
        Console.WriteLine(blogger.ToString());
        var author = new Author(2, "tina");
        Console.WriteLine(author.ToString());
        var seoSpecialist = new SEOSpecialist(3, "walter");
        Console.WriteLine(seoSpecialist.ToString());
        var draft1 = author.CreateDraft(1, "why should we learn C#?", "bla bla bla bla...");
        Console.WriteLine(draft1.ToString());
        var draft2 = author.CreateDraft(2, "why should we learn Python?", "bla bla bla bla...");
        Console.WriteLine(draft2.ToString());
        blogger.SetDraftToReadyForSEO(draft1);
        Console.WriteLine(draft1.ToString());

        try
        {
            var post2 = blogger.ConvertDraftToPost(draft2); //exception here
            Console.WriteLine(post2.ToString());
        }
        catch (Exception ex)
        {

            Console.WriteLine("ex handled : " + ex.Message);
        }
        seoSpecialist.DoSEO(draft1, "C# is the best programming language in the world", "C# is the best best best");
        Console.WriteLine(draft1);
        var post1 = blogger.ConvertDraftToPost(draft1);
        Console.WriteLine(post1);
        var aNormalUser = new User(4, "mohammad");
        Console.WriteLine(aNormalUser);
        post1.Comment(aNormalUser.id, "great piece of information man !");
        Console.WriteLine(post1);
        post1.Rate(aNormalUser.id, 5);
        Console.WriteLine(post1);

        post1.Rate(aNormalUser.id, 4);
        Console.WriteLine(post1);

        post1.Rate(aNormalUser.id, 3);
        Console.WriteLine(post1);

        var anotherNormalUser = new User(6, "nacho");
        Console.WriteLine(anotherNormalUser);
        post1.Rate(anotherNormalUser.id, 1);
        Console.WriteLine(post1);
        try{
        post1.Rate(anotherNormalUser.id, 10);
        }
        catch(Exception ex){
            Console.WriteLine("exeption when rating post1 catched" + ex.Message);
        }
    }
}
