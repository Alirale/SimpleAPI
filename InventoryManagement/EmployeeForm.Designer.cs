namespace InventoryManagement
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEmployees;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvEmployees = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            button1 = new Button();
            panelTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.Location = new Point(0, 60);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(981, 483);
            dgvEmployees.TabIndex = 1;
            dgvEmployees.CellDoubleClick += dgvEmployees_CellDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(747, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 28);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "جدید";
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(823, 14);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(70, 28);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "ویرایش";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(899, 14);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 28);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "حذف";
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(77, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "نام/نام‌کاربری…";
            txtSearch.Size = new Size(180, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(23, 21);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(44, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "جستجو:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(263, 17);
            button1.Name = "button1";
            button1.Size = new Size(80, 24);
            button1.TabIndex = 9;
            button1.Text = "جست و جو";
            button1.Click += button1_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(button1);
            panelTop.Controls.Add(lblSearch);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(btnDelete);
            panelTop.Controls.Add(btnEdit);
            panelTop.Controls.Add(btnAdd);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(8);
            panelTop.Size = new Size(981, 60);
            panelTop.TabIndex = 0;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 543);
            Controls.Add(dgvEmployees);
            Controls.Add(panelTop);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Employees";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button button1;
        private Panel panelTop;
    }
}