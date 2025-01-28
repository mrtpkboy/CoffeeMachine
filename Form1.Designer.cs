namespace CoffeeMachineApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            cmbDrinkSelection = new ComboBox();
            btnMakeDrink = new Button();
            lblStatus = new Label();
            progressBar = new ProgressBar();
            btnRefill = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 30F);
            textBox1.Location = new Point(206, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 61);
            textBox1.TabIndex = 0;
            textBox1.Text = "เครื่องชงกาแฟอัตโนมัติ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // cmbDrinkSelection
            // 
            cmbDrinkSelection.Font = new Font("Segoe UI", 17F);
            cmbDrinkSelection.FormattingEnabled = true;
            cmbDrinkSelection.Location = new Point(190, 106);
            cmbDrinkSelection.Name = "cmbDrinkSelection";
            cmbDrinkSelection.Size = new Size(200, 39);
            cmbDrinkSelection.TabIndex = 1;
            cmbDrinkSelection.SelectedIndexChanged += cmbDrinkSelection_SelectedIndexChanged;
            // 
            // btnMakeDrink
            // 
            btnMakeDrink.Font = new Font("Segoe UI", 17F);
            btnMakeDrink.Location = new Point(419, 105);
            btnMakeDrink.Name = "btnMakeDrink";
            btnMakeDrink.Size = new Size(159, 39);
            btnMakeDrink.TabIndex = 2;
            btnMakeDrink.Text = "☕ ชงเครื่องดื่ม";
            btnMakeDrink.UseVisualStyleBackColor = true;
            btnMakeDrink.Click += btnMakeDrink_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 20F);
            lblStatus.Location = new Point(190, 165);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(176, 37);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "สถานะ: รอคำสั่ง";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(190, 222);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(305, 40);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 4;
            progressBar.Click += progressBar_Click_1;
            // 
            // btnRefill
            // 
            btnRefill.Font = new Font("Segoe UI", 20F);
            btnRefill.Location = new Point(190, 287);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(172, 54);
            btnRefill.TabIndex = 5;
            btnRefill.Text = "เติมวัตถุดิบ";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefill);
            Controls.Add(progressBar);
            Controls.Add(lblStatus);
            Controls.Add(btnMakeDrink);
            Controls.Add(cmbDrinkSelection);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox cmbDrinkSelection;
        private Button btnMakeDrink;
        private Label lblStatus;
        private ProgressBar progressBar;
        private Button btnRefill;
    }
}
