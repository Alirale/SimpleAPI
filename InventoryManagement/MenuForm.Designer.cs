namespace InventoryManagement
{
    partial class MenuForm
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
            btnEmloyees = new Button();
            btnItems = new Button();
            SuspendLayout();
            // 
            // btnEmloyees
            // 
            btnEmloyees.Location = new Point(103, 54);
            btnEmloyees.Name = "btnEmloyees";
            btnEmloyees.Size = new Size(75, 23);
            btnEmloyees.TabIndex = 0;
            btnEmloyees.Text = "Employees";
            btnEmloyees.UseVisualStyleBackColor = true;
            btnEmloyees.Click += button1_Click;
            // 
            // btnItems
            // 
            btnItems.Location = new Point(103, 97);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(75, 23);
            btnItems.TabIndex = 1;
            btnItems.Text = "Items";
            btnItems.UseVisualStyleBackColor = true;
            btnItems.Click += btnItems_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 188);
            Controls.Add(btnItems);
            Controls.Add(btnEmloyees);
            Name = "MenuForm";
            Text = "Menu Form";
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmloyees;
        private Button btnItems;
    }
}