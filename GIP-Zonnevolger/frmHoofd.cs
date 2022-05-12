using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace GIP_Zonnevolger
{
    public partial class frmHoofd : Form
    {
        //Globale varriablene
        TcpClient client;   //verbinden met Server via Socket
        StreamReader Reader;//Berichten ontvangen
        StreamWriter Writer;//Berichten versturen

        public frmHoofd()
        {
            InitializeComponent();
        }

        private void rdbAutomatisch_CheckedChanged(object sender, EventArgs e)
        {
            //grpBesturing.Enabled = false;
            try
            {
                Writer.Write("7");                                          //Versturen text
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rdbManueel_CheckedChanged(object sender, EventArgs e)
        {
            grpBesturing.Enabled = true;
            try
            {
                Writer.Write("6");                                          //Versturen text
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZoekServer_Click(object sender, EventArgs e)
        {
            //controle IP-adres
            IPAddress ipadres;
            int poortNr;
            if (!IPAddress.TryParse(txtIPadr.Text.Replace(" ", " "), out ipadres))
            {
                MessageBox.Show("Ongeldig IPAdres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIPadr.Focus();
                return;
            }
            if (!int.TryParse(txtPoortnr.Text, out poortNr))
            {
                MessageBox.Show("Ongeldige poortnummer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPoortnr.Focus();
                return;
            }
            //Verbinding maken met server
            try
            {
                client = new TcpClient();
                client.Connect(ipadres, poortNr);
                if (client.Connected)
                {
                    Writer = new StreamWriter(client.GetStream());
                    Reader = new StreamReader(client.GetStream());
                    Writer.AutoFlush = true;
                    bgWorkerOntvang.WorkerSupportsCancellation = true;
                    bgWorkerOntvang.RunWorkerAsync(); //Start ontvangen data
                    btnZoekServer.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kan geen verbinding maken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgWorkerOntvang_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                string bericht;
                try
                {
                    bericht = Reader.ReadLine();
                    if (bericht == null) continue;
                    if (bericht.Contains("Noord"))
                    {
                        this.lblNoordWaarde.Invoke(new MethodInvoker(delegate ()
                        {
                            lblNoordWaarde.Text = bericht.Substring(5, bericht.Length - 5);
                        }));
                    }
                    if (bericht.Contains("Oost"))
                    {
                        this.lblOostWaarde.Invoke(new MethodInvoker(delegate ()
                        {
                            lblOostWaarde.Text = bericht.Substring(4, bericht.Length - 4);
                        }));
                    }
                    if (bericht.Contains("Zuid"))
                    {
                        this.lblZuidWaarde.Invoke(new MethodInvoker(delegate ()
                        {
                            lblZuidWaarde.Text = bericht.Substring(4, bericht.Length - 4);
                        }));
                    }
                    if (bericht.Contains("West"))
                    {
                        this.lblWestWaarde.Invoke(new MethodInvoker(delegate ()
                        {
                            lblWestWaarde.Text = bericht.Substring(4, bericht.Length - 4);
                        }));
                    }
                }
                catch
                {
                    MessageBox.Show("Kan bericht niet ontvangen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bgWorkerOntvang_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Verbinding met de server is verbroken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnZoekServer.Enabled = true;
        }

        private void btnVeiligheidsstand_Click(object sender, EventArgs e)
        {
            try
            {
                Writer.WriteAsync("0");                                          //Versturen text
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden bij deze aanvraag", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnNoord_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Writer.WriteAsync("1");                                          //Versturen text
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden bij deze aanvraag", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopDraaien_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Writer.WriteAsync("5");                                          //Versturen text
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden bij deze aanvraag", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnStartDraaien_MouseUp(object sender, MouseEventArgs e)
        {
            string getal = "Error";
            if (sender == btnNoord)
                getal = "1";
            if (sender == btnOost)
                getal = "2";
            if (sender == btnZuid)
                getal = "3";
            if (sender == btnWest)
                getal = "4";
            try
            {
                Writer.WriteAsync(getal);                                          //Versturen text
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden bij deze aanvraag", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pnlOpties_Paint(object sender, PaintEventArgs e)
        {

        }

        private void instellingenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmHoofd_Load(object sender, EventArgs e)
        {

        }
    }
}
