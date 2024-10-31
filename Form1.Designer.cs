namespace Phát_triển_phần_mềm_bán_sách
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            label6 = new Label();
            datePhieunhapNgaylapphieunhap = new DateTimePicker();
            txtPhieunhapTennhacungcap = new TextBox();
            label8 = new Label();
            btnPhieunhapSua = new Button();
            btnPhieunhapThem = new Button();
            btnPhieunhapXoa = new Button();
            dgPhieunhap = new DataGridView();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            txtLoaisachTenloaisach = new TextBox();
            label15 = new Label();
            btnLoaisachSua = new Button();
            btnLoaisachThem = new Button();
            button6 = new Button();
            dgLoaisach = new DataGridView();
            tabPage3 = new TabPage();
            panel4 = new Panel();
            label11 = new Label();
            dateHoadonNgaylaphoadon = new DateTimePicker();
            txtHoadonSĐT = new TextBox();
            label14 = new Label();
            txtHoadonTenkhachhang = new TextBox();
            label16 = new Label();
            button4 = new Button();
            button5 = new Button();
            btnHoadonXoa = new Button();
            dgHoadon = new DataGridView();
            tabPage4 = new TabPage();
            panel1 = new Panel();
            numSachGiaban = new NumericUpDown();
            label5 = new Label();
            numSachSoluong = new NumericUpDown();
            cbSachLoaisach = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtSachTacgia = new TextBox();
            label2 = new Label();
            txtSachTensach = new TextBox();
            label1 = new Label();
            btnSachSua = new Button();
            btnSachThem = new Button();
            btnSachXoa = new Button();
            dgSach = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPhieunhap).BeginInit();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLoaisach).BeginInit();
            tabPage3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgHoadon).BeginInit();
            tabPage4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSachGiaban).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSachSoluong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgSach).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(29, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(964, 594);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(dgPhieunhap);
            tabPage1.Location = new Point(4, 41);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(956, 549);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Phiếu nhập";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(datePhieunhapNgaylapphieunhap);
            panel2.Controls.Add(txtPhieunhapTennhacungcap);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnPhieunhapSua);
            panel2.Controls.Add(btnPhieunhapThem);
            panel2.Controls.Add(btnPhieunhapXoa);
            panel2.Location = new Point(15, 319);
            panel2.Name = "panel2";
            panel2.Size = new Size(926, 193);
            panel2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 28);
            label6.Name = "label6";
            label6.Size = new Size(194, 28);
            label6.TabIndex = 8;
            label6.Text = "Ngày lập phiếu nhập";
            // 
            // datePhieunhapNgaylapphieunhap
            // 
            datePhieunhapNgaylapphieunhap.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePhieunhapNgaylapphieunhap.Location = new Point(198, 22);
            datePhieunhapNgaylapphieunhap.Name = "datePhieunhapNgaylapphieunhap";
            datePhieunhapNgaylapphieunhap.Size = new Size(356, 34);
            datePhieunhapNgaylapphieunhap.TabIndex = 7;
            // 
            // txtPhieunhapTennhacungcap
            // 
            txtPhieunhapTennhacungcap.Location = new Point(198, 122);
            txtPhieunhapTennhacungcap.Name = "txtPhieunhapTennhacungcap";
            txtPhieunhapTennhacungcap.Size = new Size(356, 39);
            txtPhieunhapTennhacungcap.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 122);
            label8.Name = "label8";
            label8.Size = new Size(162, 28);
            label8.TabIndex = 3;
            label8.Text = "Tên nhà cung cấp";
            // 
            // btnPhieunhapSua
            // 
            btnPhieunhapSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPhieunhapSua.Location = new Point(784, 80);
            btnPhieunhapSua.Name = "btnPhieunhapSua";
            btnPhieunhapSua.Size = new Size(99, 35);
            btnPhieunhapSua.TabIndex = 2;
            btnPhieunhapSua.Text = "Sửa";
            btnPhieunhapSua.UseVisualStyleBackColor = true;
            // 
            // btnPhieunhapThem
            // 
            btnPhieunhapThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPhieunhapThem.Location = new Point(784, 28);
            btnPhieunhapThem.Name = "btnPhieunhapThem";
            btnPhieunhapThem.Size = new Size(99, 35);
            btnPhieunhapThem.TabIndex = 1;
            btnPhieunhapThem.Text = "Thêm";
            btnPhieunhapThem.UseVisualStyleBackColor = true;
            // 
            // btnPhieunhapXoa
            // 
            btnPhieunhapXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPhieunhapXoa.Location = new Point(784, 136);
            btnPhieunhapXoa.Name = "btnPhieunhapXoa";
            btnPhieunhapXoa.Size = new Size(99, 35);
            btnPhieunhapXoa.TabIndex = 0;
            btnPhieunhapXoa.Text = "Xóa";
            btnPhieunhapXoa.UseVisualStyleBackColor = true;
            // 
            // dgPhieunhap
            // 
            dgPhieunhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPhieunhap.Location = new Point(15, 30);
            dgPhieunhap.Name = "dgPhieunhap";
            dgPhieunhap.RowHeadersWidth = 62;
            dgPhieunhap.Size = new Size(926, 274);
            dgPhieunhap.TabIndex = 6;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(dgLoaisach);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(956, 556);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Loại sách";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtLoaisachTenloaisach);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(btnLoaisachSua);
            panel3.Controls.Add(btnLoaisachThem);
            panel3.Controls.Add(button6);
            panel3.Location = new Point(15, 370);
            panel3.Name = "panel3";
            panel3.Size = new Size(926, 142);
            panel3.TabIndex = 5;
            // 
            // txtLoaisachTenloaisach
            // 
            txtLoaisachTenloaisach.Location = new Point(256, 19);
            txtLoaisachTenloaisach.Name = "txtLoaisachTenloaisach";
            txtLoaisachTenloaisach.Size = new Size(445, 39);
            txtLoaisachTenloaisach.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(82, 19);
            label15.Name = "label15";
            label15.Size = new Size(121, 28);
            label15.TabIndex = 3;
            label15.Text = "Tên loại sách";
            // 
            // btnLoaisachSua
            // 
            btnLoaisachSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoaisachSua.Location = new Point(384, 93);
            btnLoaisachSua.Name = "btnLoaisachSua";
            btnLoaisachSua.Size = new Size(80, 35);
            btnLoaisachSua.TabIndex = 2;
            btnLoaisachSua.Text = "Sửa";
            btnLoaisachSua.UseVisualStyleBackColor = true;
            // 
            // btnLoaisachThem
            // 
            btnLoaisachThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoaisachThem.Location = new Point(52, 93);
            btnLoaisachThem.Name = "btnLoaisachThem";
            btnLoaisachThem.Size = new Size(88, 35);
            btnLoaisachThem.TabIndex = 1;
            btnLoaisachThem.Text = "Thêm";
            btnLoaisachThem.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(720, 93);
            button6.Name = "button6";
            button6.Size = new Size(80, 35);
            button6.TabIndex = 0;
            button6.Text = "Xóa";
            button6.UseVisualStyleBackColor = true;
            // 
            // dgLoaisach
            // 
            dgLoaisach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLoaisach.Location = new Point(15, 30);
            dgLoaisach.Name = "dgLoaisach";
            dgLoaisach.RowHeadersWidth = 62;
            dgLoaisach.Size = new Size(902, 280);
            dgLoaisach.TabIndex = 4;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel4);
            tabPage3.Controls.Add(dgHoadon);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(956, 556);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Hóa đơn";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(label11);
            panel4.Controls.Add(dateHoadonNgaylaphoadon);
            panel4.Controls.Add(txtHoadonSĐT);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(txtHoadonTenkhachhang);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(btnHoadonXoa);
            panel4.Location = new Point(15, 319);
            panel4.Name = "panel4";
            panel4.Size = new Size(926, 193);
            panel4.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 28);
            label11.Name = "label11";
            label11.Size = new Size(169, 28);
            label11.TabIndex = 8;
            label11.Text = "Ngày lập hóa đơn";
            // 
            // dateHoadonNgaylaphoadon
            // 
            dateHoadonNgaylaphoadon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateHoadonNgaylaphoadon.Location = new Point(198, 22);
            dateHoadonNgaylaphoadon.Name = "dateHoadonNgaylaphoadon";
            dateHoadonNgaylaphoadon.Size = new Size(356, 34);
            dateHoadonNgaylaphoadon.TabIndex = 7;
            // 
            // txtHoadonSĐT
            // 
            txtHoadonSĐT.Location = new Point(198, 130);
            txtHoadonSĐT.Name = "txtHoadonSĐT";
            txtHoadonSĐT.Size = new Size(356, 39);
            txtHoadonSĐT.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(57, 136);
            label14.Name = "label14";
            label14.Size = new Size(47, 28);
            label14.TabIndex = 5;
            label14.Text = "SĐT";
            // 
            // txtHoadonTenkhachhang
            // 
            txtHoadonTenkhachhang.Location = new Point(198, 69);
            txtHoadonTenkhachhang.Name = "txtHoadonTenkhachhang";
            txtHoadonTenkhachhang.Size = new Size(356, 39);
            txtHoadonTenkhachhang.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(3, 80);
            label16.Name = "label16";
            label16.Size = new Size(146, 28);
            label16.TabIndex = 3;
            label16.Text = "Tên khách hàng";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(784, 80);
            button4.Name = "button4";
            button4.Size = new Size(99, 35);
            button4.TabIndex = 2;
            button4.Text = "Sửa";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(784, 28);
            button5.Name = "button5";
            button5.Size = new Size(99, 35);
            button5.TabIndex = 1;
            button5.Text = "Thêm";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnHoadonXoa
            // 
            btnHoadonXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHoadonXoa.Location = new Point(784, 136);
            btnHoadonXoa.Name = "btnHoadonXoa";
            btnHoadonXoa.Size = new Size(99, 35);
            btnHoadonXoa.TabIndex = 0;
            btnHoadonXoa.Text = "Xóa";
            btnHoadonXoa.UseVisualStyleBackColor = true;
            // 
            // dgHoadon
            // 
            dgHoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgHoadon.Location = new Point(15, 30);
            dgHoadon.Name = "dgHoadon";
            dgHoadon.RowHeadersWidth = 62;
            dgHoadon.Size = new Size(926, 274);
            dgHoadon.TabIndex = 4;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panel1);
            tabPage4.Controls.Add(dgSach);
            tabPage4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(956, 556);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Sách";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(numSachGiaban);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numSachSoluong);
            panel1.Controls.Add(cbSachLoaisach);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSachTacgia);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSachTensach);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSachSua);
            panel1.Controls.Add(btnSachThem);
            panel1.Controls.Add(btnSachXoa);
            panel1.Location = new Point(24, 325);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 193);
            panel1.TabIndex = 1;
            // 
            // numSachGiaban
            // 
            numSachGiaban.Location = new Point(93, 155);
            numSachGiaban.Name = "numSachGiaban";
            numSachGiaban.Size = new Size(180, 34);
            numSachGiaban.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 157);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 12;
            label5.Text = "Số lượng";
            // 
            // numSachSoluong
            // 
            numSachSoluong.Location = new Point(480, 156);
            numSachSoluong.Name = "numSachSoluong";
            numSachSoluong.Size = new Size(100, 34);
            numSachSoluong.TabIndex = 11;
            // 
            // cbSachLoaisach
            // 
            cbSachLoaisach.FormattingEnabled = true;
            cbSachLoaisach.Location = new Point(116, 99);
            cbSachLoaisach.Name = "cbSachLoaisach";
            cbSachLoaisach.Size = new Size(331, 36);
            cbSachLoaisach.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 99);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 9;
            label4.Text = "Loại sách";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 154);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 7;
            label3.Text = "Giá bán";
            label3.Click += label3_Click;
            // 
            // txtSachTacgia
            // 
            txtSachTacgia.Location = new Point(91, 54);
            txtSachTacgia.Name = "txtSachTacgia";
            txtSachTacgia.Size = new Size(356, 34);
            txtSachTacgia.TabIndex = 6;
            txtSachTacgia.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 54);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 5;
            label2.Text = "Tác giả";
            // 
            // txtSachTensach
            // 
            txtSachTensach.Location = new Point(91, 6);
            txtSachTensach.Name = "txtSachTensach";
            txtSachTensach.Size = new Size(356, 34);
            txtSachTensach.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 3;
            label1.Text = "Tên sách";
            // 
            // btnSachSua
            // 
            btnSachSua.Location = new Point(824, 92);
            btnSachSua.Name = "btnSachSua";
            btnSachSua.Size = new Size(80, 35);
            btnSachSua.TabIndex = 2;
            btnSachSua.Text = "Sửa";
            btnSachSua.UseVisualStyleBackColor = true;
            // 
            // btnSachThem
            // 
            btnSachThem.Location = new Point(824, 19);
            btnSachThem.Name = "btnSachThem";
            btnSachThem.Size = new Size(80, 35);
            btnSachThem.TabIndex = 1;
            btnSachThem.Text = "Thêm";
            btnSachThem.UseVisualStyleBackColor = true;
            // 
            // btnSachXoa
            // 
            btnSachXoa.Location = new Point(824, 154);
            btnSachXoa.Name = "btnSachXoa";
            btnSachXoa.Size = new Size(80, 35);
            btnSachXoa.TabIndex = 0;
            btnSachXoa.Text = "Xóa";
            btnSachXoa.UseVisualStyleBackColor = true;
            // 
            // dgSach
            // 
            dgSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSach.Location = new Point(24, 36);
            dgSach.Name = "dgSach";
            dgSach.RowHeadersWidth = 62;
            dgSach.Size = new Size(782, 225);
            dgSach.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1137, 638);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý bán sách";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPhieunhap).EndInit();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgLoaisach).EndInit();
            tabPage3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgHoadon).EndInit();
            tabPage4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSachGiaban).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSachSoluong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel1;
        private Button btnSachXoa;
        private DataGridView dgSach;
        private Button btnSachSua;
        private Button btnSachThem;
        private Label label4;
        private Label label3;
        private TextBox txtSachTacgia;
        private Label label2;
        private TextBox txtSachTensach;
        private Label label1;
        private ComboBox cbSachLoaisach;
        private Label label5;
        private NumericUpDown numSachSoluong;
        private NumericUpDown numSachGiaban;
        private Panel panel3;
        private TextBox txtLoaisachTenloaisach;
        private Label label15;
        private Button btnLoaisachSua;
        private Button btnLoaisachThem;
        private Button button6;
        private DataGridView dgLoaisach;
        private Panel panel4;
        private Label label11;
        private DateTimePicker dateHoadonNgaylaphoadon;
        private TextBox txtHoadonSĐT;
        private Label label14;
        private TextBox txtHoadonTenkhachhang;
        private Label label16;
        private Button button4;
        private Button button5;
        private Button btnHoadonXoa;
        private DataGridView dgHoadon;
        private Panel panel2;
        private Label label6;
        private DateTimePicker datePhieunhapNgaylapphieunhap;
        private TextBox txtPhieunhapTennhacungcap;
        private Label label8;
        private Button btnPhieunhapSua;
        private Button btnPhieunhapThem;
        private Button btnPhieunhapXoa;
        private DataGridView dgPhieunhap;
    }
}
