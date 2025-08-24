using Domain.Entities;
using Domain.Enums;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryManagement
{
    public partial class ItemsForm : Form
    {
        private readonly BindingList<ItemView> _view = new();
        private readonly BindingSource _bs = new();

        public ItemsForm()
        {
            InitializeComponent();
            dgvItems.AutoGenerateColumns = false;
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Columns.Clear();

            dgvItems.Columns.Insert(0, new DataGridViewCheckBoxColumn
            {
                Name = "colSelect",
                HeaderText = "انتخاب",
                Width = 60,
                FillWeight = 30
            });

            dgvItems.RowHeadersVisible = false;

            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                DataPropertyName = "Id",
                HeaderText = "شناسه",
                Width = 70,
                ReadOnly = true,
                FillWeight = 30
            });


            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "نام کالا",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });


            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "دسته‌بندی"
            });


            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "توضیحات",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });


            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText = "قیمت واحد",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                HeaderText = "تاریخ ایجاد",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy/MM/dd HH:mm" },
                Width = 140
            });

            dgvItems.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvItems.IsCurrentCellDirty)
                    dgvItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            dgvItems.CellContentClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                if (dgvItems.Columns[e.ColumnIndex].Name != "colSelect") return;

                foreach (DataGridViewRow r in dgvItems.Rows)
                    if (r.Index != e.RowIndex)
                        r.Cells["colSelect"].Value = false;

                var cell = (DataGridViewCheckBoxCell)dgvItems.Rows[e.RowIndex].Cells["colSelect"];
                var current = cell.Value is true;
                cell.Value = !current;
            };


            dgvItems.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                if (dgvItems.Columns[e.ColumnIndex].Name == "colSelect") return;

                foreach (DataGridViewRow r in dgvItems.Rows)
                    r.Cells["colSelect"].Value = false;

                dgvItems.Rows[e.RowIndex].Cells["colSelect"].Value = true;
            };

            _bs.DataSource = _view;
            dgvItems.DataSource = _bs;
            dgvItems.CellFormatting += dgvEmployees_CellFormatting;
        }
        private async void ItemsForm_Load(object sender, EventArgs e)
        {
            try
            {
                var items = await LoadItemsFromApiAsync();
                _view.Clear();

                foreach (var it in items)
                {
                    _view.Add(new ItemView
                    {
                        Id = it.Id,
                        Name = it.Name,
                        Category = ToFa(it.Category),
                        Description = it.Description,
                        UnitPrice = it.UnitPrice,
                        Quantity = it.Quantity,
                        CreatedAt = it.CreatedAt
                    });
                }

                _bs.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا");
            }
        }

        private async Task<List<ApiItemDto>> LoadItemsFromApiAsync()
        {
            try
            {
                var req = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5000/Items/v1/Search");

                req.Headers.Accept.Clear();
                req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));

                using var resp = await _http.SendAsync(req);
                resp.EnsureSuccessStatusCode();

                var json = await resp.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<List<ApiItemDto>>(json, _jsonOptions) ?? new();
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var name = txtSearch.Text?.Trim();
                var category = comboBox1.SelectedItem is not null? FromFa(comboBox1.SelectedItem?.ToString()).ToString() : null;

                var items = await SearchItemsFromApiAsync(name, category);

                _view.Clear();
                foreach (var it in items)
                {
                    _view.Add(new ItemView
                    {
                        Id = it.Id,
                        Name = it.Name,
                        Category = ToFa(it.Category),
                        Description = it.Description,
                        UnitPrice = it.UnitPrice,
                        Quantity = it.Quantity,
                        CreatedAt = it.CreatedAt
                    });
                }
                _bs.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در جستجو");
            }
            comboBox1.SelectedItem = null;
        }

        private async Task<List<ApiItemDto>> SearchItemsFromApiAsync(string? name, string? category)
        {
            var url = "http://localhost:5000/Items/v1/Search";

            var query = new List<string>();
            if (!string.IsNullOrWhiteSpace(name))
                query.Add($"Name={Uri.EscapeDataString(name)}");

            if (!string.IsNullOrWhiteSpace(category))
                query.Add($"Category={Uri.EscapeDataString(category)}");

            if (query.Count > 0)
                url += "?" + string.Join("&", query);

            using var req = new HttpRequestMessage(HttpMethod.Get, url);
            req.Headers.Accept.Clear();
            req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using var resp = await _http.SendAsync(req);
            resp.EnsureSuccessStatusCode();

            var json = await resp.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<List<ApiItemDto>>(json, _jsonOptions) ?? new();
            return data;
        }


        private void dgvEmployees_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvItems.Columns[e.ColumnIndex].Name == "colFullName")
            {
                if (_bs[e.RowIndex] is User row)
                    e.Value = $"{row.FirstName} {row.LastName}".Trim();
                e.FormattingApplied = true;
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            using var addForm = new AddItemForm(_http);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                var items = await LoadItemsFromApiAsync();
                _view.Clear();
                foreach (var it in items)
                {
                    _view.Add(new ItemView
                    {
                        Id = it.Id,
                        Name = it.Name,
                        Category = ToFa(it.Category),
                        Description = it.Description,
                        UnitPrice = it.UnitPrice,
                        Quantity = it.Quantity,
                        CreatedAt = it.CreatedAt
                    });
                }
                _bs.ResetBindings(false);
            }
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedItem();
            if (selected == null)
            {
                MessageBox.Show("هیچ ردیفی انتخاب نشده.", "ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var editForm = new EditForm(_http, selected);
            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                var items = await LoadItemsFromApiAsync();
                _view.Clear();
                foreach (var it in items)
                {
                    _view.Add(new ItemView
                    {
                        Id = it.Id,
                        Name = it.Name,
                        Category = ToFa(it.Category),
                        Description = it.Description,
                        UnitPrice = it.UnitPrice,
                        Quantity = it.Quantity,
                        CreatedAt = it.CreatedAt
                    });
                }
                _bs.ResetBindings(false);
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        { 
            var selected = GetSelectedItem();
            if (selected == null)
            {
                MessageBox.Show("هیچ ردیفی انتخاب نشده.", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"«{selected.Name}» حذف شود؟", "تأیید حذف",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var url = $"http://localhost:5000/Items/v1/Delete?id={selected.Id}";
                using var resp = await _http.DeleteAsync(url);
                resp.EnsureSuccessStatusCode();

                MessageBox.Show("محصول با موفقیت حذف شد.", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var items = await LoadItemsFromApiAsync();
                _view.Clear();
                foreach (var it in items)
                {
                    _view.Add(new ItemView()
                    {
                        Id = it.Id,
                        Name = it.Name,
                        Category = ToFa(it.Category),
                        Description = it.Description,
                        UnitPrice = it.UnitPrice,
                        Quantity = it.Quantity,
                        CreatedAt = it.CreatedAt
                    });
                }
                _bs.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در حذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private ItemView? GetSelectedItem()
        {
            foreach (DataGridViewRow r in dgvItems.Rows)
            {
                var c = r.Cells["colSelect"];
                bool isChecked = false;
                if (c is DataGridViewCheckBoxCell cb)
                    isChecked = Convert.ToBoolean(cb.EditedFormattedValue ?? cb.Value ?? false);

                if (isChecked)
                    return r.DataBoundItem as ItemView;
            }
            return dgvItems.CurrentRow?.DataBoundItem as ItemView;
        }

        public static string ToFa(CategoryType ct) => ct switch
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

        public static CategoryType FromFa(string fa) => fa switch
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

        private static readonly HttpClient _http = new()
        {
            BaseAddress = new Uri("http://localhost:5000/")
        };

        private static readonly JsonSerializerOptions _jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
        };
    }
}