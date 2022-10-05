// Создание числового ряда от 1 до N.

Console.WriteLine("Создание числового ряда от 1 до числа N");

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine()!);

for (int i = 1;  i < n; i++){
    
    if(i % 2 == 0){
      
 Console.Write($"{i}, ");
     }  
      
}


