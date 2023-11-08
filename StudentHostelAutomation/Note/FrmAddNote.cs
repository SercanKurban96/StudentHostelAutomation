using StudentHostelAutomation.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentHostelAutomation.Note
{
    public partial class FrmAddNote : Form
    {
        public FrmAddNote()
        {
            InitializeComponent();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAdminPanel fr = new FrmAdminPanel();
            fr.Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (RchNote.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.noteklemebos, RchNote.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RchNote.Focus();
                }
                else
                {
                    saveFileDialog1.Title = Localization.kayityerisecin;
                    saveFileDialog1.Filter = "Metin Dosyası | *.txt";
                    //saveFileDialog1.InitialDirectory = "C:\\Desktop";
                    saveFileDialog1.ShowDialog();
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.WriteLine(RchNote.Text);
                    sw.Close();
                    MessageBox.Show(String.Format(Localization.notkaydedildi, RchNote.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RchNote.Clear();
                    RchNote.Focus();
                }
            }
            catch (Exception)
            {

            }  
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            RchNote.Clear();
            RchNote.Focus();
        }

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }

        private void FrmAddNote_Load(object sender, EventArgs e)
        {
            lbladdnote.Text = Localization.lbladdnote;
            BtnAdd.Text = Localization.BtnAdd;
            BtnCancel.Text = Localization.BtnCancel;
        }
    }
}
