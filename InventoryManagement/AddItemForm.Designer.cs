namespace InventoryManagement
{
    partial class AddItemForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblName = new Label();
            lblCategory = new Label();
            lblDescription = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            txtDescription = new TextBox();
            numPrice = new NumericUpDown();
            numQuantity = new NumericUpDown();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 15);
            lblName.TabIndex = 0;
            lblName.Text = "نام محصول:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 60);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(59, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "دسته‌بندی:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 100);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(57, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "توضیحات:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(20, 175);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(38, 15);
            lblUnitPrice.TabIndex = 6;
            lblUnitPrice.Text = "قیمت:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(20, 215);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(36, 15);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "تعداد:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 23);
            txtName.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(120, 57);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(220, 23);
            cmbCategory.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 97);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(220, 60);
            txtDescription.TabIndex = 5;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(120, 172);
            numPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(220, 23);
            numPrice.TabIndex = 7;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(120, 212);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(220, 23);
            numQuantity.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(64, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(220, 35);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "افزودن";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddItemForm
            // 
            ClientSize = new Size(370, 320);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblUnitPrice);
            Controls.Add(numPrice);
            Controls.Add(lblQuantity);
            Controls.Add(numQuantity);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddItemForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن محصول";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
