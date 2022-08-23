// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());

int n= 100;
int[] arr = new int[2];
for (int i=0;i<2;i++,n/=10){
    arr[i]=a/n;
    a=a%n;
}

Console.WriteLine(arr[1]);