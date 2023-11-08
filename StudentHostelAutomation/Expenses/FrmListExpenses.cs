using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentHostelAutomation.Expenses
{
    public partial class FrmListExpenses : Form
    {
        public FrmListExpenses()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();

        private void PctBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgExpenses.DataSource = ds.Tables[0];
        }
        private void FrmListExpenses_Load(object sender, EventArgs e)
        {
            verilerigoster("select ExpenseID as 'ID', Electrical as 'Elektrik',Water as 'Su',NaturalGas as 'Doğalgaz',Internet as 'İnternet',Food as 'Gıda', Employee as 'Personel', Other as 'Diğer' from TBLEXPENSE");

            lblexpenseslist.Text = Localization.lblexpenseslist;
        }

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }

        private void lblexpenseslist_Click(object sender, EventArgs e)
        {

        }
    }
}
