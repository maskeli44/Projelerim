using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LokantaProjes3
{
   
        public partial class RaporForm : Form
        {
            public RaporForm(List<string> rapor)
            {
                InitializeComponent();
                listBoxRapor.DataSource = rapor;
            }

            private void RaporForm_Load(object sender, EventArgs e)
            {

            }
        }
    }

