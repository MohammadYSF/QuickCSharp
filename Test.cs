// namespace CSharpBasics;

// class Test
// {
//     static void Testf(string[] args)
//     {
//         //this line is a comment
//         //variable declaration
//         int x = 10;
//         x++;
//         x--;
//         x += 2;
//         x -= 10;
//         x *= -1;
//         x = -50;
//         x = Math.Abs(x);
//         uint y = -10; //compile time error
//         long z = -10;
//         ulong = -10 //compile time error
//         short t = 100000000; //compile time error

//         float f = 1.2f;
//         double d = 9.002;


//         string name = "albert";
//         bool flag = true;
//         char letterA = 'A';
//         int LetterB = 'B';


//         DateTime registerDate = DateTime.Now;
//         DateTime registerDateTimeInUtc = DateTime.UtcNow;

//         DateTime startDate = new DateTime(2024, 2, 2, 19, 30, 0);


//         //Interacting with Console
//         //writing to console
//         Console.WriteLine("Hello, World!");
//         Console.WriteLine(name);
//         Console.WriteLine(flag);
//         //reading from console
//         string userInput = Console.ReadLine();


//         //type conversion:
//         string averageInString = "19";
//         int average = int.Parse(averageInString);

//         string averageInBadString = "avg is 19";
//         int avgerage2 = int.Parse(averageInBadString); //runtime error

//         int score = 13;
//         string scoreInString = score.ToString();


//         //string concatenation
//         string firstName = "Mohammad";
//         string lastName = "Yousefiyan";
//         string fullName = firstName + " " + lastName;
//         string alsoFullName = string.Format("{0} {1}", firstName, lastName);

//         //using var when declaring variable
//         int someVariable = 10;
//         var alsoSomeVariable =
//             10; //C# is intelligent enough to know that 10 is 10 . so you do not have to tell him explicitly

//         //array , IEnumerable ,List
//         var numbers = new int[10]; // an array of fixed size 10;
//         int[] numbers2 = []; //an empty array of dynamic size
//         string[] names = ["goli", "hasan"];
//         //adding an element to the end of the array
//         names = names.Append("karim").ToArray(); //Append Function is defined on  the array object and returns  IEnumberable
//         //so , in order to get  the array back , we should use .ToArray() method  
        
        
        
//         //List
//         List<int> listNames = [1, 2, 3];
//         listNames.Add(4);//adds 4 ==> listNames is : [1,2,3,4]
//         listNames.AddRange([5,6]);//adds 5,6 ==> listNames is : [1,2,3,4,5,6]
//         listNames.Remove(5);//removes 5 ==> listNames is : [1,2,3,4,6]
//         listNames.RemoveAt(0);//removes the item with index 0  ==> listNames is : [2,3,4,6]
//         listNames.RemoveRange(1,3);//removes the item with index 1 , 2 ,3 ==> listNames is : [2]
//         Console.WriteLine(listNames.Count);
        
//         //conditions
//         if (true)
//         {
//             //do something
//         }
//         else
//         {
//             //do something else
//         }

//         if (name == "sevda" && x<0)
//         {
//             //some code
//         }
//         else if (name == "karim" || name == "goli")
//         {
//             //some code
//         }
//         else if (name== "hakan")
//         {
//             //some code
//         }
//         else
//         {
//             //some code
//         }
        
//         //loops:
//         for (int i = 0; i < 10; i++)
//         {
//             Console.WriteLine("i is : {0}",i);
//         }
//         //printing even numbers from 1 to 100 on the console:
//         for (int i = 2; i <= 100; i += 2)
//         {
//             Console.WriteLine(i);
//         }
//         //priting 3 digit numbers like x where x power 2 is a devisible to 4
//         for (int i = 100; i < 1000 && i % 4 == 0; i++)
//         {
//             Console.WriteLine(i);
//         }

//         foreach (var n in names)
//         {
//             Console.WriteLine(n);
//         }

//         bool stopWhile = false;
        
//         while (!stopWhile)
//         {
//             x *= 2;
//             if (x < Math.Pow(2, 10))
//             {
//                 stopWhile = true;
//             }
//             Console.WriteLine(x);
//         }
//         //another example
//         List<int> grades = [];
//         while (true)
//         {
//             string inp = Console.ReadLine();
//             foreach (var item in inp.Split(' '))
//             {
//                 grades.Add(int.Parse(item));
//             }
//         }
//     }
// }