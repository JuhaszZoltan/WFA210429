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
    public partial class FrmKereso : Form
    {
        string connectionString;
        public FrmKereso(string cs)
        {
            connectionString = cs;
            InitializeComponent();
        }

        private void FrmKereso_Load(object sender, EventArgs e) =>
            Query(null);

        private void TbKereses_TextChanged(object sender, EventArgs e) =>
            Query(tbKereses.Text);

        public void Query(string keyword)
        {
            dgvKombajnok.Rows.Clear();
            var conn = new SqlConnection(connectionString);
            conn.Open();
            var r = new SqlCommand(
                "SELECT tipus, gyartasiEv, atvevoHely FROM kombajn " +
                $"WHERE tipus LIKE '{keyword}%' " +
                $"ORDER BY gyartasiEv ASC;", conn)
                .ExecuteReader();
            while (r.Read()) dgvKombajnok.Rows.Add(r[0], r[1], r[2]);
            conn.Close();
        }
    }
}
