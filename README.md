# I четверть. Итоговый проект #

### Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с лавиатуры, либо задать на старте выполнения алгоритма  
### Примеры:
### ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
### ["1234", "1567", "-2"] -> ["-2"]
### ["Russia", "Denmark", "Kazan"] -> [ ]
___
### 1. Метод `PrintArrayString`, позволяет выводить на экран элементы строкового массива (любой размерности), как указано в примере к задаче
```
void PrintArrayString (string [] arrStr)
{
    if (arrStr.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < arrStr.Length - 1; i++)
        {
            Console.Write($"\"{arrStr[i]}\", ");
        }
        Console.Write($"\"{arrStr[arrStr.Length - 1]}\"");
        Console.Write("]");
    }
    else
    {
        arrStr = new string[] { "" };
        Console.Write($"[{arrStr[arrStr.Length - 1]}]");
    }
}
```
### 2. Предоставляем пользователю возможность ввести размерность массива, состоящего из слов/строк:
```
int size = Convert.ToInt32(Console.ReadLine());
```
### 3. Через цикл `for`, пользователь заполняет массив словами\строками:
```
for (int i = 0; i < size; i++)
{
    arrayString [i] = Console.ReadLine();
}
```
___
## РЕАЛИЗАЦИЯ ПЕРВОГО СПОСОБА РЕШЕНИЯ ЗАДАЧИ

### Используя функционал языка C#, а именно класс `Array` и метод `Array.FindAll<T>(T[], Predicate<T>)`, возвращаем все элементы в виде массива, которые удовлеворяет условию задачи из делегата `match`:
```
string[] sortArrStr = Array.FindAll(arrayString, str => str.Length <= 3);
```
### Выводим на экран полученный массив методом `PrintArrayString`:
```
PrintArrayString (sortArrStr);
```
## РЕАЛИЗАЦИЯ  ВТОРОГО СПОСОБА РЕШЕНИЯ ЗАДАЧИ
### 1. Методом `SizeSortedArrayString` определяем размер нового массива строк, элементы которого удовлетворяют условию задачи

```
int SizeSortedArrayString (string [] arrayString)
{
    int count = default;
    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= 3)
        {
           count++;
        }
    }
    return count;
}
``` 
### 2. Методом `SortedArrayString` заполняем новый массив строк элементами из исходного массива, для которых выполняется условие задачи
```
string [] SortedArrayString (string [] arrayString, int count)
{
    string [] sortedArray = new string [count];
    int j = 0;
    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= 3)
        {
           sortedArray [j] = arrayString [i];
           j++;
        }
    }
    return sortedArray;
}
``` 
### Выводим на экран полученный массив методом `PrintArrayString`:
```
    PrintArrayString (sortArr);
```