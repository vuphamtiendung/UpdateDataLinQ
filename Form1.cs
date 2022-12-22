using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateData13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        bool isFinished = false; // flag variable
        List<SanPham> listProduct = new List<SanPham>(); // List display product
        List<DanhMuc> listItem = new List<DanhMuc>(); // List display Item

        /// <summary>
        /// Display Product
        /// </summary>
        public void DisplayProduct()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            listProduct = (from i in context.SanPhams
                           select i).ToList();
            lsvListProduct.Items.Clear();
            listProduct.ForEach(x =>
            {
                ListViewItem product = new ListViewItem(x.MaSP + "");
                product.SubItems.Add(x.TenSP);
                product.SubItems.Add(x.DonGia + "");
                product.SubItems.Add(x.MaDanhMuc + "");
                lsvListProduct.Items.Add(product);
            });
        }

        /// <summary>
        /// Dislay Item
        /// </summary>
        public void DisplayItem()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            listItem = (from i in context.DanhMucs
                        select i).ToList();
            lsvListProduct.Items.Clear();
            cbbItem.DataSource = listItem;
            cbbItem.ValueMember = "MaDanhMuc";
            cbbItem.DisplayMember = "TenDanhMuc";
            isFinished = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayProduct();
            DisplayItem();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayProduct();
        }

        /// <summary>
        /// Ecxecution combobox
        /// choose item will display list product in ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbItem.SelectedIndex == -1) return;
            if (isFinished == false) return;
            int code = (byte)cbbItem.SelectedValue;
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> product = (from i in context.SanPhams
                                     where i.MaDanhMuc == code
                                     select i).ToList();
            lsvListProduct.Items.Clear();
            product.ForEach(x =>
            {
                ListViewItem listPro = new ListViewItem(x.MaSP + "");
                listPro.SubItems.Add(x.TenSP);
                listPro.SubItems.Add(x.DonGia + "");
                listPro.SubItems.Add(x.MaDanhMuc + "");
                lsvListProduct.Items.Add(listPro);
            });

            DanhMuc danhmuc = (from i in context.DanhMucs
                               select i).FirstOrDefault(x => x.MaDanhMuc == code);
            if(danhmuc != null)
            {
                txtCodeItem.Text = danhmuc.MaDanhMuc + "";
                txtNameItem.Text = danhmuc.TenDanhMuc;
            }
        }

        private void lsvListProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvListProduct.SelectedItems.Count == 0) return;
            ListViewItem list = lsvListProduct.SelectedItems[0];
            int code = Convert.ToByte(list.SubItems[0].Text);
            CSDLTestDataContext context = new CSDLTestDataContext();
            SanPham sanpham = (from i in context.SanPhams
                               select i).FirstOrDefault(x => x.MaSP == code);
            if(sanpham != null)
            {
                txtCodeProduct.Text = sanpham.MaSP + "";
                txtNameProduct.Text = sanpham.TenSP;
                txtCostProduct.Text = sanpham.DonGia + "";
            }
        }

        List<SanPham> listAddProduct = new List<SanPham>();
        private void btnAddProduct_Click(object sender, EventArgs e)
        {        
            try
            {
                int code = (byte)cbbItem.SelectedValue;
                CSDLTestDataContext context = new CSDLTestDataContext();
                SanPham sanpham = new SanPham();
                sanpham.MaSP = Convert.ToByte(txtAddCode.Text);
                sanpham.TenSP = txtAddName.Text;
                sanpham.DonGia = Convert.ToInt64(txtAddCost.Text);
                sanpham.MaDanhMuc = (byte)code;
                listAddProduct.Add(sanpham);
                context.SanPhams.InsertOnSubmit(sanpham);
                context.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Đã có lỗi xảy ra! \n Chi tiết {ex.Message}");
            }
            finally
            {
                DisplayProduct();
            }
        }

        private void btnAddManyProduct_Click(object sender, EventArgs e)
        {
            try
            {
                byte code = (byte)cbbItem.SelectedValue;
                CSDLTestDataContext context = new CSDLTestDataContext();
                SanPham sanpham = new SanPham();
                sanpham.MaSP = Convert.ToByte(txtAddCode.Text);
                sanpham.TenSP = txtAddName.Text;
                sanpham.DonGia = Convert.ToInt64(txtAddCost.Text);
                sanpham.MaDanhMuc = (byte)code;
                listAddProduct.Add(sanpham);
                lblTempProduct.Text = $"Bạn đã có " + listAddProduct.Count + " sản phẩm trong hàng chờ";
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Đã có lỗi xảy ra! \n chi tiết {ex.Message}");
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            DialogResult rt = MessageBox.Show("Bạn có muốn lưu " + listAddProduct.Count + " sản phẩm này không?", "Hỏi?",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);
            if (rt == DialogResult.Yes)
            {
                context.SanPhams.InsertAllOnSubmit(listAddProduct);
                context.SubmitChanges();
                MessageBox.Show("Đã thêm " + listAddProduct.Count + " sản phẩm vào database");
                DisplayProduct();
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            int code = Convert.ToByte(txtCodeProduct.Text);
            byte item = (byte)cbbItem.SelectedValue;
            SanPham sanpham = (from i in context.SanPhams
                               select i).FirstOrDefault(x => x.MaSP == code);
            if(sanpham != null)
            {
                try
                {
                    sanpham.TenSP = txtNameProduct.Text;
                    sanpham.DonGia = Convert.ToInt64(txtCostProduct.Text);
                    sanpham.MaDanhMuc = (byte)item;
                    context.SubmitChanges();
                    MessageBox.Show("Đã sửa dữ liệu");
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi! \n chi tiết: {ex.Message}");
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            byte code = Convert.ToByte(txtCodeProduct.Text);
            CSDLTestDataContext context = new CSDLTestDataContext();
            SanPham sanpham = (from i in context.SanPhams
                               select i).FirstOrDefault(x => x.MaSP == code);
            if(sanpham != null)
            {
                try
                {
                    context.SanPhams.DeleteOnSubmit(sanpham);
                    context.SubmitChanges();
                    MessageBox.Show("Đã xoá sản phẩm này");
                    DisplayItem();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi! \n Chi tiết {ex.Message}");
                }
            }
        }

        private void btnDeleteManyProduct_Click(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            ListView.CheckedListViewItemCollection listChecked = lsvListProduct.CheckedItems;
            List<SanPham> listDelete = new List<SanPham>();
            foreach(ListViewItem item in listChecked)
            {
                byte code = Convert.ToByte(item.SubItems[0].Text);
                SanPham sanpham = (from i in context.SanPhams
                                   select i).FirstOrDefault(x => x.MaSP == code);
                listDelete.Add(sanpham);
            }
            DialogResult rt = MessageBox.Show("Bạn có muốn xoá " + listDelete.Count + " sản phẩm này không?", "Hỏi",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
            if(rt == DialogResult.Yes)
            {
                context.SanPhams.DeleteAllOnSubmit(listDelete);
                context.SubmitChanges();
                MessageBox.Show("Đã xoá " + listDelete.Count + " sản phẩm");
                DisplayProduct();
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            int code = Convert.ToByte(txtCodeItem.Text);
            CSDLTestDataContext context = new CSDLTestDataContext();
            DanhMuc danhmuc = (from i in context.DanhMucs
                               select i).FirstOrDefault(x => x.MaDanhMuc == code);
            if(danhmuc != null)
            {
                try
                {
                    danhmuc.TenDanhMuc = txtNameItem.Text;
                    context.SubmitChanges();
                    MessageBox.Show("Đã sửa tên danh mục");
                    DisplayItem();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi! \n Chi tiết {ex.Message}");
                }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int code = Convert.ToByte(txtCodeItem.Text);
            CSDLTestDataContext context = new CSDLTestDataContext();
            DanhMuc danhmuc = (from i in context.DanhMucs
                               select i).FirstOrDefault(x => x.MaDanhMuc == code);
            if(danhmuc != null)
            {
                try
                {
                    if(danhmuc.SanPhams.Count > 0)
                    {
                        MessageBox.Show("Không thể xoá danh mục này do có " + danhmuc.SanPhams.Count + " sản phẩm");
                        return;
                    }
                    else
                    {
                        context.DanhMucs.DeleteOnSubmit(danhmuc);
                        context.SubmitChanges();
                        DisplayItem();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi! \n chi tiết {ex.Message}");
                }
            }
        }
    }
}
