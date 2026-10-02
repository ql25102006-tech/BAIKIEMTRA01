using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoSpeedLogistics
{
    // D. Class QuanLyPhuongTien (Quản lý Tập hợp)
    public class QuanLyPhuongTien
    {
        private readonly List<PhuongTien> _danhSach = new List<PhuongTien>();

        // 1. Thêm phương tiện mới
        public void AddPhuongTien(PhuongTien pt)
        {
            if (pt == null)
            {
                throw new ArgumentNullException(nameof(pt), "Phương tiện không được null!");
            }
            _danhSach.Add(pt);
        }

        // 2. In ra danh sách toàn bộ phương tiện kèm Giá lăn bánh
        public void DisplayAll()
        {
            if (_danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách phương tiện đang trống.");
                return;
            }

            Console.WriteLine($"--- DANH SÁCH TOÀN BỘ PHƯƠNG TIỆN ({_danhSach.Count} phương tiện) ---");
            for (int i = 0; i < _danhSach.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_danhSach[i].GetInfo()}");
            }
        }

        // 3. Tìm và trả về phương tiện có Giá lăn bánh cao nhất (Tính Đa hình)
        public PhuongTien? FindMaxGiaLanBanh()
        {
            if (_danhSach.Count == 0)
            {
                return null;
            }

            PhuongTien maxPt = _danhSach[0];
            decimal maxPrice = maxPt.TinhGiaLanBanh();

            foreach (var pt in _danhSach)
            {
                decimal currentPrice = pt.TinhGiaLanBanh();
                if (currentPrice > maxPrice)
                {
                    maxPrice = currentPrice;
                    maxPt = pt;
                }
            }

            return maxPt;
        }

        // 4. Tìm danh sách phương tiện theo tên hãng (sử dụng LINQ)
        public List<PhuongTien> SearchByName(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return new List<PhuongTien>(_danhSach);
            }

            return _danhSach
                .Where(pt => pt.TenHang.Contains(keyword.Trim(), StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
