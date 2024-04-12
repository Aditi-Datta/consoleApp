// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");




// Console.Write("Please enter the first Item: ");
// int x = Convert.ToInt16(Console.ReadLine());

// Console.Write("Please enter the second Item: ");
// int y = Convert.ToInt16(Console.ReadLine());

// int z = x + y;
// Console.WriteLine("Sum = " +z);
// Console.ReadLine();




// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i.ToString());    
// }
// Console.ReadLine();



// int i = 1;
// while (i<=5)
// {   
//     Console.WriteLine(i);
//     i++;
// }
// Console.ReadLine();



// string[] arrStr = {"ASP", "DOTNET", "CORE", "MVC" };
// for (int i = 0; i < arrStr.Length; i++)
// {
//     Console.WriteLine(arrStr[i].ToString());
// } 
// Console.ReadLine();


// string[] arrStr = {"One", "Two", "Three", "Four"};
// int i =1;
// foreach (string item in arrStr)
// {
//     Console.WriteLine("Item No: " +i.ToString()+ ": "+item);    
//     i++ ;
// }
// Console.ReadLine();



// Console.WriteLine(DateTime.Today.Date.ToString("dd/MM/yyyy"));
Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
DateTime toDay = DateTime.ParseExact("23/08/1999", "dd/MM/yyyy", null);
// Console.WriteLine(toDay);
Console.ReadLine();