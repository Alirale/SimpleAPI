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
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label lblDateFrom;
        private Label lblDateTo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvItems = new DataGridView();
            panelTop = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblCategory = new Label();
            comboBox1 = new ComboBox();
            lblDateFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblDateTo = new Label();
            dtpTo = new DateTimePicker();
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

            // dgvItems
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 115);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(1103, 485);
            dgvItems.TabIndex = 0;

            // panelTop
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(lblSearch);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblCategory);
            panelTop.Controls.Add(comboBox1);
            panelTop.Controls.Add(lblDateFrom);
            panelTop.Controls.Add(dtpFrom);
            panelTop.Controls.Add(lblDateTo);
            panelTop.Controls.Add(dtpTo);
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

            // lblSearch
            lblSearch.Location = new Point(15, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(69, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "نام محصول:";

            // txtSearch
            txtSearch.Location = new Point(90, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(160, 23);
            txtSearch.TabIndex = 1;

            // lblCategory
            lblCategory.Location = new Point(274, 20);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(64, 23);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "دسته بندی:";

            // comboBox1
            comboBox1.Location = new Point(344, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 3;

            // lblDateFrom
            lblDateFrom.Location = new Point(531, 20);
            lblDateFrom.Name = "lblDateFrom";
            lblDateFrom.Size = new Size(48, 23);
            lblDateFrom.TabIndex = 4;
            lblDateFrom.Text = "از تاریخ:";

            // dtpFrom
            dtpFrom.Location = new Point(585, 20);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(214, 23);
            dtpFrom.TabIndex = 5;
            dtpFrom.Value = DateTime.Now.AddDays(-10); // Default 10 days ago

            // lblDateTo
            lblDateTo.Location = new Point(805, 20);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(45, 23);
            lblDateTo.TabIndex = 6;
            lblDateTo.Text = "تا تاریخ:";

            // dtpTo
            dtpTo.Location = new Point(856, 20);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(208, 23);
            dtpTo.TabIndex = 7;
            dtpTo.Value = DateTime.Now.AddDays(10); // Default 10 days after

            // btnSearch
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1079, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 28);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "🔍 جستجو";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;

            // buttonAdd
            buttonAdd.BackColor = Color.MediumSeaGreen;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(1170, 17);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(85, 28);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "➕ افزودن";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;

            // buttonEdit
            buttonEdit.BackColor = Color.Goldenrod;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(1260, 17);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(85, 28);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "✏️ ویرایش";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;

            // buttonDelete
            buttonDelete.BackColor = Color.Firebrick;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(1350, 17);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(85, 28);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "🗑️ حذف";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;

            // panelHeader
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1103, 60);
            panelHeader.TabIndex = 2;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(121, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "مدیریت کالاها";

            // ItemsForm
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
