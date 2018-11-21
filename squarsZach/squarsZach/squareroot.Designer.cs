namespace squarsZach
{
    partial class squareroot
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstroot = new System.Windows.Forms.ListBox();
            this.nudvlaue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudvlaue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "claulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstroot
            // 
            this.lstroot.FormattingEnabled = true;
            this.lstroot.Location = new System.Drawing.Point(99, 215);
            this.lstroot.Name = "lstroot";
            this.lstroot.Size = new System.Drawing.Size(120, 95);
            this.lstroot.TabIndex = 2;
            // 
            // nudvlaue
            // 
            this.nudvlaue.Location = new System.Drawing.Point(99, 81);
            this.nudvlaue.Name = "nudvlaue";
            this.nudvlaue.Size = new System.Drawing.Size(120, 20);
            this.nudvlaue.TabIndex = 3;
            // 
            // squareroot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 409);
            this.Controls.Add(this.nudvlaue);
            this.Controls.Add(this.lstroot);
            this.Controls.Add(this.button1);
            this.Name = "squareroot";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudvlaue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstroot;
        private System.Windows.Forms.NumericUpDown nudvlaue;
    }
}

