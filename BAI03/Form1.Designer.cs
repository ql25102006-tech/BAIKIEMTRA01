namespace TechMartProductManager;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileMenu;
    private System.Windows.Forms.ToolStripMenuItem exportCsvMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem exitMenuItem;

    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel statusTotalProducts;

    private System.Windows.Forms.TableLayoutPanel mainTableLayout;

    // Cột trái (35%)
    private System.Windows.Forms.GroupBox grpInput;
    private System.Windows.Forms.Label lblProductId;
    private System.Windows.Forms.TextBox txtProductId;
    private System.Windows.Forms.Label lblProductName;
    private System.Windows.Forms.TextBox txtProductName;
    private System.Windows.Forms.Label lblCategory;
    private System.Windows.Forms.ComboBox cboCategory;
    private System.Windows.Forms.Label lblUnitPrice;
    private System.Windows.Forms.TextBox txtUnitPrice;
    private System.Windows.Forms.Label lblQuantity;
    private System.Windows.Forms.TextBox txtQuantity;
    private System.Windows.Forms.Label lblAvatar;
    private System.Windows.Forms.PictureBox picAvatar;
    private System.Windows.Forms.Button btnChooseImage;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnReset;

    // Cột phải (65%)
    private System.Windows.Forms.Panel rightPanel;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.DataGridView dgvProducts;
    private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
    private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
    private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
    private System.Windows.Forms.Button btnExportCsv;

    private System.Windows.Forms.ErrorProvider errorProvider;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();

        menuStrip1 = new System.Windows.Forms.MenuStrip();
        fileMenu = new System.Windows.Forms.ToolStripMenuItem();
        exportCsvMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();

        statusStrip1 = new System.Windows.Forms.StatusStrip();
        statusTotalProducts = new System.Windows.Forms.ToolStripStatusLabel();

        mainTableLayout = new System.Windows.Forms.TableLayoutPanel();

        // Cột trái
        grpInput = new System.Windows.Forms.GroupBox();
        lblProductId = new System.Windows.Forms.Label();
        txtProductId = new System.Windows.Forms.TextBox();
        lblProductName = new System.Windows.Forms.Label();
        txtProductName = new System.Windows.Forms.TextBox();
        lblCategory = new System.Windows.Forms.Label();
        cboCategory = new System.Windows.Forms.ComboBox();
        lblUnitPrice = new System.Windows.Forms.Label();
        txtUnitPrice = new System.Windows.Forms.TextBox();
        lblQuantity = new System.Windows.Forms.Label();
        txtQuantity = new System.Windows.Forms.TextBox();
        lblAvatar = new System.Windows.Forms.Label();
        picAvatar = new System.Windows.Forms.PictureBox();
        btnChooseImage = new System.Windows.Forms.Button();
        btnAdd = new System.Windows.Forms.Button();
        btnUpdate = new System.Windows.Forms.Button();
        btnDelete = new System.Windows.Forms.Button();
        btnReset = new System.Windows.Forms.Button();

        // Cột phải
        rightPanel = new System.Windows.Forms.Panel();
        lblSearch = new System.Windows.Forms.Label();
        txtSearch = new System.Windows.Forms.TextBox();
        dgvProducts = new System.Windows.Forms.DataGridView();
        colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
        btnExportCsv = new System.Windows.Forms.Button();

        errorProvider = new System.Windows.Forms.ErrorProvider(components);

        menuStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        mainTableLayout.SuspendLayout();
        grpInput.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
        rightPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();

        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileMenu });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(1000, 28);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";

        // 
        // fileMenu
        // 
        fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exportCsvMenuItem, toolStripSeparator1, exitMenuItem });
        fileMenu.Name = "fileMenu";
        fileMenu.Size = new System.Drawing.Size(46, 24);
        fileMenu.Text = "&File";

        // 
        // exportCsvMenuItem
        // 
        exportCsvMenuItem.Name = "exportCsvMenuItem";
        exportCsvMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E;
        exportCsvMenuItem.Size = new System.Drawing.Size(207, 26);
        exportCsvMenuItem.Text = "&Export CSV";
        exportCsvMenuItem.Click += exportCsvMenuItem_Click;

        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new System.Drawing.Size(204, 6);

        // 
        // exitMenuItem
        // 
        exitMenuItem.Name = "exitMenuItem";
        exitMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
        exitMenuItem.Size = new System.Drawing.Size(207, 26);
        exitMenuItem.Text = "E&xit";
        exitMenuItem.Click += exitMenuItem_Click;

        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusTotalProducts });
        statusStrip1.Location = new System.Drawing.Point(0, 624);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new System.Drawing.Size(1000, 26);
        statusStrip1.TabIndex = 2;
        statusStrip1.Text = "statusStrip1";

        // 
        // statusTotalProducts
        // 
        statusTotalProducts.Name = "statusTotalProducts";
        statusTotalProducts.Size = new System.Drawing.Size(149, 20);
        statusTotalProducts.Text = "Tổng số sản phẩm: 0";

        // 
        // mainTableLayout
        // 
        mainTableLayout.ColumnCount = 2;
        mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
        mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
        mainTableLayout.Controls.Add(grpInput, 0, 0);
        mainTableLayout.Controls.Add(rightPanel, 1, 0);
        mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
        mainTableLayout.Location = new System.Drawing.Point(0, 28);
        mainTableLayout.Name = "mainTableLayout";
        mainTableLayout.RowCount = 1;
        mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        mainTableLayout.Size = new System.Drawing.Size(1000, 596);
        mainTableLayout.TabIndex = 1;

        // 
        // grpInput (Cột trái 35%)
        // 
        grpInput.Controls.Add(lblProductId);
        grpInput.Controls.Add(txtProductId);
        grpInput.Controls.Add(lblProductName);
        grpInput.Controls.Add(txtProductName);
        grpInput.Controls.Add(lblCategory);
        grpInput.Controls.Add(cboCategory);
        grpInput.Controls.Add(lblUnitPrice);
        grpInput.Controls.Add(txtUnitPrice);
        grpInput.Controls.Add(lblQuantity);
        grpInput.Controls.Add(txtQuantity);
        grpInput.Controls.Add(lblAvatar);
        grpInput.Controls.Add(picAvatar);
        grpInput.Controls.Add(btnChooseImage);
        grpInput.Controls.Add(btnAdd);
        grpInput.Controls.Add(btnUpdate);
        grpInput.Controls.Add(btnDelete);
        grpInput.Controls.Add(btnReset);
        grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
        grpInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        grpInput.Location = new System.Drawing.Point(10, 10);
        grpInput.Margin = new System.Windows.Forms.Padding(10);
        grpInput.Name = "grpInput";
        grpInput.Size = new System.Drawing.Size(330, 576);
        grpInput.TabIndex = 0;
        grpInput.TabStop = false;
        grpInput.Text = "Thông tin thiết bị";

        // 
        // lblProductId
        // 
        lblProductId.AutoSize = true;
        lblProductId.Location = new System.Drawing.Point(15, 25);
        lblProductId.Name = "lblProductId";
        lblProductId.Size = new System.Drawing.Size(101, 20);
        lblProductId.TabIndex = 0;
        lblProductId.Text = "Mã sản phẩm:";

        // 
        // txtProductId
        // 
        txtProductId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtProductId.Location = new System.Drawing.Point(15, 48);
        txtProductId.Name = "txtProductId";
        txtProductId.Size = new System.Drawing.Size(290, 27);
        txtProductId.TabIndex = 1;

        // 
        // lblProductName
        // 
        lblProductName.AutoSize = true;
        lblProductName.Location = new System.Drawing.Point(15, 80);
        lblProductName.Name = "lblProductName";
        lblProductName.Size = new System.Drawing.Size(103, 20);
        lblProductName.TabIndex = 2;
        lblProductName.Text = "Tên sản phẩm:";

        // 
        // txtProductName
        // 
        txtProductName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtProductName.Location = new System.Drawing.Point(15, 103);
        txtProductName.Name = "txtProductName";
        txtProductName.Size = new System.Drawing.Size(290, 27);
        txtProductName.TabIndex = 3;

        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Location = new System.Drawing.Point(15, 135);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new System.Drawing.Size(79, 20);
        lblCategory.TabIndex = 4;
        lblCategory.Text = "Danh mục:";

        // 
        // cboCategory
        // 
        cboCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboCategory.FormattingEnabled = true;
        cboCategory.Location = new System.Drawing.Point(15, 158);
        cboCategory.Name = "cboCategory";
        cboCategory.Size = new System.Drawing.Size(290, 28);
        cboCategory.TabIndex = 5;

        // 
        // lblUnitPrice
        // 
        lblUnitPrice.AutoSize = true;
        lblUnitPrice.Location = new System.Drawing.Point(15, 192);
        lblUnitPrice.Name = "lblUnitPrice";
        lblUnitPrice.Size = new System.Drawing.Size(95, 20);
        lblUnitPrice.TabIndex = 6;
        lblUnitPrice.Text = "Đơn giá (đ):";

        // 
        // txtUnitPrice
        // 
        txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtUnitPrice.Location = new System.Drawing.Point(15, 215);
        txtUnitPrice.Name = "txtUnitPrice";
        txtUnitPrice.Size = new System.Drawing.Size(290, 27);
        txtUnitPrice.TabIndex = 7;

        // 
        // lblQuantity
        // 
        lblQuantity.AutoSize = true;
        lblQuantity.Location = new System.Drawing.Point(15, 248);
        lblQuantity.Name = "lblQuantity";
        lblQuantity.Size = new System.Drawing.Size(72, 20);
        lblQuantity.TabIndex = 8;
        lblQuantity.Text = "Số lượng:";

        // 
        // txtQuantity
        // 
        txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtQuantity.Location = new System.Drawing.Point(15, 271);
        txtQuantity.Name = "txtQuantity";
        txtQuantity.Size = new System.Drawing.Size(290, 27);
        txtQuantity.TabIndex = 9;

        // 
        // lblAvatar
        // 
        lblAvatar.AutoSize = true;
        lblAvatar.Location = new System.Drawing.Point(15, 305);
        lblAvatar.Name = "lblAvatar";
        lblAvatar.Size = new System.Drawing.Size(107, 20);
        lblAvatar.TabIndex = 10;
        lblAvatar.Text = "Ảnh sản phẩm:";

        // 
        // picAvatar
        // 
        picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        picAvatar.Location = new System.Drawing.Point(15, 330);
        picAvatar.Name = "picAvatar";
        picAvatar.Size = new System.Drawing.Size(140, 130);
        picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        picAvatar.TabIndex = 11;
        picAvatar.TabStop = false;

        // 
        // btnChooseImage
        // 
        btnChooseImage.Location = new System.Drawing.Point(165, 330);
        btnChooseImage.Name = "btnChooseImage";
        btnChooseImage.Size = new System.Drawing.Size(110, 35);
        btnChooseImage.TabIndex = 12;
        btnChooseImage.Text = "Chọn Ảnh...";
        btnChooseImage.UseVisualStyleBackColor = true;
        btnChooseImage.Click += btnChooseImage_Click;

        // 
        // btnAdd
        // 
        btnAdd.Location = new System.Drawing.Point(15, 480);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(90, 35);
        btnAdd.TabIndex = 13;
        btnAdd.Text = "Thêm mới";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;

        // 
        // btnUpdate
        // 
        btnUpdate.Location = new System.Drawing.Point(115, 480);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new System.Drawing.Size(90, 35);
        btnUpdate.TabIndex = 14;
        btnUpdate.Text = "Cập nhật";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;

        // 
        // btnDelete
        // 
        btnDelete.Location = new System.Drawing.Point(215, 480);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new System.Drawing.Size(90, 35);
        btnDelete.TabIndex = 15;
        btnDelete.Text = "Xóa";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;

        // 
        // btnReset
        // 
        btnReset.Location = new System.Drawing.Point(15, 525);
        btnReset.Name = "btnReset";
        btnReset.Size = new System.Drawing.Size(290, 35);
        btnReset.TabIndex = 16;
        btnReset.Text = "Làm mới Form";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;

        // 
        // rightPanel (Cột phải 65%)
        // 
        rightPanel.Controls.Add(lblSearch);
        rightPanel.Controls.Add(txtSearch);
        rightPanel.Controls.Add(dgvProducts);
        rightPanel.Controls.Add(btnExportCsv);
        rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        rightPanel.Location = new System.Drawing.Point(360, 10);
        rightPanel.Margin = new System.Windows.Forms.Padding(10);
        rightPanel.Name = "rightPanel";
        rightPanel.Size = new System.Drawing.Size(630, 576);
        rightPanel.TabIndex = 1;

        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblSearch.Location = new System.Drawing.Point(5, 10);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new System.Drawing.Size(147, 21);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Tìm kiếm theo Tên:";

        // 
        // txtSearch (Live Search TextChanged)
        // 
        txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        txtSearch.Location = new System.Drawing.Point(160, 7);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Gõ tên thiết bị để tìm kiếm nhanh...";
        txtSearch.Size = new System.Drawing.Size(465, 29);
        txtSearch.TabIndex = 1;
        txtSearch.TextChanged += txtSearch_TextChanged;

        // 
        // dgvProducts (FullRowSelect, AutoGenerateColumns = false)
        // 
        dgvProducts.AllowUserToAddRows = false;
        dgvProducts.AllowUserToDeleteRows = false;
        dgvProducts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            colProductId,
            colProductName,
            colCategory,
            colUnitPrice,
            colQuantity
        });
        dgvProducts.Location = new System.Drawing.Point(5, 45);
        dgvProducts.MultiSelect = false;
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.RowHeadersWidth = 51;
        dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvProducts.Size = new System.Drawing.Size(620, 475);
        dgvProducts.TabIndex = 2;
        dgvProducts.CellClick += dgvProducts_CellClick;

        // 
        // colProductId
        // 
        colProductId.DataPropertyName = "ProductId";
        colProductId.FillWeight = 80F;
        colProductId.HeaderText = "Mã SP";
        colProductId.Name = "colProductId";
        colProductId.ReadOnly = true;

        // 
        // colProductName
        // 
        colProductName.DataPropertyName = "ProductName";
        colProductName.FillWeight = 160F;
        colProductName.HeaderText = "Tên SP";
        colProductName.Name = "colProductName";
        colProductName.ReadOnly = true;

        // 
        // colCategory
        // 
        colCategory.DataPropertyName = "CategoryName";
        colCategory.FillWeight = 100F;
        colCategory.HeaderText = "Danh Mục";
        colCategory.Name = "colCategory";
        colCategory.ReadOnly = true;

        // 
        // colUnitPrice (Format N0)
        // 
        colUnitPrice.DataPropertyName = "UnitPrice";
        colUnitPrice.DefaultCellStyle.Format = "N0";
        colUnitPrice.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        colUnitPrice.FillWeight = 100F;
        colUnitPrice.HeaderText = "Đơn Giá";
        colUnitPrice.Name = "colUnitPrice";
        colUnitPrice.ReadOnly = true;

        // 
        // colQuantity
        // 
        colQuantity.DataPropertyName = "Quantity";
        colQuantity.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        colQuantity.FillWeight = 70F;
        colQuantity.HeaderText = "Số Lượng";
        colQuantity.Name = "colQuantity";
        colQuantity.ReadOnly = true;

        // 
        // btnExportCsv (Anchor Bottom Right)
        // 
        btnExportCsv.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnExportCsv.Location = new System.Drawing.Point(485, 530);
        btnExportCsv.Name = "btnExportCsv";
        btnExportCsv.Size = new System.Drawing.Size(140, 35);
        btnExportCsv.TabIndex = 3;
        btnExportCsv.Text = "Xuất CSV...";
        btnExportCsv.UseVisualStyleBackColor = true;
        btnExportCsv.Click += btnExportCsv_Click;

        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;

        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1000, 650);
        Controls.Add(mainTableLayout);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        MinimumSize = new System.Drawing.Size(850, 550);
        Name = "Form1";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Quản Lý Danh Mục Thiết Bị Công Nghệ (TechMart Product Manager)";
        Load += Form1_Load;

        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        mainTableLayout.ResumeLayout(false);
        grpInput.ResumeLayout(false);
        grpInput.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
        rightPanel.ResumeLayout(false);
        rightPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
