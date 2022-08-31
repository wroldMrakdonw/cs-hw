System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int curNum = 2;
while (curNum<=N){
    System.Console.Write($"{curNum} ");
    curNum +=2;
}