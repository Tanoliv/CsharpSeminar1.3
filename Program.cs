// Создание числового ряда  чётных чисел от 1 до N ДЗ - 4

Console.WriteLine("Создание числового ряда чётных чисел от 1 до числа N");

Console.WriteLine("Введите число:"); 
int n = int.Parse(Console.ReadLine()!);

for (int i = 1;  i < n; i++){
    
    if(i % 2 == 0){
      
 Console.Write($"{i}, ");
     }  
      
}


