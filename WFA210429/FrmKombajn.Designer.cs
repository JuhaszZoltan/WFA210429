
namespace WFA210429
{
    partial class FrmKombajn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbTipus = new System.Windows.Forms.TextBox();
            this.tbEv = new System.Windows.Forms.TextBox();
            this.tbHely = new System.Windows.Forms.TextBox();
            this.tbAr = new System.Windows.Forms.TextBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.lblTulaj = new System.Windows.Forms.Label();
            this.cbTulajok = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "típus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "gyártási év:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "irányár:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "átvevőhely:";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(141, 31);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(54, 22);
            this.tbId.TabIndex = 1;
            // 
            // tbTipus
            // 
            this.tbTipus.Enabled = false;
            this.tbTipus.Location = new System.Drawing.Point(141, 76);
            this.tbTipus.Name = "tbTipus";
            this.tbTipus.Size = new System.Drawing.Size(203, 22);
            this.tbTipus.TabIndex = 2;
            // 
            // tbEv
            // 
            this.tbEv.Enabled = false;
            this.tbEv.Location = new System.Drawing.Point(141, 121);
            this.tbEv.Name = "tbEv";
            this.tbEv.Size = new System.Drawing.Size(203, 22);
            this.tbEv.TabIndex = 2;
            // 
            // tbHely
            // 
            this.tbHely.Location = new System.Drawing.Point(141, 166);
            this.tbHely.Name = "tbHely";
            this.tbHely.Size = new System.Drawing.Size(203, 22);
            this.tbHely.TabIndex = 2;
            // 
            // tbAr
            // 
            this.tbAr.Location = new System.Drawing.Point(141, 211);
            this.tbAr.Name = "tbAr";
            this.tbAr.Size = new System.Drawing.Size(203, 22);
            this.tbAr.TabIndex = 2;
            // 
            // btnMod
            // 
            this.btnMod.Enabled = false;
            this.btnMod.Location = new System.Drawing.Point(256, 302);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(91, 53);
            this.btnMod.TabIndex = 3;
            this.btnMod.Text = "Módosítás";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(129, 302);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(99, 53);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Törlés";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUj
            // 
            this.btnUj.Enabled = false;
            this.btnUj.Location = new System.Drawing.Point(15, 302);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(98, 53);
            this.btnUj.TabIndex = 3;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // lblTulaj
            // 
            this.lblTulaj.AutoSize = true;
            this.lblTulaj.Location = new System.Drawing.Point(33, 259);
            this.lblTulaj.Name = "lblTulaj";
            this.lblTulaj.Size = new System.Drawing.Size(77, 17);
            this.lblTulaj.TabIndex = 0;
            this.lblTulaj.Text = "tulajdonos:";
            this.lblTulaj.Visible = false;
            // 
            // cbTulajok
            // 
            this.cbTulajok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTulajok.Enabled = false;
            this.cbTulajok.FormattingEnabled = true;
            this.cbTulajok.Location = new System.Drawing.Point(141, 256);
            this.cbTulajok.Name = "cbTulajok";
            this.cbTulajok.Size = new System.Drawing.Size(203, 24);
            this.cbTulajok.TabIndex = 4;
            this.cbTulajok.Visible = false;
            // 
            // FrmKombajn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 372);
            this.Controls.Add(this.cbTulajok);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.tbAr);
            this.Controls.Add(this.tbHely);
            this.Controls.Add(this.tbEv);
            this.Controls.Add(this.tbTipus);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTulaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKombajn";
            this.Text = "FrmKombajn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbTipus;
        private System.Windows.Forms.TextBox tbEv;
        private System.Windows.Forms.TextBox tbHely;
        private System.Windows.Forms.TextBox tbAr;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Label lblTulaj;
        private System.Windows.Forms.ComboBox cbTulajok;
    }
}