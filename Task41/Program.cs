// Задача 41 Дз 
 
// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь. 
// 0, 7, 8, -2, -2 -> 2 

// Я понимаю задачу так:
// Пользователь сначала вводит число М, обозначающее: сколько чисел будет вводиться.
// Затем вводит числа по одному, по комманде.
// Затем, на экран выводится результат: сколько чисел больше 0 ввел пользователь.
 
Console.Write("Введите число М (сколько чисел будет вводиться): "); 
int m = Convert.ToInt32(Console.ReadLine()); 
int[] massiveNumbers = new int[m]; 
 
void InputNumber(int m) 
{ 
    for(int i = 0; i < m; i++) 
    { 
        Console.Write($"Введите {i+1} число: "); 
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine()); 
    } 
} 
 
int Comparison(int[] massiveNumbers) 
{ 
    int count = 0; 
    for(int i = 0; i < massiveNumbers.Length; i++) 
    { 
        if(massiveNumbers[i] > 0) 
        count +=1; 
    } 
    return count; 
} 
 
InputNumber(m); 
 
Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");