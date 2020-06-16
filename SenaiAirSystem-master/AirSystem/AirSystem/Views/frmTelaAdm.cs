using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmTelaAdm : Form
    {
        public frmTelaAdm()
        {
            InitializeComponent();
        }

        string idioma = "";
        public frmTelaAdm(string idioma)
        {
            InitializeComponent();

            if (idioma == "Inglês")
            {
                this.idioma = idioma;

                button1.Text = "List User";
                button2.Text = "List Planes";
                button3.Text = "Manage Company";
                button4.Text = "Manage Reports";
                button5.Text = "Manage Planes";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idioma != "Inglês")
            {
                frmListarUsuarios frm = new frmListarUsuarios();
                frm.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                frmListarUsuarios frm = new frmListarUsuarios(idioma);
                frm.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
