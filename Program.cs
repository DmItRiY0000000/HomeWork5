//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int [] CreateRandomArray(int n, int minVal, int maxVal)
{
 int [] arr = new int[n];
 for (int i = 0; i < n; i++) 
 {
    arr[i] = new Random().Next(minVal, maxVal+1);
 }
 return arr;
}

void PrintArray(int [] arr)
    
{   
    Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
        Console.WriteLine($"\b\b]");  
}

int CountEven(int [] arr)
{   
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
          counter += arr[i] % 2; 
    return arr.Length - counter;
}

void TestTask1(int Sizearray, int minVal, int maxVal)
{
    int [] newArray = CreateRandomArray(Sizearray, minVal, maxVal);
    Console.Write("В массиве: ");
    PrintArray(newArray);
    Console.WriteLine($"четных элементов: {CountEven(newArray)}");
}


int  SizeArray = new Random().Next(5,10+1);
int  elementsMin=100;
int elementsMax=999;


TestTask1(SizeArray,elementsMin,elementsMax);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreateRandomArray(int n, int minVal, int maxVal)
{
 int [] arr = new int[n];
 for (int i = 0; i < n; i++) 
 {
    arr[i] = new Random().Next(minVal, maxVal+1);
 }
 return arr;
}

void PrintArray(int [] arr)
    
{   
    Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
        Console.WriteLine($"\b\b]");  
}

int SumOddPos(int [] arr)
{
    int sumOdd = 0;
    for (int i= 1; i < arr.Length; i += 2)
        sumOdd += arr[i];
    return sumOdd;
}

void TestTask2(int  SizeArray, int minVal, int maxVal)
{
    int [] newArray = CreateRandomArray(SizeArray, minVal, maxVal);
    Console.Write("Сумма элементов массива: ");
    PrintArray(newArray);
    Console.WriteLine($"на нечетных позициях: {SumOddPos(newArray)}");
}


int  SizeArray = new Random().Next(10+1);
int  elementsMin=new Random().Next(-100,0);
int elementsMax=new Random().Next(100);


TestTask2(SizeArray,elementsMin,elementsMax);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double [] CreateRandomDoubleArray(int n, int minVal, int maxVal)
{
 double [] arr = new double[n];
 Random rng = new Random();
 for (int i = 0; i < n; i++) 
 {
    arr[i] = rng.Next(minVal, maxVal+1)+ rng.NextDouble();
 }
 return arr;
}


void PrintDoubleArray(double [] arr)
    
{   Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
    {    
      Console.Write($"{arr[i]:f2}; ");
    }  Console.ResetColor();
       Console.WriteLine($"\b\b]");  
}

double MinMaxDifference(double [] arr)
{
    int minPos = 0;
    int maxPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[minPos] > arr[i]) 
            minPos = i;
        else if (arr[maxPos] < arr[i])
            maxPos = i;    
    }
    return arr[maxPos] - arr[minPos];
}

void TestTask3(int SizeArray, int minVal, int maxVal)
{   
    double [] newArr = CreateRandomDoubleArray(SizeArray, minVal, maxVal);
    Console.Write("Разность максимального и минимального элементов массива: ");
    PrintDoubleArray(newArr);
    Console.WriteLine($"сотставляет: {MinMaxDifference(newArr):f2}");
}

int  SizeArray = new Random().Next(10+1);
int  elementsMin=new Random().Next(-100,0);
int elementsMax=new Random().Next(100);


TestTask3(SizeArray,elementsMin,elementsMax);
*/
