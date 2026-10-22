using Microsoft.VisualBasic;

namespace WFA_feladat6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            label6.Text =
                 (textbox2.Value <= textbox3.Value && textbox3.Value<=textbox1.Value  ) 
                 ? "Benne van az intervallumban"
                 : "Nincs benne az intervallumban";
        }
        

            }
}
