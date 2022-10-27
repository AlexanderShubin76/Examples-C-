// Вид 1
// void Method1()
// {
//     System.Console.WriteLine("Автор ...");
// }
// Method1();

// // Вид 2
// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Method2 (msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i ++;
//     }
// }
// // Method21(msg: "Текст", count: 4);
// Method21(count:4, msg: "новый текст");

// // Вид 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// System.Console.WriteLine(year);

// Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
       
//        result = result + text;
//        i++;
//     }
//     return result;
// }

// string Method4(int count, string text)
// {
    
//     string result = String.Empty;
    
//     for (int i = 0; i < count; i++)
//     {        
//        result = result + text;
//     }
//     return result;
// }
// string res = Method4(10,"z");
// System.Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10 ; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i * j}");
    }
    System.Console.WriteLine();
}