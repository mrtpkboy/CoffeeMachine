using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoffeeMachineApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, (int Water, int Coffee, int Milk, int Chocolate)> drinks = new Dictionary<string, (int, int, int, int)>()
        {
            { "กาแฟดำ", (300, 20, 0, 0) },
            { "มอคค่า", (300, 20, 0, 10) },
            { "ลาเต้", (300, 20, 10, 0) },
            { "ช็อคโกแลต", (300, 0, 0, 20) }
        };

        private int water = 1000;
        private int coffee = 100;
        private int milk = 50;
        private int chocolate = 50;

        public Form1()
        {
            InitializeComponent();
            
            cmbDrinkSelection.Items.AddRange(new string[] { "กาแฟดำ", "มอคค่า", "ลาเต้", "ช็อคโกแลต" });
            cmbDrinkSelection.SelectedIndex = 0; 
        }

        private void btnMakeDrink_Click(object sender, EventArgs e)
        {
            string selectedDrink = cmbDrinkSelection.SelectedItem?.ToString() ?? ""; 
            if (string.IsNullOrEmpty(selectedDrink))
            {
                MessageBox.Show("กรุณาเลือกเครื่องดื่ม!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ingredients = drinks[selectedDrink];

            
            if (water >= ingredients.Water && coffee >= ingredients.Coffee && milk >= ingredients.Milk && chocolate >= ingredients.Chocolate)
            {
                
                water -= ingredients.Water;
                coffee -= ingredients.Coffee;
                milk -= ingredients.Milk;
                chocolate -= ingredients.Chocolate;

                
                lblStatus.Text = $"กำลังชง {selectedDrink}...";
                progressBar.Style = ProgressBarStyle.Marquee; 
                progressBar.MarqueeAnimationSpeed = 30;

                
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 2000; 
                timer.Tick += (s, ev) =>
                {
                    lblStatus.Text = $"{selectedDrink} พร้อมเสิร์ฟ!";
                    progressBar.Style = ProgressBarStyle.Blocks; 
                    progressBar.Value = 0;
                    timer.Stop();
                };
                timer.Start();
            }
            else
            {
                lblStatus.Text = "วัตถุดิบไม่เพียงพอ! กรุณาเติมวัตถุดิบ";
            }
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            
            water= 1000;
            coffee = 100;
            milk = 50;
            chocolate = 50;

            lblStatus.Text = "เติมวัตถุดิบเรียบร้อยแล้ว";
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbDrinkSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
