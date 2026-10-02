using System;

namespace AutoSpeedLogistics
{
    // A. Abstract Class PhuongTien (Lớp cha trừu tượng)
    public abstract class PhuongTien
    {
        // Private Fields
        private string _maPT = "PT000";
        private string _tenHang = string.Empty;
        private int _namSanXuat;
        private decimal _giaGoc;

        // Properties (Validation Encapsulation)
        public string MaPT
        {
            get => _maPT;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _maPT = "PT000";
                }
                else
                {
                    _maPT = value.Trim();
                }
            }
        }

        public string TenHang
        {
            get => _tenHang;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tên hãng không được để trống!", nameof(value));
                }
                _tenHang = value.Trim();
            }
        }

        public int NamSanXuat
        {
            get => _namSanXuat;
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value < 1900 || value > currentYear)
                {
                    throw new ArgumentException("Năm sản xuất không hợp lệ!", nameof(value));
                }
                _namSanXuat = value;
            }
        }

        public decimal GiaGoc
        {
            get => _giaGoc;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Giá gốc phải lớn hơn 0!", nameof(value));
                }
                _giaGoc = value;
            }
        }

        // Constructor đầy đủ tham số
        protected PhuongTien(string maPT, string tenHang, int namSanXuat, decimal giaGoc)
        {
            MaPT = maPT;
            TenHang = tenHang;
            NamSanXuat = namSanXuat;
            GiaGoc = giaGoc;
        }

        // Abstract Method
        public abstract decimal TinhGiaLanBanh();

        // Virtual Method
        public virtual string GetInfo()
        {
            return $"[Mã PT: {MaPT}] - Hãng: {TenHang} - Năm SX: {NamSanXuat} - Giá gốc: {GiaGoc:N0} VNĐ - Giá lăn bánh: {TinhGiaLanBanh():N0} VNĐ";
        }
    }
}
