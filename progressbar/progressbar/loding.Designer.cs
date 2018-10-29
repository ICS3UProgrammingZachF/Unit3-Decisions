namespace progressbar
{
    partial class loding
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
            this.btnstrat = new System.Windows.Forms.Button();
            this.prgloding = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnstrat
            // 
            this.btnstrat.Location = new System.Drawing.Point(213, 211);
            this.btnstrat.Name = "btnstrat";
            this.btnstrat.Size = new System.Drawing.Size(75, 23);
            this.btnstrat.TabIndex = 0;
            this.btnstrat.Text = "strat";
            this.btnstrat.UseVisualStyleBackColor = true;
            this.btnstrat.Click += new System.EventHandler(this.btnstrat_Click);
            // 
            // prgloding
            // 
            this.prgloding.Location = new System.Drawing.Point(213, 120);
            this.prgloding.Name = "prgloding";
            this.prgloding.Size = new System.Drawing.Size(100, 23);
            this.prgloding.TabIndex = 1;
            // 
            // loding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 364);
            this.Controls.Add(this.prgloding);
            this.Controls.Add(this.btnstrat);
            this.Name = "loding";
            this.Text = "work";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstrat;
        private System.Windows.Forms.ProgressBar prgloding;
    }
}

