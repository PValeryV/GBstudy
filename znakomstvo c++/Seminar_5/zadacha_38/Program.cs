// See https://aka.ms/new-console-template for more information
int n = 5;//число элеметнов в массиве
int []  arr = new int[n];
int DifLastFirst=0;
Random rand = new Random();
for (int i =0; i<n;i++){
    
   arr[i] = rand.Next(200);
}

Console.Write("элементы массива [");
for (int i = 0;i<n;i++){
    Console.Write($"{arr[i]} ");
}
DifLastFirst=Math.Abs(arr[0]-arr[(arr.Length-1)]);
Console.WriteLine("]");
Console.WriteLine($"Разница между первым и последним элементом массива = {DifLastFirst}");