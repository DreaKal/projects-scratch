namespace WindowsFormsApp1
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnklblTaxes = new System.Windows.Forms.LinkLabel();
            this.lnklblPayRoll = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lnklblTaxes);
            this.panel1.Controls.Add(this.lnklblPayRoll);
            this.panel1.Location = new System.Drawing.Point(10, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 58);
            this.panel1.TabIndex = 0;
            // 
            // lnklblTaxes
            // 
            this.lnklblTaxes.AutoSize = true;
            this.lnklblTaxes.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblTaxes.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnklblTaxes.LinkColor = System.Drawing.Color.Black;
            this.lnklblTaxes.Location = new System.Drawing.Point(190, 10);
            this.lnklblTaxes.Name = "lnklblTaxes";
            this.lnklblTaxes.Size = new System.Drawing.Size(107, 37);
            this.lnklblTaxes.TabIndex = 1;
            this.lnklblTaxes.TabStop = true;
            this.lnklblTaxes.Text = "Taxes";
            // 
            // lnklblPayRoll
            // 
            this.lnklblPayRoll.AutoSize = true;
            this.lnklblPayRoll.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblPayRoll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnklblPayRoll.LinkColor = System.Drawing.Color.Black;
            this.lnklblPayRoll.Location = new System.Drawing.Point(11, 10);
            this.lnklblPayRoll.Name = "lnklblPayRoll";
            this.lnklblPayRoll.Size = new System.Drawing.Size(133, 37);
            this.lnklblPayRoll.TabIndex = 0;
            this.lnklblPayRoll.TabStop = true;
            this.lnklblPayRoll.Text = "PayRoll";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(11, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(91, 32);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(240, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 32);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1040, 424);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 42);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Location = new System.Drawing.Point(10, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 50);
            this.panel2.TabIndex = 4;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1185, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.LinkLabel lnklblPayRoll;
        private System.Windows.Forms.LinkLabel lnklblTaxes;
        private System.Windows.Forms.Panel panel2;
    }
}