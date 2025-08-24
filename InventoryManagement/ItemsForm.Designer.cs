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
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnSearch = new Button();
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
            dgvItems.Size = new Size(1047, 474);
            dgvItems.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonDelete);
            panelTop.Controls.Add(buttonEdit);
            panelTop.Controls.Add(buttonAdd);
            panelTop.Controls.Add(lblSearch);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(comboBox1);
            panelTop.Controls.Add(btnSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(8);
            panelTop.Size = new Size(1047, 60);
            panelTop.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(950, 15);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(85, 26);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "حذف";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(859, 15);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(85, 26);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "ویرایش";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(768, 15);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(85, 26);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "افزودن";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(16, 21);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(67, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "نام محصول:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(89, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "نام محصول…";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 21);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "دسته بندی:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "پوشاک", "لوازم الکترونیکی", "مواد غذایی", "مبلمان", "لوازم‌التحریر", "ابزارها", "اسباب‌بازی‌ها", "کتاب‌ها", "ورزش", "زیبایی", "دارو", "لوازم جانبی", "وسایل نقلیه", "لوازم خانگی" });
            comboBox1.Location = new Point(368, 17);
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
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 534);
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
        private Button buttonEdit;
        private Label lblSearch;
        private TextBox txtSearch;
        private ComboBox comboBox1;
        private BindingSource bindingSource1;
        private Label label1;
        private Button btnSearch;
        private Button buttonAdd;
        private Button buttonDelete;
    }
}