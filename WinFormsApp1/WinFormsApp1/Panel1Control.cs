using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Panel1Control : UserControl
    {
        public Panel1Control()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            var Panel1Control = this.Inputone_textbox.Text;
            var Panel2Control = this.InputTwo_textbox.Text;

            //parent 

            var parent = this.Parent as Form1;

            parent.Input1 = Panel1Control;
            parent.input = Panel2Control;
        }
    }
}
