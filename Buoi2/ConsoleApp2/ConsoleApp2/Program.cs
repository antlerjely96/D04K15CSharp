// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

/*
    Mảng (Array): là 1 tập hợp các phần tử có cùng kiểu dữ liệu, được phân biệt bằng chỉ số index
    Index bắt đầu từ 0
    Khai báo:
        Kiểu_dữ_liệu[] tên_mảng = new kiểu_dữ_liệu[Số_phần_tử];
    Truy xuất phần tử
        tên_mảng[index];
    Để lần lượt truy xuất các phần tử trong mảng: dùng loop chạy theo index
*/

/*
    1. Nhập mảng số nguyên có n phần tử. Tính tổng các phần tử
*/
int n;
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
Console.WriteLine("Nhap mang");
for (int i = 0; i < n; i++)
{
    Console.Write("arr[" + i + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}

int tong = 0;
for (int i = 0; i < n; i++)
{
    tong += arr[i];
}
Console.WriteLine("Tong cac phan tu cua mang: " + tong);

/*
    2. Nhap mang so thuc co n phan tu. Tim max, min
    3. Nhap mang so thuc co m phan tu. Sap xep mang theo thu tu tang dan
*/