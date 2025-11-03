// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
/*
    Loop: dùng để thực hiện 1 khối lệnh nhiều lần
    for(tham số 1; tham số 2; tham số 3){
        khối lệnh;
    }
    
    tham số 1;
    while(tham số 2){
        Khối lệnh;
        tham số 3;
    }
    
    tham số 1;
    do {
        khối lệnh;
        tham số 3;
    } while (tham số 2);
    
    do {
        tham số 1;
        khối lệnh;
    } while (tham số 2);
*/

/*
    1. Nhap so nguyen n. Hien thi cac so tu 1 den n
*/

int n;
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(n);
}

/*
    2. Nhap so nguyen n tu ban phim.
	Tinh n!
	3. Nhap so nguyen n tu ban phim.
	Tinh tong cac so chia het cho 3 hoac 7 trong khoang tu 1 den n
	4. Nhap so nguyen n tu ban phim
	Kiem tra n co phai so nguyen to hay khong
	5. Nhap so nguyen n tu ban phim
	Hien thi cac so nguyen to trong khoang tu 1 den n
	6. Ve hinh
	    1
	   121
	  12321
	 1234321
	123454321
*/