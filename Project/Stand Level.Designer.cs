namespace Project
{
    partial class Stand_Level
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
            this.label1 = new System.Windows.Forms.Label();
            this.StandName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SeatsLeft = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "You Chose";
            // 
            // StandName
            // 
            this.StandName.AutoSize = true;
            this.StandName.Location = new System.Drawing.Point(219, 52);
            this.StandName.Name = "StandName";
            this.StandName.Size = new System.Drawing.Size(63, 21);
            this.StandName.TabIndex = 4;
            this.StandName.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "No Of Seats Left";
            // 
            // SeatsLeft
            // 
            this.SeatsLeft.AutoSize = true;
            this.SeatsLeft.Location = new System.Drawing.Point(298, 128);
            this.SeatsLeft.Name = "SeatsLeft";
            this.SeatsLeft.Size = new System.Drawing.Size(63, 21);
            this.SeatsLeft.TabIndex = 6;
            this.SeatsLeft.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 72);
            this.button1.TabIndex = 7;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(583, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 72);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Stand_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SeatsLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StandName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Stand_Level";
            this.Text = "Stand_Level";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stand_Level_FormClosed_1);
            this.Load += new System.EventHandler(this.Stand_Level_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StandName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SeatsLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}