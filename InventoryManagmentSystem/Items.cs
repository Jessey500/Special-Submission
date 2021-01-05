using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class Items : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public Items()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            this.PopulateGridViewItem();
        }

        private void PopulateGridViewItem(string sql = @"SELECT * FROM Item;")
        {
            try
            {
                this.dgvItem.AutoGenerateColumns = false;
                this.Ds = this.Da.ExecuteQuery(sql);
                dgvItem.DataSource = Ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void insertItem()
        {
            try
            {
                string sql = "select * from Item where Item_Id = '" + this.txtItemId.Text + "';";
                this.Ds = this.Da.ExecuteQuery(sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    sql = @"update Item set Item_Name = '" + this.txtItemName.Text + "', Item_Price = '" + float.Parse(this.txtItemPrice.Text) + "' where Item_Id='" + txtItemId.Text + "';";
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show(this.txtItemName.Text + " has been updated.");
                    this.cleanItem();
                    this.PopulateGridViewItem();
                }
                else
                {
                    sql = @"insert into Item values ('" + this.txtItemName.Text + "','" + float.Parse(this.txtItemPrice.Text) + "');";
                    int count = this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Insertion Done.\n" + count + " rows has been inserted.");
                    this.cleanItem();
                    this.PopulateGridViewItem();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void cleanItem()
        {
            this.txtItemId.Text = null;
            this.txtItemName.Text = null;
            this.txtItemPrice.Text = null;
            this.PopulateGridViewItem();
        }

        private void btnItemSave_Click(object sender, EventArgs e)
        {
            this.insertItem();
        }

        private void fillItem()
        {
            try
            {
                this.txtItemId.Text = this.dgvItem.CurrentRow.Cells[0].Value.ToString();
                this.txtItemName.Text = this.dgvItem.CurrentRow.Cells[1].Value.ToString();
                this.txtItemPrice.Text = this.dgvItem.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void deleteItem()
        {
            try
            {
                string id = this.dgvItem.CurrentRow.Cells[0].Value.ToString();
                string name = this.dgvItem.CurrentRow.Cells[1].Value.ToString(); ;
                string sql = "delete from Item where Item_Id='" + id + "';";
                this.Da.ExecuteQuery(sql);
                MessageBox.Show(name + " deleted!");
                this.PopulateGridViewItem();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnItemCancel_Click(object sender, EventArgs e)
        {
            this.cleanItem();
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            this.deleteItem();
            this.cleanItem();
        }

        private void dgvItem_DoubleClick(object sender, EventArgs e)
        {
            this.fillItem();
        }
    }
}
