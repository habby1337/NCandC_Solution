namespace NCandC
{
    partial class FormConfig
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
            this.UNPlayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bApply = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.ListPlayer = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UNPlayer
            // 
            this.UNPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.UNPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UNPlayer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UNPlayer.ForeColor = System.Drawing.Color.Goldenrod;
            this.UNPlayer.Location = new System.Drawing.Point(73, 93);
            this.UNPlayer.MaxLength = 20;
            this.UNPlayer.Name = "UNPlayer";
            this.UNPlayer.Size = new System.Drawing.Size(333, 23);
            this.UNPlayer.TabIndex = 0;
            this.UNPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Giocatore:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.ListPlayer);
            this.panel1.Controls.Add(this.bApply);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(583, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 554);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.lNumber);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bRemove);
            this.panel2.Controls.Add(this.bInsert);
            this.panel2.Controls.Add(this.UNPlayer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 554);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista Giocatori";
            // 
            // bApply
            // 
            this.bApply.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.bApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.ForeColor = System.Drawing.Color.White;
            this.bApply.Location = new System.Drawing.Point(61, 498);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(228, 39);
            this.bApply.TabIndex = 3;
            this.bApply.Text = "Applica";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // bInsert
            // 
            this.bInsert.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.bInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.bInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInsert.ForeColor = System.Drawing.Color.White;
            this.bInsert.Location = new System.Drawing.Point(73, 167);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(126, 39);
            this.bInsert.TabIndex = 4;
            this.bInsert.Text = "Inserisci";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bRemove
            // 
            this.bRemove.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.bRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.bRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRemove.ForeColor = System.Drawing.Color.White;
            this.bRemove.Location = new System.Drawing.Point(280, 167);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(126, 39);
            this.bRemove.TabIndex = 5;
            this.bRemove.Text = "Rimuovi";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // ListPlayer
            // 
            this.ListPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ListPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListPlayer.ForeColor = System.Drawing.Color.White;
            this.ListPlayer.FormattingEnabled = true;
            this.ListPlayer.ItemHeight = 16;
            this.ListPlayer.Location = new System.Drawing.Point(61, 41);
            this.ListPlayer.Name = "ListPlayer";
            this.ListPlayer.Size = new System.Drawing.Size(228, 418);
            this.ListPlayer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero Giocatori:";
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.lNumber.ForeColor = System.Drawing.Color.White;
            this.lNumber.Location = new System.Drawing.Point(215, 291);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(88, 21);
            this.lNumber.TabIndex = 8;
            this.lNumber.Text = "%numero%";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NCeC :: Config";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UNPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.ListBox ListPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lNumber;
    }
}