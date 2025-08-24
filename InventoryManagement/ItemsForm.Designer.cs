namespace InventoryManagement
{
    partial class ItemsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvItems;
        private Panel panelTop;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCategory;
        private ComboBox comboBox1;
        private Button btnSearch;
        private Panel panelHeader;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvItems = new DataGridView();
            panelTop = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblCategory = new Label();
            comboBox1 = new ComboBox();
            btnSearch = new Button();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            panelHeader = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            panelTop.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.EnableHeadersVisualStyles = false;
            dgvItems.Location = new Point(0, 115);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(1103, 485);
            dgvItems.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(lblSearch);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblCategory);
            panelTop.Controls.Add(comboBox1);
            panelTop.Controls.Add(btnSearch);
            panelTop.Controls.Add(buttonAdd);
            panelTop.Controls.Add(buttonEdit);
            panelTop.Controls.Add(buttonDelete);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 60);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(8);
            panelTop.Size = new Size(1103, 55);
            panelTop.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(15, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(69, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "نام محصول:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(90, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(160, 23);
            txtSearch.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(325, 20);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 23);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "دسته بندی:";
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(410, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(580, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 28);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "🔍 جستجو";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MediumSeaGreen;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(779, 16);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(85, 28);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "➕ افزودن";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Goldenrod;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(869, 16);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(85, 28);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "✏️ ویرایش";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Firebrick;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(959, 16);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(85, 28);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "🗑️ حذف";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1103, 60);
            panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(121, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "مدیریت کالاها";
            // 
            // ItemsForm
            // 
            ClientSize = new Size(1103, 600);
            Controls.Add(dgvItems);
            Controls.Add(panelTop);
            Controls.Add(panelHeader);
            Name = "ItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مدیریت کالاها";
            Load += ItemsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }
    }
}
