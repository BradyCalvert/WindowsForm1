using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wintest1
{
    public partial class formGideon : Form
    {
        public formGideon()
        {
            InitializeComponent();
        }

        private void formGideon_Load(object sender, EventArgs e)
        {
            this.drpYear.DisplayMember = "Text";
            this.drpYear.ValueMember = "Value";
            var items = new[] {
             new { Text = "January", Value = 1 },
             new { Text = "Feb", Value = 2 },
             new { Text = "MArch", Value = 3 }};
            this.drpYear.DataSource = items;

            // add your code here

            // I am binding two handlers to button B
            this.buttonB.Click += new System.EventHandler(this.formControlClicked);
            this.buttonB.Click += new System.EventHandler(this.vancesMethod);
        }
        private void buttonA_Click(object sender, EventArgs e)
        {
            //labelTyler.Text = labelTyler.Text == "Tyler" ? "Gage" : "Tyler";
            labelTyler.Text = nameEntry.Text;
        }

        /// <summary>
        /// add years from todays year and get the text from whichever control hits this method and change the form title with that text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vancesMethod(object sender, EventArgs e)
        {
            
            DateTime dt = DateTime.Now;
            int thisYear = dt.Year;
            for (int x = thisYear; x <= thisYear + 3; x++)
            {
                MessageBox.Show("howdy", x.ToString(), MessageBoxButtons.YesNoCancel);
            }

            // >>>>>>>>  Notice that I cast to the generic Control object so I can get the Text of any Windows control  <<<<<<<<<<<<<
            var t = (Control)sender;
            var myForm = t.Parent;
            myForm.Text = t.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameEntry_TextChanged(object sender, EventArgs e)
        {
            labelTyler.Text = nameEntry.Text;
            string[] words = nameEntry.Text.Split(' ');
            wordCount.Text = words.Count().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formControlClicked(object sender, EventArgs e)
        {

            MessageBox.Show("The selected Month is" + this.drpYear.SelectedValue.ToString());
        }

        /// <summary>
        /// Change the color of button A based on whether the box is checked or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeButtonAColor(object sender, EventArgs e)
        {
            var bx = (CheckBox)sender;
            if(bx.Checked)
            {
                this.buttonA.ForeColor = Color.BlueViolet;
            } else
            {
                this.buttonA.ForeColor = Color.Chartreuse;
            }
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

    private void labelTyler_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
