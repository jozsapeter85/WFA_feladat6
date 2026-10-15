using Microsoft.VisualBasic;

namespace WFA_feladat6
{
    public partial class Form1 : Form
    {
        public int op1;
        public int op2;
        public int op3;
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            bool vane = false;
            if (!isconvertible() || op1 >= op2) 
            {
                MessageBox.Show(
                    icon:MessageBoxIcon.Error,
                    caption:"HIBA",
                    text: "Invalid érték",
                    buttons: MessageBoxButtons.OK
                    );
            }
            
            else 
            {
                for (int i = op1; i < op2; i++) 
                {
                    if (op3 == i) 
                    {
                        vane = true;
                    }
                }
                if (vane==true) { label6.Text = "Benne van az intervallumban."; }
                else { label6.Text = "Nincs benne az intervallumban"; }
            }
        }

        public bool isconvertible()
            => int.TryParse(textBox2.Text, out op1) && int.TryParse(textBox1.Text, out op2) && int.TryParse(textBox3.Text, out op3);
    }
}
