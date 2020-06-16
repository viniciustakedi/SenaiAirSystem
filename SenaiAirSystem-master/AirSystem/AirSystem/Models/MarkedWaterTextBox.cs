using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class MarkedWaterTextBox : TextBox
    {
        public MarkedWaterTextBox()
        {
            InitializeComponent();
        }

        private string _watermarktext;
        //private bool _multiline = false;

        public string WaterMarkText
        {
            get { return _watermarktext; }
            set 
            { 
                _watermarktext = value;
                GetSetWaterMark();
            }
        }

        //[Browsable(false)]
        //public new bool Multiline
        //{
        //    get { return _multiline; }
        //    set { _multiline = false; }
        //}

        private void GetSetWaterMark()
        {
            if ((this.Text == WaterMarkText) || (this.Text == string.Empty))
            {
                this.ForeColor = Color.Gray;
                this.Text = WaterMarkText;
            }
            else
            {
                this.ForeColor = Color.Black;
            }
        }

        private void MarkedWaterTextBox_Enter(object sender, EventArgs e)
        {
            if ((this.Text == WaterMarkText) || (this.Text == string.Empty))
            {
                this.Text = string.Empty;
                this.ForeColor = Color.Black;
            }
            //if (this.Text == WaterMarkText)
            //{
            //    this.Text = "";
            //    this.ForeColor = Color.Black;
            //}
        }

        private void MarkedWaterTextBox_Leave(object sender, EventArgs e)
        {
            GetSetWaterMark();

            //if (this.Text == "")
            //{
            //    this.Text = WaterMarkText;
            //    this.ForeColor = Color.Gray;
            //}
        }
    }
}
