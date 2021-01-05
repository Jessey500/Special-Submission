namespace InventoryManagmentSystem
{
    partial class Items
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblitemname = new System.Windows.Forms.Label();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.lblitemprice = new System.Windows.Forms.Label();
            this.btnItemSave = new System.Windows.Forms.Button();
            this.btnItemCancel = new System.Windows.Forms.Button();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.Item_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Items";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(87, 82);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(109, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Location = new System.Drawing.Point(23, 82);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(58, 13);
            this.lblitemname.TabIndex = 2;
            this.lblitemname.Text = "Item Name";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(87, 117);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(109, 20);
            this.txtItemPrice.TabIndex = 3;
            // 
            // lblitemprice
            // 
            this.lblitemprice.AutoSize = true;
            this.lblitemprice.Location = new System.Drawing.Point(23, 120);
            this.lblitemprice.Name = "lblitemprice";
            this.lblitemprice.Size = new System.Drawing.Size(54, 13);
            this.lblitemprice.TabIndex = 4;
            this.lblitemprice.Text = "Item Price";
            // 
            // btnItemSave
            // 
            this.btnItemSave.Location = new System.Drawing.Point(316, 47);
            this.btnItemSave.Name = "btnItemSave";
            this.btnItemSave.Size = new System.Drawing.Size(71, 30);
            this.btnItemSave.TabIndex = 5;
            this.btnItemSave.Text = "Save";
            this.btnItemSave.UseVisualStyleBackColor = true;
            this.btnItemSave.Click += new System.EventHandler(this.btnItemSave_Click);
            // 
            // btnItemCancel
            // 
            this.btnItemCancel.Location = new System.Drawing.Point(316, 83);
            this.btnItemCancel.Name = "btnItemCancel";
            this.btnItemCancel.Size = new System.Drawing.Size(71, 28);
            this.btnItemCancel.TabIndex = 6;
            this.btnItemCancel.Text = "Cancel";
            this.btnItemCancel.UseVisualStyleBackColor = true;
            this.btnItemCancel.Click += new System.EventHandler(this.btnItemCancel_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Id,
            this.Item_Name,
            this.Item_Price});
            this.dgvItem.Location = new System.Drawing.Point(17, 156);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(427, 192);
            this.dgvItem.TabIndex = 7;
            this.dgvItem.DoubleClick += new System.EventHandler(this.dgvItem_DoubleClick);
            // 
            // Item_Id
            // 
            this.Item_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Id.DataPropertyName = "Item_Id";
            this.Item_Id.HeaderText = "ID";
            this.Item_Id.Name = "Item_Id";
            this.Item_Id.ReadOnly = true;
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Name.DataPropertyName = "Item_Name";
            this.Item_Name.HeaderText = "Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // Item_Price
            // 
            this.Item_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Price.DataPropertyName = "Item_Price";
            this.Item_Price.HeaderText = "Price";
            this.Item_Price.Name = "Item_Price";
            this.Item_Price.ReadOnly = true;
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.Location = new System.Drawing.Point(316, 117);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(71, 28);
            this.btnItemDelete.TabIndex = 8;
            this.btnItemDelete.Text = "Delete";
            this.btnItemDelete.UseVisualStyleBackColor = true;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item Id";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(87, 47);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.ReadOnly = true;
            this.txtItemId.Size = new System.Drawing.Size(109, 20);
            this.txtItemId.TabIndex = 9;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.btnItemDelete);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.btnItemCancel);
            this.Controls.Add(this.btnItemSave);
            this.Controls.Add(this.lblitemprice);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.lblitemname);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblName);
            this.Name = "Items";
            this.Text = "Items";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Label lblitemprice;
        private System.Windows.Forms.Button btnItemSave;
        private System.Windows.Forms.Button btnItemCancel;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Price;
        private System.Windows.Forms.Button btnItemDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemId;


    }
}

