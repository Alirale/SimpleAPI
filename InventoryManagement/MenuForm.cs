namespace InventoryManagement
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();

            Hide();
            employeeForm.ShowDialog();
            Close();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            var itemsForm = new ItemsForm();
            itemsForm.ShowDialog();

            Hide();
            itemsForm.ShowDialog();
            Close();
        }
    }
}
