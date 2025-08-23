using Domain.Entities;
using Domain.Enums;
using System.ComponentModel;

namespace InventoryManagement
{
    public partial class ItemsForm : Form
    {
        private readonly BindingList<Item> _view = new();
        private readonly BindingSource _bs = new();


        public ItemsForm()
        {
            InitializeComponent();
            dgvItems.AutoGenerateColumns = false;
            dgvItems.Columns.Clear();


            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "شناسه",
                Width = 70,
                FillWeight = 10
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

            _bs.DataSource = _view;  
            dgvItems.DataSource = _bs;
            dgvItems.CellFormatting += dgvEmployees_CellFormatting;
        }
        private void ItemsForm_Load(object sender, EventArgs e)
        {
            var sampleItems = new List<Item>
            {
                new Item { Id = 1,  Name = "تی‌شرت مردانه",         Category = CategoryType.Clothes,         Description = "نخی، سایز L",             UnitPrice = 350_000m },
                new Item { Id = 2,  Name = "شلوار جین",             Category = CategoryType.Clothes,         Description = "آبی تیره",                 UnitPrice = 950_000m },
                new Item { Id = 3,  Name = "گوشی هوشمند",           Category = CategoryType.Electronics,     Description = "128GB، دو سیم‌کارت",       UnitPrice = 18_500_000m },
                new Item { Id = 4,  Name = "هدفون بی‌سیم",          Category = CategoryType.Electronics,     Description = "بلوتوث 5.3",               UnitPrice = 2_300_000m },
                new Item { Id = 5,  Name = "برنج هاشمی 10 کیلویی",  Category = CategoryType.Food,            Description = "عطرمحلی",                  UnitPrice = 1_980_000m },
                new Item { Id = 6,  Name = "روغن زیتون 1 لیتری",    Category = CategoryType.Food,            Description = "فرابکر",                   UnitPrice = 520_000m },
                new Item { Id = 7,  Name = "صندلی اداری",           Category = CategoryType.Furniture,       Description = "ارگونومیک، مش",            UnitPrice = 4_200_000m },
                new Item { Id = 8,  Name = "میز تحریر",             Category = CategoryType.Furniture,       Description = "120×60 ام‌دی‌اف",          UnitPrice = 3_100_000m },
                new Item { Id = 9,  Name = "دفتر 100 برگ",          Category = CategoryType.Stationery,      Description = "خط‌دار",                   UnitPrice = 45_000m },
                new Item { Id = 10, Name = "خودکار آبی",            Category = CategoryType.Stationery,      Description = "نوک 0.7",                  UnitPrice = 18_000m },
                new Item { Id = 11, Name = "آچار فرانسه",           Category = CategoryType.Tools,           Description = "10 اینچ",                  UnitPrice = 270_000m },
                new Item { Id = 12, Name = "دریل برقی",             Category = CategoryType.Tools,           Description = "600 وات",                  UnitPrice = 2_150_000m },
                new Item { Id = 13, Name = "لِگو 500 تکه",          Category = CategoryType.Toys,            Description = "مناسب 6+",                 UnitPrice = 1_350_000m },
                new Item { Id = 14, Name = "کتاب برنامه‌نویسی C#",  Category = CategoryType.Books,           Description = "چاپ 1403",                 UnitPrice = 420_000m },
                new Item { Id = 15, Name = "توپ فوتبال",            Category = CategoryType.Sports,          Description = "سایز 5",                   UnitPrice = 380_000m },
                new Item { Id = 16, Name = "سشوار خانگی",           Category = CategoryType.HomeAppliances,  Description = "2000 وات",                 UnitPrice = 1_150_000m },
                new Item { Id = 17, Name = "عینک آفتابی",           Category = CategoryType.Accessories,     Description = "UV400",                    UnitPrice = 620_000m },
                new Item { Id = 18, Name = "کِرِم مرطوب‌کننده",     Category = CategoryType.Beauty,          Description = "پوست خشک",                 UnitPrice = 210_000m },
                new Item { Id = 19, Name = "تب‌سنج دیجیتال",        Category = CategoryType.Medicine,        Description = "غیری پزشکی (OTC)",        UnitPrice = 290_000m }
            };
            _view.Clear();
            foreach (var it in sampleItems) _view.Add(it);

            _bs.DataSource = _view;
            dgvItems.DataSource = _bs;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

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

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
