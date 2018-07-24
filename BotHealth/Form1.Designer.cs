namespace BotHealth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbxMsg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(384, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(133, 23);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bot Health";
            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlAction.Controls.Add(this.btnSend);
            this.pnlAction.Controls.Add(this.tbxMsg);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 511);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(384, 50);
            this.pnlAction.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.BorderRadius = 0;
            this.btnSend.ButtonText = "";
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.DisabledColor = System.Drawing.Color.Gray;
            this.btnSend.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSend.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSend.Iconimage")));
            this.btnSend.Iconimage_right = null;
            this.btnSend.Iconimage_right_Selected = null;
            this.btnSend.Iconimage_Selected = null;
            this.btnSend.IconMarginLeft = 0;
            this.btnSend.IconMarginRight = 0;
            this.btnSend.IconRightVisible = true;
            this.btnSend.IconRightZoom = 0D;
            this.btnSend.IconVisible = true;
            this.btnSend.IconZoom = 50D;
            this.btnSend.IsTab = false;
            this.btnSend.Location = new System.Drawing.Point(338, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSend.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSend.selected = false;
            this.btnSend.Size = new System.Drawing.Size(46, 48);
            this.btnSend.TabIndex = 1;
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Textcolor = System.Drawing.Color.White;
            this.btnSend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxMsg
            // 
            this.tbxMsg.Depth = 0;
            this.tbxMsg.Hint = "Type a message";
            this.tbxMsg.Location = new System.Drawing.Point(12, 15);
            this.tbxMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbxMsg.Name = "tbxMsg";
            this.tbxMsg.PasswordChar = '\0';
            this.tbxMsg.SelectedText = "";
            this.tbxMsg.SelectionLength = 0;
            this.tbxMsg.SelectionStart = 0;
            this.tbxMsg.Size = new System.Drawing.Size(318, 23);
            this.tbxMsg.TabIndex = 0;
            this.tbxMsg.UseSystemPasswordChar = false;
            this.tbxMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMsg_KeyDown);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.AutoScroll = true;
            this.pnlDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 50);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(384, 461);
            this.pnlDisplay.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Panel pnlDisplay;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private Bunifu.Framework.UI.BunifuFlatButton btnSend;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbxMsg;
    }
}

