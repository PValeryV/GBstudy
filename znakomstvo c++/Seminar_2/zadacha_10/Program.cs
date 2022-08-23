// See https://aka.ms/new-console-template for more information
void primer(int i,int n,int* arr){
    arr[i]=a/n;
    a=a%n;
    ++i;
    n/=10;
    if (i<2) primer(i,n,arr);
}


Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int i=0;
int n= 100;
int[] arr = new int[2];

primer(i,n,arr);

Console.WriteLine(arr[1]);