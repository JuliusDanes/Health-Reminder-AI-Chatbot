using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BotHealth
{
    public partial class Form1 : Form
    {
        Regex validateAddMedicine = new Regex(".+[a-zA-Z]");
        int n = 0;
        String txtMessage;

        public Form1()
        {
            InitializeComponent();
        }
                
        private void btnSend_Click(object sender, EventArgs e)
        {
            txtMessage = tbxMsg.Text;
            if ((!String.IsNullOrWhiteSpace(txtMessage))) {
                AddNewBubble(txtMessage, "me");
                AddNewBubble(Response.ResponeMessage(txtMessage), "bot");
                tbxMsg.ResetText();
            } else
                tbxMsg.ResetText();
        }

        private void tbxMsg_KeyDown(object sender, KeyEventArgs e)
        {
            txtMessage = tbxMsg.Text.Trim();
            if ((e.Shift) && (e.KeyCode == Keys.Enter))
            {
                MessageBox.Show("Shit+Enter");
                tbxMsg.Text += "\r\n";
            }
            else if ((!String.IsNullOrWhiteSpace(txtMessage)) && (e.KeyCode == Keys.Enter))
            {
                AddNewBubble(txtMessage, "Me");
                AddNewBubble(Response.ResponeMessage(txtMessage), "Bot");
                tbxMsg.ResetText();
            }
            else if ((String.IsNullOrWhiteSpace(txtMessage)) && (e.KeyCode == Keys.Enter))
                tbxMsg.ResetText();
        }

        public Bunifu.Framework.UI.BunifuThinButton2 AddNewBubble(String txt, String Sender)
        {
            Bunifu.Framework.UI.BunifuThinButton2 box = new Bunifu.Framework.UI.BunifuThinButton2();
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblSender = new System.Windows.Forms.Label();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            System.Windows.Forms.PictureBox pb = new System.Windows.Forms.PictureBox();
            int[] posX = new int[2];
            pb.Image = Image.FromFile(@"D:\Danes\BotHealth\Images\icon.jpg");
            lblSender.Text = Sender;
            lbl.Text = txt;
            lbl.Font = new Font("Arial", 11, FontStyle.Regular);
            lblSender.Font = new Font("Arial", 9, FontStyle.Regular);
            lblSender.ForeColor = Color.DarkSlateGray;
            lbl.AutoSize = lblSender.AutoSize = true;
            lblSender.MaximumSize = new Size(300, 15);
            lbl.MaximumSize = new Size(300, 0);
            box.Size = new Size(lbl.PreferredSize.Width+20, lbl.PreferredSize.Height+20);
            box.ButtonText = "";
            pnlDisplay.Controls.Add(lblSender);
            pnlDisplay.Controls.Add(lbl);
            pnlDisplay.Controls.Add(box);

            if (Sender.ToLower() == "me") {
                posX[0] = this.Size.Width - box.Size.Width - 40;
                posX[1] = this.Size.Width - lblSender.Size.Width - 44;
                box.ActiveFillColor = box.ActiveLineColor = box.IdleFillColor = box.IdleLineColor = lbl.BackColor = Color.SeaGreen;
                lbl.ForeColor = Color.WhiteSmoke;
            }
            else {
                posX[0] = posX[1] = 50;
                box.ActiveFillColor = box.ActiveLineColor = box.IdleFillColor = box.IdleLineColor = lbl.BackColor = Color.WhiteSmoke;
                lbl.ForeColor = Color.SeaGreen;
                pnlDisplay.Controls.Add(pb);
                pb.BackColor = Color.GhostWhite;
                pb.Size = new Size(45, 45);
                gp.AddEllipse(0, 0, pb.Width - 3, pb.Height - 3);
                Region rg = new Region(gp);
                pb.Region = rg;
            }
            box.Location = new System.Drawing.Point(posX[0], (n + 10) - pnlDisplay.VerticalScroll.Value);
            lbl.Location = new System.Drawing.Point(posX[0]+10, (n + 20) - pnlDisplay.VerticalScroll.Value);
            lblSender.Location = new System.Drawing.Point(posX[1]+2, (n) - pnlDisplay.VerticalScroll.Value);
            pb.Location = new System.Drawing.Point(5, (n - 10) - pnlDisplay.VerticalScroll.Value);
            n += box.Size.Height + lblSender.Size.Height;
            for (int i = 1; (i < 3) && (pnlDisplay.VerticalScroll.Maximum != 100); i++)
                pnlDisplay.VerticalScroll.Value = pnlDisplay.VerticalScroll.Maximum;
            return box;
        }
    }
}
