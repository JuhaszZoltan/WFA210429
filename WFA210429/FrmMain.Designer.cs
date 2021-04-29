
namespace WFA210429
{
    partial class FrmMain
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
            this.lblOpening = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOpening
            // 
            this.lblOpening.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpening.Location = new System.Drawing.Point(12, 108);
            this.lblOpening.Name = "lblOpening";
            this.lblOpening.Size = new System.Drawing.Size(769, 74);
            this.lblOpening.TabIndex = 0;
            this.lblOpening.Text = "###szoveg###";
            this.lblOpening.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.btnN1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnN2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnN3, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 284);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnN1
            // 
            this.btnN1.BackColor = System.Drawing.Color.ForestGreen;
            this.btnN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnN1.Location = new System.Drawing.Point(79, 3);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(147, 94);
            this.btnN1.TabIndex = 0;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = false;
            // 
            // btnN2
            // 
            this.btnN2.BackColor = System.Drawing.Color.ForestGreen;
            this.btnN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnN2.Location = new System.Drawing.Point(308, 3);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(147, 94);
            this.btnN2.TabIndex = 1;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = false;
            // 
            // btnN3
            // 
            this.btnN3.BackColor = System.Drawing.Color.ForestGreen;
            this.btnN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnN3.Location = new System.Drawing.Point(537, 3);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(147, 94);
            this.btnN3.TabIndex = 2;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 543);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblOpening);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOpening;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button btnN3;
    }
}

