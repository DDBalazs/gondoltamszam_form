namespace gondotamegyszamot
{
    partial class Form
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
            this.lbgond = new System.Windows.Forms.Label();
            this.lbmely = new System.Windows.Forms.Label();
            this.txtipp = new System.Windows.Forms.TextBox();
            this.bttipp = new System.Windows.Forms.Button();
            this.txkn = new System.Windows.Forms.TextBox();
            this.btfelad = new System.Windows.Forms.Button();
            this.btujj = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbgond
            // 
            this.lbgond.AutoSize = true;
            this.lbgond.Location = new System.Drawing.Point(58, 59);
            this.lbgond.Name = "lbgond";
            this.lbgond.Size = new System.Drawing.Size(330, 13);
            this.lbgond.TabIndex = 0;
            this.lbgond.Text = "1 és 50 között gondoltam egy számra, találd ki melyik az!";
            // 
            // lbmely
            // 
            this.lbmely.AutoSize = true;
            this.lbmely.Location = new System.Drawing.Point(61, 109);
            this.lbmely.Name = "lbmely";
            this.lbmely.Size = new System.Drawing.Size(127, 13);
            this.lbmely.TabIndex = 1;
            this.lbmely.Text = "Szerinted melyik az? ";
            // 
            // txtipp
            // 
            this.txtipp.Enabled = false;
            this.txtipp.Location = new System.Drawing.Point(194, 109);
            this.txtipp.Name = "txtipp";
            this.txtipp.Size = new System.Drawing.Size(100, 20);
            this.txtipp.TabIndex = 2;
            // 
            // bttipp
            // 
            this.bttipp.Location = new System.Drawing.Point(313, 106);
            this.bttipp.Name = "bttipp";
            this.bttipp.Size = new System.Drawing.Size(75, 23);
            this.bttipp.TabIndex = 3;
            this.bttipp.Text = "Tippelek!";
            this.bttipp.UseVisualStyleBackColor = true;
            // 
            // txkn
            // 
            this.txkn.Enabled = false;
            this.txkn.Location = new System.Drawing.Point(64, 160);
            this.txkn.Name = "txkn";
            this.txkn.Size = new System.Drawing.Size(324, 20);
            this.txkn.TabIndex = 4;
            // 
            // btfelad
            // 
            this.btfelad.Location = new System.Drawing.Point(64, 260);
            this.btfelad.Name = "btfelad";
            this.btfelad.Size = new System.Drawing.Size(75, 23);
            this.btfelad.TabIndex = 5;
            this.btfelad.Text = "Feladom";
            this.btfelad.UseVisualStyleBackColor = true;
            this.btfelad.Click += new System.EventHandler(this.btfelad_Click);
            // 
            // btujj
            // 
            this.btujj.Location = new System.Drawing.Point(313, 260);
            this.btujj.Name = "btujj";
            this.btujj.Size = new System.Drawing.Size(75, 23);
            this.btujj.TabIndex = 6;
            this.btujj.Text = "Új játék!";
            this.btujj.UseVisualStyleBackColor = true;
            this.btujj.Click += new System.EventHandler(this.btujj_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(413, 83);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(14, 13);
            this.lb3.TabIndex = 7;
            this.lb3.Text = "0";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(416, 229);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(14, 13);
            this.lb4.TabIndex = 8;
            this.lb4.Text = "0";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 305);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.btujj);
            this.Controls.Add(this.btfelad);
            this.Controls.Add(this.txkn);
            this.Controls.Add(this.bttipp);
            this.Controls.Add(this.txtipp);
            this.Controls.Add(this.lbmely);
            this.Controls.Add(this.lbgond);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Játék: Gondoltam egy számra";
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbgond;
        private System.Windows.Forms.Label lbmely;
        private System.Windows.Forms.TextBox txtipp;
        private System.Windows.Forms.Button bttipp;
        private System.Windows.Forms.TextBox txkn;
        private System.Windows.Forms.Button btfelad;
        private System.Windows.Forms.Button btujj;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
    }
}

