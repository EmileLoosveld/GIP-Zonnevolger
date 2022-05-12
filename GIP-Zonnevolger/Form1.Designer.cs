
namespace GIP_Zonnevolger
{
    partial class Form1
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
            this.btnZoekServer = new System.Windows.Forms.Button();
            this.txtIPadr = new System.Windows.Forms.MaskedTextBox();
            this.pnlOpties = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPoortnr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOpties.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZoekServer
            // 
            this.btnZoekServer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZoekServer.Location = new System.Drawing.Point(88, 114);
            this.btnZoekServer.Name = "btnZoekServer";
            this.btnZoekServer.Size = new System.Drawing.Size(100, 25);
            this.btnZoekServer.TabIndex = 6;
            this.btnZoekServer.Text = "Zoek server";
            this.btnZoekServer.UseVisualStyleBackColor = true;
            // 
            // txtIPadr
            // 
            this.txtIPadr.Location = new System.Drawing.Point(88, 66);
            this.txtIPadr.Name = "txtIPadr";
            this.txtIPadr.Size = new System.Drawing.Size(189, 20);
            this.txtIPadr.TabIndex = 5;
            this.txtIPadr.Text = "192.168.1.45";
            // 
            // pnlOpties
            // 
            this.pnlOpties.Controls.Add(this.label4);
            this.pnlOpties.Controls.Add(this.label5);
            this.pnlOpties.Controls.Add(this.btnZoekServer);
            this.pnlOpties.Controls.Add(this.txtPoortnr);
            this.pnlOpties.Controls.Add(this.txtIPadr);
            this.pnlOpties.Controls.Add(this.label1);
            this.pnlOpties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOpties.Location = new System.Drawing.Point(0, 33);
            this.pnlOpties.Name = "pnlOpties";
            this.pnlOpties.Size = new System.Drawing.Size(1002, 506);
            this.pnlOpties.TabIndex = 1;
            this.pnlOpties.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOpties_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(33, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Poort-nr:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(33, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "IP-adres:";
            // 
            // txtPoortnr
            // 
            this.txtPoortnr.Location = new System.Drawing.Point(88, 88);
            this.txtPoortnr.Name = "txtPoortnr";
            this.txtPoortnr.Size = new System.Drawing.Size(189, 20);
            this.txtPoortnr.TabIndex = 1;
            this.txtPoortnr.Text = "2000";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1002, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vul alle gegevens in";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 539);
            this.Controls.Add(this.pnlOpties);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOpties.ResumeLayout(false);
            this.pnlOpties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZoekServer;
        private System.Windows.Forms.MaskedTextBox txtIPadr;
        private System.Windows.Forms.Panel pnlOpties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPoortnr;
        private System.Windows.Forms.Label label1;
    }
}