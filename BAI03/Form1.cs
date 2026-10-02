using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TechMartProductManager;

public partial class Form1 : Form
{
    private BindingList<Product> _allProducts = new BindingList<Product>();
    private BindingSource _bindingSource = new BindingSource();
    private string _currentImagePath = string.Empty;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // 1. Nạp danh mục vào ComboBox (DisplayMember, ValueMember)
        var categories = new BindingList<Category>
        {
            new Category("CAT01", "Điện thoại"),
            new Category("CAT02", "Laptop"),
            new Category("CAT03", "Phụ kiện")
        };

        cboCategory.DataSource = categories;
        cboCategory.DisplayMember = "CategoryName";
        cboCategory.ValueMember = "CategoryId";

        // 2. Nạp dữ liệu mẫu ban đầu
        _allProducts.Add(new Product("SP01", "iPhone 15 Pro Max 256GB", "CAT01", "Điện thoại", 29990000m, 15));
        _allProducts.Add(new Product("SP02", "Laptop Dell XPS 15", "CAT02", "Laptop", 35000000m, 8));
        _allProducts.Add(new Product("SP03", "Chuột Logitech MX Master 3S", "CAT03", "Phụ kiện", 2490000m, 30));
        _allProducts.Add(new Product("SP04", "Samsung Galaxy S24 Ultra", "CAT01", "Điện thoại", 27500000m, 12));

        // 3. Gán BindingSource vào DataGridView
        _bindingSource.DataSource = _allProducts;
        dgvProducts.DataSource = _bindingSource;

