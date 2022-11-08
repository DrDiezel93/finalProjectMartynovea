# I четверть. Итоговый проект #

### Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с лавиатуры, либо задать на старте выполнения алгоритма  
### Примеры:
### ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
### ["1234", "1567", "-2"] -> ["-2"]
### ["Russia", "Denmark", "Kazan"] -> [ ]
___
### 1. Метод `PrintArrayString`, позволяет выводить на экран элементы строкового массива (любой размерности), как указано в задаче
```
void PrintArrayString (string [] arrStr)
{
    Console.Write ("[");
    for (int i = 0; i < arrStr.Length-1; i++)
    {
        Console.Write ($"\"{arrStr[i]}\", ");
    }
    Console.Write ($"\"{arrStr[arrStr.Length-1]}\"");
    Console.Write ("]");
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
### Если таких элементов больше 0, выводим на экран полученный массив методом `PrintArrayString`:
```
if (sortArrStr.Length > 0) PrintArrayString (sortArrStr);
```
## иначе на экране появится `[]`
```
else Console.Write ("[]");
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
### Если размер нового массива больше 0, выводим на экран полученный массив методом `PrintArrayString`:
```
if (count > 0) 
{
    string [] sortArr = SortedArrayString (arrayString, count);
    PrintArrayString (sortArr);
}
```
## иначе на экране появится `[]`
```
else Console.Write ("[]");
```