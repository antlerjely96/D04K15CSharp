// See https://aka.ms/new-console-template for more information

/*
 * Khai báo interface, abstract class, class, attribute, method: giống Java
 * Tính đóng gói (Access Modifier): giống Java
 * Tính kế thừa: giống C++ (class con : class cha hoặc class : interface)
 * Tính đa hình: giống java
 * Tính trừu tượng: giống Java
 * Tạo 1 đối tượng của class: giống Java
 * Cách gọi thuộc tính, phương thức: giống Java
 */

using ConsoleApp1;

public class main
{
    public static void Main()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.chieuDai = 5;
        rectangle.chieuRong = 4;
        rectangle.tinhChuVi();
    }
}
