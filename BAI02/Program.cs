using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSpeedLogistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==========================================================");
            Console.WriteLine("  QUAN LY PHUONG TIEN GIAO THONG - AUTOSPEED LOGISTICS    ");
            Console.WriteLine("==========================================================\n");

            QuanLyPhuongTien ql = new QuanLyPhuongTien();

            // Test Case 01: Kiem tra validation nam san xuat
            Console.WriteLine("[TC01] Kiem tra Validation Nam san xuat (nam = 1850):");
            try
            {
                OTo otoLoi = new OTo("OT_ERR", "Toyota", 1850, 800000000m, 5, 2.0);
                Console.WriteLine("That bai: Khong bat duoc loi!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ket qua bat duoc ngoai le thanh cong: " + ex.Message);
            }
            Console.WriteLine();

            // Test Case 02: Kiem tra tinh gia lan banh o to 5 cho (Gia goc 1 ty)
            Console.WriteLine("[TC02] Kiem tra tinh gia lan banh o to 5 cho (Gia goc: 1.000.000.000 VND):");
            OTo oto5Cho = new OTo("OT001", "Mercedes-Benz C200", 2023, 1000000000m, 5, 2.0);
            decimal giaLanBanhOto = oto5Cho.TinhGiaLanBanh();
            Console.WriteLine("Phuong tien: " + oto5Cho.TenHang + " (" + oto5Cho.SoChoNgoi + " cho)");
            Console.WriteLine("Gia goc    : " + oto5Cho.GiaGoc.ToString("N0") + " VND");
            Console.WriteLine("Gia lan banh: " + giaLanBanhOto.ToString("N0") + " VND (Ky vong: 1,420,000,000 VND)");
            ql.AddPhuongTien(oto5Cho);
            Console.WriteLine();

            // Test Case 03: Kiem tra tinh gia lan banh xe may 150cc (Gia goc 50 trieu)
            Console.WriteLine("[TC03] Kiem tra tinh gia lan banh xe may 150cc (Gia goc: 50.000.000 VND):");
            XeMay xemay150 = new XeMay("XM001", "Honda AirBlade 150", 2024, 50000000m, 150);
            decimal giaLanBanhXeMay = xemay150.TinhGiaLanBanh();
            Console.WriteLine("Phuong tien: " + xemay150.TenHang + " (" + xemay150.DungTichXylanh + "cc)");
            Console.WriteLine("Gia goc    : " + xemay150.GiaGoc.ToString("N0") + " VND");
            Console.WriteLine("Gia lan banh: " + giaLanBanhXeMay.ToString("N0") + " VND (Ky vong: 51,000,000 VND)");
            ql.AddPhuongTien(xemay150);
            Console.WriteLine();

            // Them 1 oto 16 cho va 1 xe phan khoi lon de du lieu day du
            OTo oto16Cho = new OTo("OT002", "Ford Transit", 2022, 900000000m, 16, 2.2);
            XeMay xePKL = new XeMay("XM002", "Kawasaki Ninja 400", 2023, 160000000m, 399);
            ql.AddPhuongTien(oto16Cho);
            ql.AddPhuongTien(xePKL);

            // Test Case 04: Kiem tra da hinh List<PhuongTien>
            Console.WriteLine("[TC04] Kiem tra da hinh danh sach phuong tien:");
            ql.DisplayAll();
            Console.WriteLine();

            // Test Case 05: Kiem tra tim phuong tien co gia lan banh cao nhat
            Console.WriteLine("[TC05] Kiem tra tim phuong tien co gia lan banh cao nhat:");
            PhuongTien? maxPT = ql.FindMaxGiaLanBanh();
            if (maxPT != null)
            {
                Console.WriteLine("Ket qua: " + maxPT.GetInfo());
                Console.WriteLine("Gia lan banh: " + maxPT.TinhGiaLanBanh().ToString("N0") + " VND (Ky vong: 1.42 ty VND)");
            }
            Console.WriteLine();

            // Kiem tra tim kiem theo ten hang
            Console.WriteLine("Kiem tra tim kiem theo ten hang 'Honda':");
            var searchResults = ql.SearchByName("Honda");
            foreach (var item in searchResults)
            {
                Console.WriteLine("- " + item.GetInfo());
            }

            Console.WriteLine("\n==========================================================");
            Console.WriteLine("             HOAN THANH KIEM THU BAI 02                   ");
            Console.WriteLine("==========================================================");
        }
    }
}
