Console.Write("Введите 1-е число: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (max < b){
    max = b;
}
System.Console.WriteLine(max);