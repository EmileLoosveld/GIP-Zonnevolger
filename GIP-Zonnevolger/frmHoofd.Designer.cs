
namespace GIP_Zonnevolger
{
    partial class frmHoofd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoofd));
            this.bgWorkerOntvang = new System.ComponentModel.BackgroundWorker();
            this.grpWerking = new System.Windows.Forms.GroupBox();
            this.rdbAutomatisch = new System.Windows.Forms.RadioButton();
            this.rdbManueel = new System.Windows.Forms.RadioButton();
            this.txtIPadr = new System.Windows.Forms.MaskedTextBox();
            this.grpInformatie = new System.Windows.Forms.GroupBox();
            this.lblOostWaarde = new System.Windows.Forms.Label();
            this.lblWestWaarde = new System.Windows.Forms.Label();
            this.lblNoord = new System.Windows.Forms.Label();
            this.lblNoordWaarde = new System.Windows.Forms.Label();
            this.lblWest = new System.Windows.Forms.Label();
            this.lblZuidWaarde = new System.Windows.Forms.Label();
            this.lblOost = new System.Windows.Forms.Label();
            this.lblZuid = new System.Windows.Forms.Label();
            this.txtPoortnr = new System.Windows.Forms.TextBox();
            this.btnZoekServer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpVeiligheid = new System.Windows.Forms.GroupBox();
            this.btnVeiligheidsstand = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBesturing = new System.Windows.Forms.GroupBox();
            this.btnZuid = new System.Windows.Forms.Button();
            this.btnNoord = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnOost = new System.Windows.Forms.Button();
            this.pnlOpties = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.instellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAfbeelding = new System.Windows.Forms.Panel();
            this.grpWerking.SuspendLayout();
            this.grpInformatie.SuspendLayout();
            this.grpVeiligheid.SuspendLayout();
            this.grpBesturing.SuspendLayout();
            this.pnlOpties.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlAfbeelding.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgWorkerOntvang
            // 
            this.bgWorkerOntvang.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerOntvang_DoWork);
            this.bgWorkerOntvang.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerOntvang_RunWorkerCompleted);
            // 
            // grpWerking
            // 
            resources.ApplyResources(this.grpWerking, "grpWerking");
            this.grpWerking.Controls.Add(this.rdbAutomatisch);
            this.grpWerking.Controls.Add(this.rdbManueel);
            this.grpWerking.Name = "grpWerking";
            this.grpWerking.TabStop = false;
            // 
            // rdbAutomatisch
            // 
            resources.ApplyResources(this.rdbAutomatisch, "rdbAutomatisch");
            this.rdbAutomatisch.Checked = true;
            this.rdbAutomatisch.Name = "rdbAutomatisch";
            this.rdbAutomatisch.TabStop = true;
            this.rdbAutomatisch.UseVisualStyleBackColor = true;
            this.rdbAutomatisch.CheckedChanged += new System.EventHandler(this.rdbAutomatisch_CheckedChanged);
            // 
            // rdbManueel
            // 
            resources.ApplyResources(this.rdbManueel, "rdbManueel");
            this.rdbManueel.Name = "rdbManueel";
            this.rdbManueel.UseVisualStyleBackColor = true;
            this.rdbManueel.CheckedChanged += new System.EventHandler(this.rdbManueel_CheckedChanged);
            // 
            // txtIPadr
            // 
            resources.ApplyResources(this.txtIPadr, "txtIPadr");
            this.txtIPadr.Name = "txtIPadr";
            // 
            // grpInformatie
            // 
            resources.ApplyResources(this.grpInformatie, "grpInformatie");
            this.grpInformatie.Controls.Add(this.lblOostWaarde);
            this.grpInformatie.Controls.Add(this.lblWestWaarde);
            this.grpInformatie.Controls.Add(this.lblNoord);
            this.grpInformatie.Controls.Add(this.lblNoordWaarde);
            this.grpInformatie.Controls.Add(this.lblWest);
            this.grpInformatie.Controls.Add(this.lblZuidWaarde);
            this.grpInformatie.Controls.Add(this.lblOost);
            this.grpInformatie.Controls.Add(this.lblZuid);
            this.grpInformatie.Name = "grpInformatie";
            this.grpInformatie.TabStop = false;
            // 
            // lblOostWaarde
            // 
            resources.ApplyResources(this.lblOostWaarde, "lblOostWaarde");
            this.lblOostWaarde.Name = "lblOostWaarde";
            // 
            // lblWestWaarde
            // 
            resources.ApplyResources(this.lblWestWaarde, "lblWestWaarde");
            this.lblWestWaarde.Name = "lblWestWaarde";
            // 
            // lblNoord
            // 
            resources.ApplyResources(this.lblNoord, "lblNoord");
            this.lblNoord.Name = "lblNoord";
            // 
            // lblNoordWaarde
            // 
            resources.ApplyResources(this.lblNoordWaarde, "lblNoordWaarde");
            this.lblNoordWaarde.Name = "lblNoordWaarde";
            // 
            // lblWest
            // 
            resources.ApplyResources(this.lblWest, "lblWest");
            this.lblWest.Name = "lblWest";
            // 
            // lblZuidWaarde
            // 
            resources.ApplyResources(this.lblZuidWaarde, "lblZuidWaarde");
            this.lblZuidWaarde.Name = "lblZuidWaarde";
            // 
            // lblOost
            // 
            resources.ApplyResources(this.lblOost, "lblOost");
            this.lblOost.Name = "lblOost";
            // 
            // lblZuid
            // 
            resources.ApplyResources(this.lblZuid, "lblZuid");
            this.lblZuid.Name = "lblZuid";
            // 
            // txtPoortnr
            // 
            resources.ApplyResources(this.txtPoortnr, "txtPoortnr");
            this.txtPoortnr.Name = "txtPoortnr";
            // 
            // btnZoekServer
            // 
            resources.ApplyResources(this.btnZoekServer, "btnZoekServer");
            this.btnZoekServer.Name = "btnZoekServer";
            this.btnZoekServer.UseVisualStyleBackColor = true;
            this.btnZoekServer.Click += new System.EventHandler(this.btnZoekServer_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // grpVeiligheid
            // 
            resources.ApplyResources(this.grpVeiligheid, "grpVeiligheid");
            this.grpVeiligheid.Controls.Add(this.btnVeiligheidsstand);
            this.grpVeiligheid.Name = "grpVeiligheid";
            this.grpVeiligheid.TabStop = false;
            // 
            // btnVeiligheidsstand
            // 
            resources.ApplyResources(this.btnVeiligheidsstand, "btnVeiligheidsstand");
            this.btnVeiligheidsstand.Name = "btnVeiligheidsstand";
            this.btnVeiligheidsstand.UseVisualStyleBackColor = true;
            this.btnVeiligheidsstand.Click += new System.EventHandler(this.btnVeiligheidsstand_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // grpBesturing
            // 
            this.grpBesturing.Controls.Add(this.btnZuid);
            this.grpBesturing.Controls.Add(this.btnNoord);
            this.grpBesturing.Controls.Add(this.btnWest);
            this.grpBesturing.Controls.Add(this.btnOost);
            resources.ApplyResources(this.grpBesturing, "grpBesturing");
            this.grpBesturing.Name = "grpBesturing";
            this.grpBesturing.TabStop = false;
            // 
            // btnZuid
            // 
            resources.ApplyResources(this.btnZuid, "btnZuid");
            this.btnZuid.Name = "btnZuid";
            this.btnZuid.UseVisualStyleBackColor = true;
            this.btnZuid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStartDraaien_MouseUp);
            this.btnZuid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopDraaien_MouseUp);
            // 
            // btnNoord
            // 
            resources.ApplyResources(this.btnNoord, "btnNoord");
            this.btnNoord.Name = "btnNoord";
            this.btnNoord.UseVisualStyleBackColor = true;
            this.btnNoord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStartDraaien_MouseUp);
            this.btnNoord.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopDraaien_MouseUp);
            // 
            // btnWest
            // 
            resources.ApplyResources(this.btnWest, "btnWest");
            this.btnWest.Name = "btnWest";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStartDraaien_MouseUp);
            this.btnWest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopDraaien_MouseUp);
            // 
            // btnOost
            // 
            resources.ApplyResources(this.btnOost, "btnOost");
            this.btnOost.Name = "btnOost";
            this.btnOost.UseVisualStyleBackColor = true;
            this.btnOost.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStartDraaien_MouseUp);
            this.btnOost.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopDraaien_MouseUp);
            // 
            // pnlOpties
            // 
            this.pnlOpties.Controls.Add(this.grpBesturing);
            this.pnlOpties.Controls.Add(this.grpVeiligheid);
            this.pnlOpties.Controls.Add(this.grpInformatie);
            this.pnlOpties.Controls.Add(this.grpWerking);
            resources.ApplyResources(this.pnlOpties, "pnlOpties");
            this.pnlOpties.Name = "pnlOpties";
            this.pnlOpties.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOpties_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instellingenToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // instellingenToolStripMenuItem
            // 
            this.instellingenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionsettingsToolStripMenuItem});
            this.instellingenToolStripMenuItem.Name = "instellingenToolStripMenuItem";
            resources.ApplyResources(this.instellingenToolStripMenuItem, "instellingenToolStripMenuItem");
            this.instellingenToolStripMenuItem.Click += new System.EventHandler(this.instellingenToolStripMenuItem_Click);
            // 
            // connectionsettingsToolStripMenuItem
            // 
            this.connectionsettingsToolStripMenuItem.Name = "connectionsettingsToolStripMenuItem";
            resources.ApplyResources(this.connectionsettingsToolStripMenuItem, "connectionsettingsToolStripMenuItem");
            // 
            // pnlAfbeelding
            // 
            this.pnlAfbeelding.Controls.Add(this.menuStrip1);
            this.pnlAfbeelding.Controls.Add(this.label4);
            this.pnlAfbeelding.Controls.Add(this.label5);
            this.pnlAfbeelding.Controls.Add(this.txtIPadr);
            this.pnlAfbeelding.Controls.Add(this.btnZoekServer);
            this.pnlAfbeelding.Controls.Add(this.txtPoortnr);
            resources.ApplyResources(this.pnlAfbeelding, "pnlAfbeelding");
            this.pnlAfbeelding.Name = "pnlAfbeelding";
            // 
            // frmHoofd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlAfbeelding);
            this.Controls.Add(this.pnlOpties);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHoofd";
            this.Load += new System.EventHandler(this.frmHoofd_Load);
            this.grpWerking.ResumeLayout(false);
            this.grpWerking.PerformLayout();
            this.grpInformatie.ResumeLayout(false);
            this.grpInformatie.PerformLayout();
            this.grpVeiligheid.ResumeLayout(false);
            this.grpBesturing.ResumeLayout(false);
            this.pnlOpties.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAfbeelding.ResumeLayout(false);
            this.pnlAfbeelding.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgWorkerOntvang;
        private System.Windows.Forms.GroupBox grpWerking;
        private System.Windows.Forms.RadioButton rdbAutomatisch;
        private System.Windows.Forms.RadioButton rdbManueel;
        private System.Windows.Forms.MaskedTextBox txtIPadr;
        private System.Windows.Forms.GroupBox grpInformatie;
        private System.Windows.Forms.Label lblWestWaarde;
        private System.Windows.Forms.Label lblOostWaarde;
        private System.Windows.Forms.Label lblZuidWaarde;
        private System.Windows.Forms.Label lblNoordWaarde;
        private System.Windows.Forms.Label lblWest;
        private System.Windows.Forms.Label lblOost;
        private System.Windows.Forms.Label lblZuid;
        private System.Windows.Forms.Label lblNoord;
        private System.Windows.Forms.TextBox txtPoortnr;
        private System.Windows.Forms.Button btnZoekServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpVeiligheid;
        private System.Windows.Forms.Button btnVeiligheidsstand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBesturing;
        private System.Windows.Forms.Button btnZuid;
        private System.Windows.Forms.Button btnNoord;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnOost;
        private System.Windows.Forms.Panel pnlOpties;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem instellingenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsettingsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAfbeelding;
    }
}

