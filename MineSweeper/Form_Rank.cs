using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form_Rank : Form
    {
        public Form_Rank()
        {
            InitializeComponent();
            this.TextBox_Beginner.Text = string.Format("{0}", Properties.Settings.Default.beginner);              //{0}这个叫做占位符   
            this.TextBox_Importmediate.Text = string.Format("{0}", Properties.Settings.Default.intermediate);
            this.TextBox_Export.Text = string.Format("{0}", Properties.Settings.Default.expert);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.beginner = 999999999;
            Properties.Settings.Default.intermediate = 999999999;
            Properties.Settings.Default.expert = 999999999;
            Properties.Settings.Default.Save();

            this.TextBox_Beginner.Text = "999999999";
            this.TextBox_Importmediate.Text = "999999999";
            this.TextBox_Export.Text = "999999999";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
