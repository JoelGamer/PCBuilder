using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectPCBuilder0506
{
    public partial class frmLojaServer : Form
    {
        string usr;

        public frmLojaServer(string user)
        {
            InitializeComponent();
            string User = user.ToString();
            usr = User;
        }
    }
}
