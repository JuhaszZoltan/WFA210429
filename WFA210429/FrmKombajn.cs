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
    public partial class FrmKombajn : Form
    {
        string connectionString;
        const int tulajdonosId = 1;
        string iranyAr = "null";

        public FrmKombajn(string cs)
        {
            connectionString = cs;
            InitializeComponent();

            tbTipus.Enabled = true;
            tbEv.Enabled = true;
            btnUj.Enabled = true;
            cbTulajok.Enabled = true;

            lblTulaj.Visible = true;
            cbTulajok.Visible = true;

            FillCb();
        }

        private void FillCb()
        {
            var conn = new SqlConnection(connectionString);
            conn.Open();

            var r = new SqlCommand(
                $"SELECT nev FROM tulajdonos;", conn)
                .ExecuteReader();

            while(r.Read())
            {
                cbTulajok.Items.Add(r[0]);
            }

            conn.Close();
            cbTulajok.SelectedIndex = 0;
        }

        public FrmKombajn(string cs, string id)
        {
            connectionString = cs;
            InitializeComponent();

            tbId.Text = id;
            btnMod.Enabled = true;
            btnDel.Enabled = true;

            FillFieldsQuery();
        }

        private void FillFieldsQuery()
        {
            var conn = new SqlConnection(connectionString);
            conn.Open();

            var r = new SqlCommand(
                $"SELECT * FROM kombajn WHERE id = {tbId.Text}", conn)
                .ExecuteReader();
            r.Read();

            tbTipus.Text = r["tipus"].ToString();
            tbEv.Text = r["gyartasiEv"].ToString();
            tbHely.Text = r["atvevoHely"].ToString();
            tbAr.Text = r["iranyAr"].ToString();
            conn.Close();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection(connectionString);
            conn.Open();
            new SqlCommand(
                "UPDATE kombajn SET " +
                $"iranyAr =    { tbAr.Text }, " +
                $"atvevoHely = '{ tbHely.Text }' " +
                $"WHERE id =   { tbId.Text };", conn).ExecuteNonQuery();
            conn.Close();
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if(DialogResult.Yes == MessageBox.Show(
                "Biztosan törölni akarod?",
                "Figyelmeztetés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning))
            {
                var conn = new SqlConnection(connectionString);
                conn.Open();
                new SqlCommand(
                    "DELETE FROM kombajn " +
                    $"WHERE id = { tbId.Text };", conn).ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            if (Ellenorzes())
            {
                var conn = new SqlConnection(connectionString);
                conn.Open();
                new SqlCommand(
                    $"INSERT INTO kombajn VALUES " +
                    $"('{tbTipus.Text}', {tbEv.Text}, {cbTulajok.SelectedIndex + 1}, '{tbHely.Text}',  {iranyAr});",
                    conn).ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
            else MessageBox.Show("valamelyik adat típusa nem stimmel");
        }

        private bool Ellenorzes()
        {
            if (int.TryParse(tbAr.Text, out int ar)) iranyAr = ar.ToString();
            else if (tbAr.Text.Length > 0) return false;

            if (!int.TryParse(tbEv.Text, out _)) return false;
            return true;
        }
    }
}
