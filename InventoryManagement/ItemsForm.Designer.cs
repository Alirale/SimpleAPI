namespace InventoryManagement
{
    partial class ItemsForm
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
            components = new System.ComponentModel.Container();
            dgvItems = new DataGridView();
            panelTop = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 60);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(1115, 540);
            dgvItems.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblSearch);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(comboBox1);
            panelTop.Controls.Add(btnSearch);
            panelTop.Controls.Add(btnAdd);
            panelTop.Controls.Add(btnEdit);
            panelTop.Controls.Add(btnDelete);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(8);
            panelTop.Size = new Size(1115, 60);
            panelTop.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(16, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(67, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "نام محصول:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(89, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "نام محصول…";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "دسته بندی:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "همه", "پوشاک", "لوازم الکترونیکی", "مواد غذایی", "مبلمان", "لوازم‌التحریر", "ابزارها", "اسباب‌بازی‌ها", "کتاب‌ها", "ورزش", "زیبایی", "دارو", "لوازم جانبی", "وسایل نقلیه", "لوازم خانگی" });
            comboBox1.Location = new Point(368, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(540, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 26);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "جست‌وجو";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(1115, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 26);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "جدید";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(1115, 15);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(70, 26);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(1115, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 26);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 600);
            Controls.Add(dgvItems);
            Controls.Add(panelTop);
            Name = "ItemsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ItemsForm";
            Load += ItemsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvItems;
        private Panel panelTop;
        private Button button1;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private ComboBox comboBox1;
        private BindingSource bindingSource1;
        private Label label1;
        private Button btnSearch;
    }
}