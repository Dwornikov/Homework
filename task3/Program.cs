Console.Clear();
System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 2;
if(b == 0){
    System.Console.WriteLine("Число четное");
}
else{
    System.Console.WriteLine("Число нечетное");
}