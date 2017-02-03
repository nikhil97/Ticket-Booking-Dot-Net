namespace Project
{
    partial class TicketBooking1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketBooking1));
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.Stand1 = new System.Windows.Forms.Button();
            this.Stand5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(2, 54);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 13);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X = ";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(5, 85);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(26, 13);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Y = ";
            // 
            // Stand1
            // 
            this.Stand1.BackColor = System.Drawing.Color.Transparent;
            this.Stand1.Location = new System.Drawing.Point(533, 31);
            this.Stand1.Name = "Stand1";
            this.Stand1.Size = new System.Drawing.Size(92, 45);
            this.Stand1.TabIndex = 2;
            this.Stand1.Text = "click here";
            this.Stand1.UseVisualStyleBackColor = false;
            this.Stand1.Click += new System.EventHandler(this.Stand1_Click);
            // 
            // Stand5
            // 
            this.Stand5.BackColor = System.Drawing.Color.Transparent;
            this.Stand5.Location = new System.Drawing.Point(618, 330);
            this.Stand5.Name = "Stand5";
            this.Stand5.Size = new System.Drawing.Size(94, 42);
            this.Stand5.TabIndex = 3;
            this.Stand5.Text = "click here";
            this.Stand5.UseVisualStyleBackColor = false;
            this.Stand5.Click += new System.EventHandler(this.Stand5_Click);
            // 
            // TicketBooking1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(740, 606);
            this.Controls.Add(this.Stand5);
            this.Controls.Add(this.Stand1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "TicketBooking1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketBooking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TicketBooking1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button Stand1;
        private System.Windows.Forms.Button Stand5;
    }
}