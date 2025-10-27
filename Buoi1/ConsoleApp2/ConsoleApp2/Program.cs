// See https://aka.ms/new-console-template for more information

/*
* 2. Nhap so nguyen a tu ban phim. Kiem tra a la so chan hay le 
*/
//Khai bao
int a;
//Nhap
Console.Write("a = ");
a = int.Parse(Console.ReadLine());
//kiem tra
if (a % 2 == 0)
{
    Console.WriteLine(a + " la so chan");
}
else
{
    Console.WriteLine(a + " la so le");
}