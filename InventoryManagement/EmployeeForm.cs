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
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Columns.Clear();

            var colSelect = new DataGridViewCheckBoxColumn
            {
                Name = "colSelect",
                HeaderText = "انتخاب",
                Width = 60,
                ThreeState = false,
                FillWeight = 30
            };
            dgvEmployees.Columns.Insert(0, colSelect);

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "شناسه",
                Width = 70,
                FillWeight = 30
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

            dgvEmployees.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvEmployees.IsCurrentCellDirty)
                    dgvEmployees.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            dgvEmployees.CellContentClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                if (dgvEmployees.Columns[e.ColumnIndex].Name != "colSelect") return;

                foreach (DataGridViewRow r in dgvEmployees.Rows)
                    if (r.Index != e.RowIndex)
                        r.Cells["colSelect"].Value = false;

                var cell = (DataGridViewCheckBoxCell)dgvEmployees.Rows[e.RowIndex].Cells["colSelect"];
                var current = cell.Value is bool and true;
                cell.Value = !current;
            };


            dgvEmployees.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                if (dgvEmployees.Columns[e.ColumnIndex].Name == "colSelect") return;

                foreach (DataGridViewRow r in dgvEmployees.Rows)
                    r.Cells["colSelect"].Value = false;

                dgvEmployees.Rows[e.RowIndex].Cells["colSelect"].Value = true;
            };

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
            var selectedItem = GetSelectedItem();

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

        private User? GetSelectedItem()
        {
            foreach (DataGridViewRow r in dgvEmployees.Rows)
            {
                var cell = r.Cells["colSelect"];
                var isChecked = false;

                if (cell is DataGridViewCheckBoxCell cb)
                    isChecked = Convert.ToBoolean(cb.EditedFormattedValue ?? cb.Value ?? false);

                if (isChecked)
                    return r.DataBoundItem as User; 
            }

            return dgvEmployees.CurrentRow?.DataBoundItem as User;
        }

        private int FindRowIndexByItem(Item item)
        {
            foreach (DataGridViewRow r in dgvEmployees.Rows)
                if (ReferenceEquals(r.DataBoundItem, item))
                    return r.Index;
            return -1;
        }
    }
}