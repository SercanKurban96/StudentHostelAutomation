using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHostelAutomation
{
    public partial class FrmLanguage : Form
    {
        public FrmLanguage()
        {
            InitializeComponent();
        }

        private void PctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PctExit_MouseHover(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Red;
        }

        private void PctExit_MouseLeave(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Transparent;
        }

        private void pctturkce_Click(object sender, EventArgs e)
        {
            rdbturkce.Checked = true;
        }

        private void pctingilizce_Click(object sender, EventArgs e)
        {
            rdbingilizce.Checked = true;
        }

        private void pctalmanca_Click(object sender, EventArgs e)
        {
            rdbalmanca.Checked = true;
        }

        private void pctispanyolca_Click(object sender, EventArgs e)
        {
            rdbispanyolca.Checked = true;
        }

        private void pctfransizca_Click(object sender, EventArgs e)
        {
            rdbfransizca.Checked = true;
        }

        private void pctitalyanca_Click(object sender, EventArgs e)
        {
            rdbitalyanca.Checked = true;
        }

        private void pctrusca_Click(object sender, EventArgs e)
        {
            rdbrusca.Checked = true;
        }

        private void pctjaponca_Click(object sender, EventArgs e)
        {
            rdbjaponca.Checked = true;
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            if (rdbturkce.Checked)
            {
                Localization.Culture = new CultureInfo("");
            }
            else if (rdbingilizce.Checked)
            {
                Localization.Culture = new CultureInfo("en-US");
            }
            else if (rdbalmanca.Checked)
            {
                Localization.Culture = new CultureInfo("de-DE");
            }
            else if (rdbispanyolca.Checked)
            {
                Localization.Culture = new CultureInfo("es-ES");
            }
            else if (rdbfransizca.Checked)
            {
                Localization.Culture = new CultureInfo("fr-FR");
            }
            else if (rdbitalyanca.Checked)
            {
                Localization.Culture = new CultureInfo("it-IT");
            }
            else if (rdbrusca.Checked)
            {
                Localization.Culture = new CultureInfo("ru-RU");
            }
            else if (rdbjaponca.Checked)
            {
                Localization.Culture = new CultureInfo("ja-JP");
            }
            FrmLoading fr = new FrmLoading();
            fr.Show();
            this.Hide();
        }
    }
}
