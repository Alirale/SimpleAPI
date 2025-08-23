namespace InventoryManagement
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtboxPassword = new TextBox();
            txtboxUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(185, 168);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Location = new Point(136, 123);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(195, 23);
            txtboxPassword.TabIndex = 1;
            // 
            // txtboxUserName
            // 
            txtboxUserName.Location = new Point(136, 83);
            txtboxUserName.Name = "txtboxUserName";
            txtboxUserName.Size = new Size(195, 23);
            txtboxUserName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 86);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 3;
            label1.Text = "UserName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 131);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Password :";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 296);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtboxUserName);
            Controls.Add(txtboxPassword);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtboxPassword;
        private TextBox txtboxUserName;
        private Label label1;
        private Label label2;
    }
}