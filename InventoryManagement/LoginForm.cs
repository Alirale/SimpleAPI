using System.Text;
using System.Text.Json;

namespace InventoryManagement
{
    public partial class LoginForm : Form
    {
        private readonly HttpClient _http = new HttpClient();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtboxUserName.Text.Trim();
                var password = txtboxPassword.Text.Trim();

                var response = await DoLoginAsync(username, password);

                if (response is { Succeeded: true })
                {
                    MessageBox.Show("خوش آمدید!", "ورود موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();
                    var itemsForm = new ItemsForm();
                    itemsForm.ShowDialog();
                    Close();
                }
                else
                {
                    var error = response?.Errors?.FirstOrDefault() ?? "نام کاربری یا رمز عبور اشتباه است.";
                    MessageBox.Show(error, "خطا در ورود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<LoginResponse?> DoLoginAsync(string username, string password)
        {
            var req = new LoginRequest
            {
                UserName = username,
                Password = password
            };

            var json = JsonSerializer.Serialize(req);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = await _http.PostAsync("http://localhost:5000/Authorization/v1/Login", content);
            resp.EnsureSuccessStatusCode();

            var respJson = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<LoginResponse>(respJson, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
