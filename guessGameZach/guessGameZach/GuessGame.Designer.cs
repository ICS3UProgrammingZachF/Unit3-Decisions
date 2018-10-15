namespace guessGameZach
{
    partial class guessGame
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
            this.lblQuistion = new System.Windows.Forms.Label();
            this.nudan = new System.Windows.Forms.NumericUpDown();
            this.btncal = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuistion
            // 
            this.lblQuistion.AutoSize = true;
            this.lblQuistion.Location = new System.Drawing.Point(157, 85);
            this.lblQuistion.Name = "lblQuistion";
            this.lblQuistion.Size = new System.Drawing.Size(157, 13);
            this.lblQuistion.TabIndex = 0;
            this.lblQuistion.Text = "pic a number between 1 and 20";
            // 
            // nudan
            // 
            this.nudan.Location = new System.Drawing.Point(361, 85);
            this.nudan.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudan.Name = "nudan";
            this.nudan.Size = new System.Drawing.Size(120, 20);
            this.nudan.TabIndex = 1;
            this.nudan.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(580, 85);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(75, 23);
            this.btncal.TabIndex = 2;
            this.btncal.Text = "Calculate";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // pic
            // 
            this.pic.Image = global::guessGameZach.Properties.Resources.checkmark;
            this.pic.Location = new System.Drawing.Point(101, 130);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(540, 310);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 482);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.nudan);
            this.Controls.Add(this.lblQuistion);
            this.Name = "guessGame";
            this.Text = "guessing game";
            this.Load += new System.EventHandler(this.guessGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuistion;
        private System.Windows.Forms.NumericUpDown nudan;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.PictureBox pic;
    }
}