        UpdateStatusTotal();
    }

    // Cập nhật dòng trạng thái StatusStrip
    private void UpdateStatusTotal()
    {
        statusTotalProducts.Text = $"Tổng số sản phẩm: {_allProducts.Count}";
    }

    // Chọn ảnh đại diện sản phẩm bằng OpenFileDialog
    private void btnChooseImage_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog ofd = new OpenFileDialog())
        {
            ofd.Title = "Chọn ảnh sản phẩm";
            ofd.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _currentImagePath = ofd.FileName;
                try
                {
                    picAvatar.Image = Image.FromFile(_currentImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể tải ảnh: {ex.Message}", "Lỗi ảnh");
                }
            }
        }
    }

    // Kiểm tra dữ liệu đầu vào (Validation)
    private bool ValidateInput()
    {
        errorProvider.Clear();
        bool isValid = true;

        if (string.IsNullOrWhiteSpace(txtProductId.Text))
        {
            errorProvider.SetError(txtProductId, "Mã sản phẩm không được để trống!");
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(txtProductName.Text))
        {
            errorProvider.SetError(txtProductName, "Tên sản phẩm không được để trống!");
            isValid = false;
        }

        if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal price) || price <= 0)
        {
            errorProvider.SetError(txtUnitPrice, "Đơn giá phải là số lớn hơn 0!");
            isValid = false;
        }

        if (!int.TryParse(txtQuantity.Text.Trim(), out int qty) || qty < 0)
        {
            errorProvider.SetError(txtQuantity, "Số lượng phải là số nguyên lớn hơn hoặc bằng 0!");
            isValid = false;
        }

        return isValid;
    }

    // Thêm mới sản phẩm
    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            return;
        }

        string id = txtProductId.Text.Trim();
        if (_allProducts.Any(p => p.ProductId.Equals(id, StringComparison.OrdinalIgnoreCase)))
        {
            errorProvider.SetError(txtProductId, "Mã sản phẩm này đã tồn tại!");
            return;
        }

        Category? selectedCat = cboCategory.SelectedItem as Category;
        if (selectedCat == null)
        {
            MessageBox.Show("Vui lòng chọn danh mục hợp lệ!", "Thông báo");
            return;
        }

        decimal price = decimal.Parse(txtUnitPrice.Text.Trim());
        int qty = int.Parse(txtQuantity.Text.Trim());

        Product newProduct = new Product(
            id,
            txtProductName.Text.Trim(),
            selectedCat.CategoryId,
            selectedCat.CategoryName,
            price,
            qty,
            _currentImagePath
        );

        _allProducts.Add(newProduct);
        ApplySearchFilter();
        UpdateStatusTotal();
        MessageBox.Show("Thêm sản phẩm mới thành công!", "Thông báo");
        btnReset_Click(sender, e);
    }

    // Cập nhật sản phẩm đang chọn
    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (dgvProducts.CurrentRow == null || dgvProducts.CurrentRow.DataBoundItem is not Product selectedProduct)
        {
            MessageBox.Show("Vui lòng chọn một sản phẩm trên bảng để cập nhật!", "Thông báo");
            return;
        }

        if (!ValidateInput())
        {
            return;
        }

        Category? selectedCat = cboCategory.SelectedItem as Category;
        if (selectedCat == null)
        {
            MessageBox.Show("Vui lòng chọn danh mục hợp lệ!", "Thông báo");
            return;
        }

        selectedProduct.ProductName = txtProductName.Text.Trim();
        selectedProduct.CategoryId = selectedCat.CategoryId;
        selectedProduct.CategoryName = selectedCat.CategoryName;
        selectedProduct.UnitPrice = decimal.Parse(txtUnitPrice.Text.Trim());
        selectedProduct.Quantity = int.Parse(txtQuantity.Text.Trim());
        selectedProduct.ImagePath = _currentImagePath;

        _bindingSource.ResetBindings(false);
        MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo");
    }

    // Xóa sản phẩm
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvProducts.CurrentRow == null || dgvProducts.CurrentRow.DataBoundItem is not Product selectedProduct)
        {
            MessageBox.Show("Vui lòng chọn một sản phẩm trên bảng để xóa!", "Thông báo");
            return;
        }

        DialogResult result = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa sản phẩm [{selectedProduct.ProductId} - {selectedProduct.ProductName}]?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes)
        {
            _allProducts.Remove(selectedProduct);
            ApplySearchFilter();
            UpdateStatusTotal();
            btnReset_Click(sender, e);
            MessageBox.Show("Đã xóa sản phẩm thành công!", "Thông báo");
        }
    }

    // Nạp ngược dữ liệu khi click 1 dòng trên DataGridView
    private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && dgvProducts.CurrentRow?.DataBoundItem is Product p)
        {
            txtProductId.Text = p.ProductId;
            txtProductName.Text = p.ProductName;
            cboCategory.SelectedValue = p.CategoryId;
            txtUnitPrice.Text = p.UnitPrice.ToString("0");
            txtQuantity.Text = p.Quantity.ToString();

            _currentImagePath = p.ImagePath;
            if (!string.IsNullOrEmpty(p.ImagePath) && File.Exists(p.ImagePath))
            {
                try
                {
                    picAvatar.Image = Image.FromFile(p.ImagePath);
                }
                catch
                {
                    picAvatar.Image = null;
                }
            }
            else
            {
                picAvatar.Image = null;
            }
        }
    }

    // Tìm kiếm theo tên thời gian thực (Live Search)
    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        ApplySearchFilter();
    }

    private void ApplySearchFilter()
    {
        string keyword = txtSearch.Text.Trim();
        if (string.IsNullOrWhiteSpace(keyword))
        {
            _bindingSource.DataSource = _allProducts;
        }
        else
        {
            var filtered = _allProducts
                .Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
            _bindingSource.DataSource = new BindingList<Product>(filtered);
        }
    }

    // Làm mới Form nhập liệu
    private void btnReset_Click(object sender, EventArgs e)
    {
        txtProductId.Clear();
        txtProductName.Clear();
        txtUnitPrice.Clear();
        txtQuantity.Clear();
        if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
        picAvatar.Image = null;
        _currentImagePath = string.Empty;
        errorProvider.Clear();
        txtProductId.Focus();
    }

    // Xuất dữ liệu ra file CSV
    private void btnExportCsv_Click(object sender, EventArgs e)
    {
        ExportToCsv();
    }

    private void exportCsvMenuItem_Click(object sender, EventArgs e)
    {
        ExportToCsv();
    }

    private void ExportToCsv()
    {
        if (_allProducts.Count == 0)
        {
            MessageBox.Show("Danh sách sản phẩm đang trống, không có dữ liệu để xuất!", "Thông báo");
            return;
        }

        using (SaveFileDialog sfd = new SaveFileDialog())
        {
            sfd.Title = "Xuất danh sách sản phẩm ra file CSV";
            sfd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            sfd.FileName = $"TechMart_Products_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    // Header
                    sb.AppendLine("Mã SP,Tên SP,Danh Mục,Đơn Giá (VNĐ),Số Lượng");

                    // Rows
                    foreach (var p in _allProducts)
                    {
                        sb.AppendLine($"\"{p.ProductId}\",\"{p.ProductName}\",\"{p.CategoryName}\",{p.UnitPrice},{p.Quantity}");
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show($"Xuất dữ liệu ra file CSV thành công:\n{sfd.FileName}", "Thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Lỗi");
                }
            }
        }
    }

    // Thoát ứng dụng
    private void exitMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
