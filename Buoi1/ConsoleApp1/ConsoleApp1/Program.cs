// See https://aka.ms/new-console-template for more information
/* Biến:
Kiểu_dữ_liệu tên_biến;
Kiểu_dữ_liệu tên_biến = giá_trị;
*/
//Hằng số: const Kiểu_dữ_liệu tên_biến = giá_trị;
/* Toán tử: Ký hiệu thể hiện các phép toán
Toán tử số học: +, -, *, /, %
Toán tử quan hệ: >, <, >=, <=, ==, !=
Toán tử logic: &&, ||, !
Toán tử gán: =, +=, -=, *=, /=, %=
*/
/*
 * Condition (cấu trúc điều khiển rẽ nhánh)
 * if(điều kiện){
 *      Khối lệnh;
 * }
 *
 * if(điều kiện){
 *      Khối lệnh 1;
 * } else {
 *      Khối lệnh 2;
 * }
 *
 * if(điểu kiện 1){
 *      Khối lệnh 1;
 * } else if(điều kiện 2){
 *      Khối lệnh 2;
 * } else {
 *      Khối lệnh 3;
 * }
 *
 * if(điều kiện 1){
 *      if(điều kiện 2){
 *          Khối lệnh;
 *      }
 * }
 *
 * Cấu trúc lựa chọn switch - case
 * switch(tên biến){
 *      case giá_trị:
 *          Khối lệnh;
 *          break;
 *      default:
 *          Khối lệnh;
 *          break;
 * }
 *
 * Nhập - xuất
 * Xuất:
 *    Console.Write(); in nhưng không xuống dòng
 *    Console.WriteLine(); in xong xuống dòng
 * Nhập:
 *    Console.Read(): cho nhập 1 ký tự
 *    Console.ReadLine(): cho nhập 1 chuỗi, biến phải có kiểu dữ liệu là string
 */


/* int a;
      int b;
      double c;
      Console.Write("Hello world!");
      Console.WriteLine("Hello World lần 2");
      //Console.Write("a = ");
      //a = Console.Read();
      //Console.Write("b = ");
      //b = int.Parse(Console.ReadLine());
      Console.Write("c = ");
      c = double.Parse(Console.ReadLine());
      //Console.WriteLine(a);
      //Console.WriteLine(b);
      Console.WriteLine(c);
*/

/*
*   1. Nhap so nguyen a tu ban phim. Kiem tra a la so am hay so duong
*/
//Khai báo a
int a;
//Nhập a
Console.Write("a = ");
a = int.Parse(Console.ReadLine());
//Kiểm tra
if (a > 0)
{
    Console.WriteLine("a la so duong");
}
else if (a < 0)
{
    Console.WriteLine("a la so am");
}
else
{
    Console.WriteLine("a la so khong am khong duong");
}