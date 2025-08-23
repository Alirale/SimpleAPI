using System.ComponentModel;
using Domain.Entities;

namespace InventoryManagement
{
    public partial class EmployeeForm : Form
    {
        private readonly BindingList<User> _view = new();
        private readonly BindingSource _bs = new();

        public EmployeeForm()
        {
            InitializeComponent();
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.Columns.Clear();
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID",
                Width = 70,
                FillWeight = 10
            });

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFullName",
                HeaderText = "نام و نام خانوادگی"
            });

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserName",
                HeaderText = "نام کاربری"
            });

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MobileNumber",
                HeaderText = "موبایل"
            });

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "ایمیل"
            });

            _bs.DataSource = _view;
            dgvEmployees.DataSource = _bs;
            dgvEmployees.CellFormatting += dgvEmployees_CellFormatting;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            _view.Clear();

            _view.Add(new User { ID = 1, FirstName = "علی", LastName = "رضایی", UserName = "alirez", MobileNumber = "0912...", Email = "ali@example.com" });
            _view.Add(new User { ID = 2, FirstName = "مریم", LastName = "احمدی", UserName = "maryam", MobileNumber = "0935...", Email = "maryam@example.com" });
            _view.Add(new User { ID = 3, FirstName = "حسین", LastName = "کریمی", UserName = "hossein", MobileNumber = "0913...", Email = "hossein@example.com" });

            _view.RaiseListChangedEvents = true;
            _view.ResetBindings();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmployees_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEmployees.Columns[e.ColumnIndex].Name == "colFullName")
            {
                if (_bs[e.RowIndex] is User row)
                    e.Value = $"{row.FirstName} {row.LastName}".Trim();
                e.FormattingApplied = true;
            }
        }
    }
}