Console.Clear();
System.Console.WriteLine("Введите первый элемент");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второй элемент");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третий элемент");
int c = Convert.ToInt32(Console.ReadLine());
int max=a;
if(b>max){
    max=b;
}
if(c>max){
    max=c;
}

System.Console.WriteLine($"Максимально число {max}");