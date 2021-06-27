using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMORPG
{
    public partial class LogInForm : Form
    {
        PrivateFontCollection fontCollection;
        public LogInForm(PrivateFontCollection fColl)
        {
            InitializeComponent();
            fontCollection = fColl;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            label1.Font = new Font(fontCollection.Families[0], 28);
            label2.Font = new Font(fontCollection.Families[0], 28);
            label3.Font = new Font(fontCollection.Families[1], 40, FontStyle.Bold);
            EnterButton.Font = new Font(fontCollection.Families[1], 22, FontStyle.Bold);
            exitButton.Font = new Font(fontCollection.Families[1], 17, FontStyle.Bold);
        }
    }
}
