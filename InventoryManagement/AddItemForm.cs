using System.Text;
using System.Text.Json;
using Domain.Enums;

namespace InventoryManagement
{
    public partial class AddItemForm : Form
    {
        private readonly HttpClient _http;
        public AddItemForm(HttpClient http)
        {
            InitializeComponent();
            _http = http;

            cmbCategory.Items.Clear();
            foreach (CategoryType ct in Enum.GetValues(typeof(CategoryType)))
            {
                cmbCategory.Items.Add(ToFa(ct));
            }
            cmbCategory.SelectedIndex = 0;
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var req = new
                {
                    name = txtName.Text.Trim(),
                    category = FromFa(cmbCategory.SelectedItem?.ToString()).ToString() ?? "Others",
                    description = txtDescription.Text.Trim(),
                    unitPrice = numPrice.Value,
                    quantity = (int)numQuantity.Value
                };

                var json = JsonSerializer.Serialize(req);
                using var content = new StringContent(json, Encoding.UTF8, "application/json");

                var resp = await _http.PostAsync("http://localhost:5000/Items/v1/Create", content);
                resp.EnsureSuccessStatusCode();

                MessageBox.Show("محصول با موفقیت افزوده شد.", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string ToFa(CategoryType ct) => ct switch
        {
            CategoryType.Clothes => "پوشاک",
            CategoryType.Electronics => "لوازم الکترونیکی",
            CategoryType.Food => "مواد غذایی",
            CategoryType.Furniture => "مبلمان",
            CategoryType.Stationery => "لوازم‌التحریر",
            CategoryType.Tools => "ابزارها",
            CategoryType.Toys => "اسباب‌بازی‌ها",
            CategoryType.Books => "کتاب‌ها",
            CategoryType.Sports => "ورزش",
            CategoryType.Beauty => "زیبایی",
            CategoryType.Medicine => "دارو",
            CategoryType.Accessories => "لوازم جانبی",
            CategoryType.Vehicles => "وسایل نقلیه",
            CategoryType.HomeAppliances => "لوازم خانگی",
            CategoryType.Others => "سایر موارد",
            _ => ct.ToString()
        };
        private static CategoryType FromFa(string fa) => fa switch
        {
            "پوشاک" => CategoryType.Clothes,
            "لوازم الکترونیکی" => CategoryType.Electronics,
            "مواد غذایی" => CategoryType.Food,
            "مبلمان" => CategoryType.Furniture,
            "لوازم‌التحریر" => CategoryType.Stationery,
            "ابزارها" => CategoryType.Tools,
            "اسباب‌بازی‌ها" => CategoryType.Toys,
            "کتاب‌ها" => CategoryType.Books,
            "ورزش" => CategoryType.Sports,
            "زیبایی" => CategoryType.Beauty,
            "دارو" => CategoryType.Medicine,
            "لوازم جانبی" => CategoryType.Accessories,
            "وسایل نقلیه" => CategoryType.Vehicles,
            "لوازم خانگی" => CategoryType.HomeAppliances,
            "سایر موارد" => CategoryType.Others,
            _ => CategoryType.Others
        };
    }
}
