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

namespace WFA210429
{
    public partial class FrmKinalat : Form
    {
        public string connectionString =
            @"Server = (localdb)\MSSQLLocalDB;" +
            @"Database = hasznaltkombajn;";

        public FrmKinalat()
        {
            InitializeComponent();
        }

        private void FrmKinalat_Load(object sender, EventArgs e)
        {
            LoadDb();
        }

        private void tsmiKereses_Click(object sender, EventArgs e)
        {
            var frm = new FrmKereso(connectionString);
            frm.ShowDialog();
            LoadDb();
        }

        private void DgvKinalat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvKinalat.Rows[e.RowIndex].Cells[0].Value.ToString();
            var frm = new FrmKombajn(connectionString, id);
            frm.ShowDialog();
            LoadDb();
        }

        private void LoadDb()
        {
            dgvKinalat.Rows.Clear();

            var conn = new SqlConnection(connectionString);
            conn.Open();

            var r = new SqlCommand(
                "SELECT kombajn.id, tipus, gyartasiEv, iranyAr, telefonszam, atvevoHely " +
                "FROM tulajdonos INNER JOIN kombajn ON tulajdonosId = tulajdonos.Id;",
                conn).ExecuteReader();

            while (r.Read())
            {
                dgvKinalat.Rows.Add(
                    r[0], r[1], r[2],
                    (r[3] is Int32)
                        ? string.Format("{0:N0} HUF", r.GetInt32(3) * 1.27F)
                        : "nincs megadva",
                    r[4], r[5]);

                //var tomb = new object[5];
                //r.GetValues(tomb);
                //dgvKinalat.Rows.Add(tomb);
            }
            conn.Close();
        }

        private void TsmiKombajn_Click(object sender, EventArgs e)
        {
            var frm = new FrmKombajn(connectionString);
            frm.ShowDialog();
            LoadDb();
        }
    }
}
