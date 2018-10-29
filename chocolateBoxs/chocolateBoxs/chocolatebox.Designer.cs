namespace chocolateBoxs
{
    partial class chocolatebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chocolatebox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.btncal = new System.Windows.Forms.Button();
            this.lblchocolate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(207, 124);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(120, 20);
            this.txt.TabIndex = 1;
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(226, 187);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(75, 23);
            this.btncal.TabIndex = 2;
            this.btncal.Text = "Get reward";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblchocolate
            // 
            this.lblchocolate.AutoSize = true;
            this.lblchocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchocolate.Location = new System.Drawing.Point(232, 261);
            this.lblchocolate.Name = "lblchocolate";
            this.lblchocolate.Size = new System.Drawing.Size(60, 24);
            this.lblchocolate.TabIndex = 3;
            this.lblchocolate.Text = "label1";
            // 
            // chocolatebox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(768, 548);
            this.Controls.Add(this.lblchocolate);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "chocolatebox";
            this.Text = "chocolateboxs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Label lblchocolate;
    }
}

