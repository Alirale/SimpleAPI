namespace InventoryManagement
{
    partial class InventoryManagement
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnLogin;
        private TextBox txtboxPassword;
        private TextBox txtboxUserName;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtboxPassword = new TextBox();
            txtboxUserName = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelHeader = new Panel();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(150, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "ورود";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Font = new Font("Segoe UI", 10F);
            txtboxPassword.Location = new Point(150, 147);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.PasswordChar = '●';
            txtboxPassword.Size = new Size(200, 25);
            txtboxPassword.TabIndex = 4;
            // 
            // txtboxUserName
            // 
            txtboxUserName.Font = new Font("Segoe UI", 10F);
            txtboxUserName.Location = new Point(150, 107);
            txtboxUserName.Name = "txtboxUserName";
            txtboxUserName.Size = new Size(200, 25);
            txtboxUserName.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F);
            lblUserName.Location = new Point(60, 110);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(71, 19);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "نام کاربری:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(60, 150);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(61, 19);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "رمز عبور:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(258, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory Management";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.WhiteSmoke;
            lblSubtitle.Location = new Point(22, 40);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(245, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "نرم افزار جامع مدیریت انبار داری نسخه 1";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(461, 70);
            panelHeader.TabIndex = 0;
            // 
            // InventoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(461, 317);
            Controls.Add(panelHeader);
            Controls.Add(lblUserName);
            Controls.Add(txtboxUserName);
            Controls.Add(lblPassword);
            Controls.Add(txtboxPassword);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InventoryManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود به سیستم مدیریت انبار";
            Load += LoginForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
