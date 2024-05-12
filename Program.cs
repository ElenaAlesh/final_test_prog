// контрольная
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите размерность массива: "); //  размер массива
int n = Convert.ToInt32(Console.ReadLine());
string[] mas = new string[n];
// заполняем массив 
int ind = 0;
while (ind < mas.Length)
{
Console.Write($"Введите {ind}-й элемент массива: ");
mas[ind] = Console.ReadLine();
ind++;
}

Print_mas(mas); // печатаем исходный массив

// считаем сколько в массиве элементов, длина которых <= 3 для определения размера нового массива
int count = 0;
foreach (string el in mas)
{
    if (el.Length <=3)
    {
    count = count +1;
    }
}

//создаем новый массив с размером count
string[] mas_2 = new string[count];
// заполняем новый массив
int i = 0;
foreach (string el in mas)
{
    if (el.Length <=3)
    {
    mas_2[i]= el;
    i = i+1;
    }
}
Console.WriteLine($"искомых элементов - {count}");
// Печатаем новый массив
Print_mas(mas_2);






// функция вывода массива на консоль
void Print_mas(string[] mas) 
{
foreach(string el in mas)  
{
Console.Write($"{el} ");
}
Console.WriteLine();
}

