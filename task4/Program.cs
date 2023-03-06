Console.Clear();
System.Console.WriteLine("Введите число");
int a=Convert.ToInt32(Console.ReadLine());
int b = 0;
for(int i=1;i<a;i++){
    b = i % 2;
    if (b == 0){
    System.Console.Write(" "+i);
}
}