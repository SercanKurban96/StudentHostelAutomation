using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHostelAutomation.Employee
{
    public partial class FrmListEmployee : Form
    {
        public FrmListEmployee()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgEmployee.DataSource = ds.Tables[0];
        }
        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TBLEMPLOYEE", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblEmployeeCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
        }
        private void FrmListEmployee_Load(object sender, EventArgs e)
        {
            verilerigoster("select EmployeeID as 'ID',EmployeeTRNumber as 'T.C. No',EmployeeName as 'Personel Adı',EmployeeSurname as 'Personel Soyadı',EmployeeDepartment as 'Görevi' from TBLEMPLOYEE");
            kayitsayisi();

            lblpersonelsayisi.Text = Localization.lblpersonelsayisi;
            lblemployeelist.Text = Localization.lblemployeelist;
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }

        private void lblemployeelist_Click(object sender, EventArgs e)
        {

        }
    }
}
