
namespace WFA210429
{
    partial class FrmKinalat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiKombajn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTulaj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKereses = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvKinalat = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKinalat)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKombajn,
            this.tsmiTulaj,
            this.tsmiKereses});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 78);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiKombajn
            // 
            this.tsmiKombajn.Image = global::WFA210429.Properties.Resources.kombajn;
            this.tsmiKombajn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiKombajn.Name = "tsmiKombajn";
            this.tsmiKombajn.Size = new System.Drawing.Size(99, 74);
            this.tsmiKombajn.Text = "Kombájnok";
            this.tsmiKombajn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiKombajn.Click += new System.EventHandler(this.TsmiKombajn_Click);
            // 
            // tsmiTulaj
            // 
            this.tsmiTulaj.Image = global::WFA210429.Properties.Resources.paraszt;
            this.tsmiTulaj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTulaj.Name = "tsmiTulaj";
            this.tsmiTulaj.Size = new System.Drawing.Size(112, 74);
            this.tsmiTulaj.Text = "Tulajdonosok";
            this.tsmiTulaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiKereses
            // 
            this.tsmiKereses.Image = global::WFA210429.Properties.Resources.nagyito;
            this.tsmiKereses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiKereses.Name = "tsmiKereses";
            this.tsmiKereses.Size = new System.Drawing.Size(73, 74);
            this.tsmiKereses.Text = "Keresés";
            this.tsmiKereses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiKereses.Click += new System.EventHandler(this.tsmiKereses_Click);
            // 
            // dgvKinalat
            // 
            this.dgvKinalat.AllowUserToAddRows = false;
            this.dgvKinalat.AllowUserToDeleteRows = false;
            this.dgvKinalat.AllowUserToResizeColumns = false;
            this.dgvKinalat.AllowUserToResizeRows = false;
            this.dgvKinalat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKinalat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKinalat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvKinalat.Location = new System.Drawing.Point(12, 103);
            this.dgvKinalat.Name = "dgvKinalat";
            this.dgvKinalat.RowHeadersVisible = false;
            this.dgvKinalat.RowHeadersWidth = 51;
            this.dgvKinalat.RowTemplate.Height = 24;
            this.dgvKinalat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKinalat.Size = new System.Drawing.Size(827, 310);
            this.dgvKinalat.TabIndex = 1;
            this.dgvKinalat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKinalat_CellClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "id";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 160F;
            this.Column1.HeaderText = "típus";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 70F;
            this.Column2.HeaderText = "gyártási év";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "irányár";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "telefonszám";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "helység";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // FrmKinalat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 425);
            this.Controls.Add(this.dgvKinalat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmKinalat";
            this.Text = "Kínálat";
            this.Load += new System.EventHandler(this.FrmKinalat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKinalat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiKombajn;
        private System.Windows.Forms.ToolStripMenuItem tsmiTulaj;
        private System.Windows.Forms.ToolStripMenuItem tsmiKereses;
        private System.Windows.Forms.DataGridView dgvKinalat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}