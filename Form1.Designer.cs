namespace UpdateData13
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.txtNameItem = new System.Windows.Forms.TextBox();
            this.lsvListProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteManyProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.txtCostProduct = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtCodeProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodeItem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cbbItem = new System.Windows.Forms.ComboBox();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddManyProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTempProduct = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteItem.Location = new System.Drawing.Point(15, 77);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(159, 34);
            this.btnDeleteItem.TabIndex = 5;
            this.btnDeleteItem.Text = "Xoá danh mục";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // txtNameItem
            // 
            this.txtNameItem.Location = new System.Drawing.Point(129, 49);
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.Size = new System.Drawing.Size(223, 22);
            this.txtNameItem.TabIndex = 3;
            // 
            // lsvListProduct
            // 
            this.lsvListProduct.CheckBoxes = true;
            this.lsvListProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvListProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvListProduct.FullRowSelect = true;
            this.lsvListProduct.GridLines = true;
            this.lsvListProduct.HideSelection = false;
            this.lsvListProduct.Location = new System.Drawing.Point(386, 43);
            this.lsvListProduct.Name = "lsvListProduct";
            this.lsvListProduct.Size = new System.Drawing.Size(720, 509);
            this.lsvListProduct.TabIndex = 39;
            this.lsvListProduct.UseCompatibleStateImageBehavior = false;
            this.lsvListProduct.View = System.Windows.Forms.View.Details;
            this.lsvListProduct.SelectedIndexChanged += new System.EventHandler(this.lsvListProduct_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 255;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 154;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Danh mục";
            this.columnHeader4.Width = 123;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateItem.Location = new System.Drawing.Point(194, 77);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(158, 34);
            this.btnUpdateItem.TabIndex = 4;
            this.btnUpdateItem.Text = "Cập nhật";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteManyProduct);
            this.groupBox2.Controls.Add(this.btnUpdateProduct);
            this.groupBox2.Controls.Add(this.btnDeleteProduct);
            this.groupBox2.Controls.Add(this.txtCostProduct);
            this.groupBox2.Controls.Add(this.txtNameProduct);
            this.groupBox2.Controls.Add(this.txtCodeProduct);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 187);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật sản phẩm";
            // 
            // btnDeleteManyProduct
            // 
            this.btnDeleteManyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteManyProduct.Location = new System.Drawing.Point(15, 143);
            this.btnDeleteManyProduct.Name = "btnDeleteManyProduct";
            this.btnDeleteManyProduct.Size = new System.Drawing.Size(158, 34);
            this.btnDeleteManyProduct.TabIndex = 12;
            this.btnDeleteManyProduct.Text = "Xoá nhiều sản phẩm";
            this.btnDeleteManyProduct.UseVisualStyleBackColor = true;
            this.btnDeleteManyProduct.Click += new System.EventHandler(this.btnDeleteManyProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateProduct.Location = new System.Drawing.Point(198, 103);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(158, 34);
            this.btnUpdateProduct.TabIndex = 11;
            this.btnUpdateProduct.Text = "Cập nhật sản phẩm";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteProduct.Location = new System.Drawing.Point(15, 103);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(158, 34);
            this.btnDeleteProduct.TabIndex = 10;
            this.btnDeleteProduct.Text = "Xoá sản phẩm";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // txtCostProduct
            // 
            this.txtCostProduct.Location = new System.Drawing.Point(129, 75);
            this.txtCostProduct.Name = "txtCostProduct";
            this.txtCostProduct.Size = new System.Drawing.Size(223, 22);
            this.txtCostProduct.TabIndex = 8;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(129, 47);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(223, 22);
            this.txtNameProduct.TabIndex = 7;
            // 
            // txtCodeProduct
            // 
            this.txtCodeProduct.Location = new System.Drawing.Point(129, 19);
            this.txtCodeProduct.Name = "txtCodeProduct";
            this.txtCodeProduct.ReadOnly = true;
            this.txtCodeProduct.Size = new System.Drawing.Size(223, 22);
            this.txtCodeProduct.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã sản phẩm";
            // 
            // txtCodeItem
            // 
            this.txtCodeItem.Location = new System.Drawing.Point(129, 21);
            this.txtCodeItem.Name = "txtCodeItem";
            this.txtCodeItem.ReadOnly = true;
            this.txtCodeItem.Size = new System.Drawing.Size(223, 22);
            this.txtCodeItem.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowAll);
            this.groupBox3.Controls.Add(this.cbbItem);
            this.groupBox3.Controls.Add(this.btnSaveProduct);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtAddCost);
            this.groupBox3.Controls.Add(this.txtAddName);
            this.groupBox3.Controls.Add(this.txtAddCode);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnAddManyProduct);
            this.groupBox3.Controls.Add(this.btnAddProduct);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 222);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm sản phẩm";
            // 
            // btnShowAll
            // 
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.Location = new System.Drawing.Point(194, 176);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(158, 34);
            this.btnShowAll.TabIndex = 27;
            this.btnShowAll.Text = "Hiển thị tất cả";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cbbItem
            // 
            this.cbbItem.FormattingEnabled = true;
            this.cbbItem.Location = new System.Drawing.Point(130, 21);
            this.cbbItem.Name = "cbbItem";
            this.cbbItem.Size = new System.Drawing.Size(223, 24);
            this.cbbItem.TabIndex = 26;
            this.cbbItem.SelectedIndexChanged += new System.EventHandler(this.cbbItem_SelectedIndexChanged);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveProduct.Location = new System.Drawing.Point(15, 176);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(159, 34);
            this.btnSaveProduct.TabIndex = 25;
            this.btnSaveProduct.Text = "Lưu sản phẩm";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Danh mục";
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(130, 108);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(222, 22);
            this.txtAddCost.TabIndex = 22;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(130, 80);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(222, 22);
            this.txtAddName.TabIndex = 21;
            // 
            // txtAddCode
            // 
            this.txtAddCode.Location = new System.Drawing.Point(130, 52);
            this.txtAddCode.Name = "txtAddCode";
            this.txtAddCode.Size = new System.Drawing.Size(223, 22);
            this.txtAddCode.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã sản phẩm";
            // 
            // btnAddManyProduct
            // 
            this.btnAddManyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddManyProduct.Location = new System.Drawing.Point(16, 136);
            this.btnAddManyProduct.Name = "btnAddManyProduct";
            this.btnAddManyProduct.Size = new System.Drawing.Size(158, 34);
            this.btnAddManyProduct.TabIndex = 14;
            this.btnAddManyProduct.Text = "Thêm nhiều sản phẩm";
            this.btnAddManyProduct.UseVisualStyleBackColor = true;
            this.btnAddManyProduct.Click += new System.EventHandler(this.btnAddManyProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Location = new System.Drawing.Point(194, 136);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(158, 34);
            this.btnAddProduct.TabIndex = 13;
            this.btnAddProduct.Text = "Thêm một sản phẩm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteItem);
            this.groupBox1.Controls.Add(this.btnUpdateItem);
            this.groupBox1.Controls.Add(this.txtNameItem);
            this.groupBox1.Controls.Add(this.txtCodeItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 121);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên danh mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã danh mục";
            // 
            // lblTempProduct
            // 
            this.lblTempProduct.AutoSize = true;
            this.lblTempProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempProduct.Location = new System.Drawing.Point(386, 20);
            this.lblTempProduct.Name = "lblTempProduct";
            this.lblTempProduct.Size = new System.Drawing.Size(0, 16);
            this.lblTempProduct.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 564);
            this.Controls.Add(this.lblTempProduct);
            this.Controls.Add(this.lsvListProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.TextBox txtNameItem;
        private System.Windows.Forms.ListView lsvListProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteManyProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox txtCostProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtCodeProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodeItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cbbItem;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddManyProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTempProduct;
    }
}

