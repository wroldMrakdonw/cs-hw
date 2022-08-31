System.Console.Write("Введите 1-е число: ");
int max = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > max){
    max = b;
}
System.Console.Write("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (c > max){
    max = c;
}
System.Console.WriteLine(max);