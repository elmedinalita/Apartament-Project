namespace ApartamentiIm
{
    partial class Kyqu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kyqu));
            this.LoginBox = new System.Windows.Forms.PictureBox();
            this.fjalekalimtxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.perdoruesibox = new System.Windows.Forms.TextBox();
            this.fjalekaimbox = new System.Windows.Forms.TextBox();
            this.mbyllebtn = new System.Windows.Forms.Button();
            this.kyqubtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Image = ((System.Drawing.Image)(resources.GetObject("LoginBox.Image")));
            this.LoginBox.Location = new System.Drawing.Point(177, 46);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(205, 158);
            this.LoginBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginBox.TabIndex = 0;
            this.LoginBox.TabStop = false;
            // 
            // fjalekalimtxt
            // 
            this.fjalekalimtxt.AutoSize = true;
            this.fjalekalimtxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fjalekalimtxt.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fjalekalimtxt.Location = new System.Drawing.Point(88, 284);
            this.fjalekalimtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fjalekalimtxt.Name = "fjalekalimtxt";
            this.fjalekalimtxt.Size = new System.Drawing.Size(149, 29);
            this.fjalekalimtxt.TabIndex = 2;
            this.fjalekalimtxt.Text = "Fjalekalimi :";
            this.fjalekalimtxt.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Perdoruesi : ";
            // 
            // perdoruesibox
            // 
            this.perdoruesibox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.perdoruesibox.Location = new System.Drawing.Point(256, 231);
            this.perdoruesibox.Margin = new System.Windows.Forms.Padding(4);
            this.perdoruesibox.Name = "perdoruesibox";
            this.perdoruesibox.Size = new System.Drawing.Size(185, 22);
            this.perdoruesibox.TabIndex = 4;
            this.perdoruesibox.Text = "User1@email.com";
            // 
            // fjalekaimbox
            // 
            this.fjalekaimbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fjalekaimbox.Location = new System.Drawing.Point(256, 290);
            this.fjalekaimbox.Margin = new System.Windows.Forms.Padding(4);
            this.fjalekaimbox.Name = "fjalekaimbox";
            this.fjalekaimbox.Size = new System.Drawing.Size(185, 22);
            this.fjalekaimbox.TabIndex = 5;
            this.fjalekaimbox.Text = "Pass123456";
            this.fjalekaimbox.UseSystemPasswordChar = true;
            // 
            // mbyllebtn
            // 
            this.mbyllebtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.mbyllebtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbyllebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mbyllebtn.Location = new System.Drawing.Point(145, 377);
            this.mbyllebtn.Margin = new System.Windows.Forms.Padding(4);
            this.mbyllebtn.Name = "mbyllebtn";
            this.mbyllebtn.Size = new System.Drawing.Size(100, 43);
            this.mbyllebtn.TabIndex = 6;
            this.mbyllebtn.Text = "Mbylle";
            this.mbyllebtn.UseVisualStyleBackColor = false;
            this.mbyllebtn.Click += new System.EventHandler(this.mbyllebtn_Click);
            // 
            // kyqubtn
            // 
            this.kyqubtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.kyqubtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kyqubtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kyqubtn.Location = new System.Drawing.Point(296, 377);
            this.kyqubtn.Margin = new System.Windows.Forms.Padding(4);
            this.kyqubtn.Name = "kyqubtn";
            this.kyqubtn.Size = new System.Drawing.Size(100, 43);
            this.kyqubtn.TabIndex = 7;
            this.kyqubtn.Text = "Kyqu";
            this.kyqubtn.UseVisualStyleBackColor = false;
            this.kyqubtn.Click += new System.EventHandler(this.kyqubtn_Click);
            // 
            // Kyqu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(539, 554);
            this.Controls.Add(this.kyqubtn);
            this.Controls.Add(this.mbyllebtn);
            this.Controls.Add(this.fjalekaimbox);
            this.Controls.Add(this.perdoruesibox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fjalekalimtxt);
            this.Controls.Add(this.LoginBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kyqu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kyqu";
            ((System.ComponentModel.ISupportInitialize)(this.LoginBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginBox;
        private System.Windows.Forms.Label fjalekalimtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox perdoruesibox;
        private System.Windows.Forms.TextBox fjalekaimbox;
        private System.Windows.Forms.Button mbyllebtn;
        private System.Windows.Forms.Button kyqubtn;
    }
}

