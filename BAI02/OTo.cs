using System;

namespace AutoSpeedLogistics
{
    // B. Class OTo kế thừa từ PhuongTien
    public class OTo : PhuongTien
    {
        private int _soChoNgoi;
        private double _dungTichDongCo;

        public int SoChoNgoi
        {
            get => _soChoNgoi;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Số chỗ ngồi phải lớn hơn 0!", nameof(value));
                }
                _soChoNgoi = value;
            }
        }

        public double DungTichDongCo
        {
            get => _dungTichDongCo;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Dung tích động cơ phải lớn hơn 0!", nameof(value));
                }
                _dungTichDongCo = value;
            }
        }

        public OTo(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int soChoNgoi, double dungTichDongCo)
            : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            SoChoNgoi = soChoNgoi;
            DungTichDongCo = dungTichDongCo;
        }

        // Override TinhGiaLanBanh()
        public override decimal TinhGiaLanBanh()
        {
            if (SoChoNgoi <= 9)
            {
                // Thuế trước bạ 12% + Thuế tiêu thụ đặc biệt 30%
                decimal thueTruocBa = GiaGoc * 0.12m;
                decimal thueTTDB = GiaGoc * 0.30m;
                return GiaGoc + thueTruocBa + thueTTDB;
            }
            else
            {
                // Thuế trước bạ 10%
                decimal thueTruocBa = GiaGoc * 0.10m;
                return GiaGoc + thueTruocBa;
            }
        }

        // Override GetInfo()
        public override string GetInfo()
        {
            return $"[Ô tô] {base.GetInfo()} - Số chỗ: {SoChoNgoi} chỗ - Dung tích: {DungTichDongCo}L";
        }
    }
}
