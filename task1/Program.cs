Console.Clear();
System.Console.WriteLine("Введите первый элемент");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второй элемент");
int b = Convert.ToInt32(Console.ReadLine());
if(a<b){
    System.Console.WriteLine($"{b} Больше числа {a}");
}
else if (a>b) {
System.Console.WriteLine($"{a} Больше числа {b}");
}
else{
    System.Console.WriteLine($"Число {a} равно числу {b}");
}
