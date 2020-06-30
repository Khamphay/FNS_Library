using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLibrary.MSDialog
{
    public partial class DialogOK : Form
    {
        public DialogOK()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return picIcon.Image; }
            set { picIcon.Image = value; }
        }

        public string Message
        {
            get { return lbMessage.Text; }
            set { lbMessage.Text = value; }
        }
    }
}
