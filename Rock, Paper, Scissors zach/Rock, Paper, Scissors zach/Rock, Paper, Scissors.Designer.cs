namespace Rock__Paper__Scissors_zach
{
    partial class RockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RockPaperScissors));
            this.grbusr = new System.Windows.Forms.GroupBox();
            this.radscissors = new System.Windows.Forms.RadioButton();
            this.radpaper = new System.Windows.Forms.RadioButton();
            this.radrock = new System.Windows.Forms.RadioButton();
            this.grbcpu = new System.Windows.Forms.GroupBox();
            this.radcpuscissors = new System.Windows.Forms.RadioButton();
            this.radcpupaper = new System.Windows.Forms.RadioButton();
            this.radcpurock = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVs = new System.Windows.Forms.Button();
            this.lblscore = new System.Windows.Forms.Label();
            this.radhide = new System.Windows.Forms.RadioButton();
            this.grbusr.SuspendLayout();
            this.grbcpu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbusr
            // 
            this.grbusr.BackColor = System.Drawing.Color.Transparent;
            this.grbusr.Controls.Add(this.radhide);
            this.grbusr.Controls.Add(this.radscissors);
            this.grbusr.Controls.Add(this.radpaper);
            this.grbusr.Controls.Add(this.radrock);
            this.grbusr.Location = new System.Drawing.Point(141, 1);
            this.grbusr.Name = "grbusr";
            this.grbusr.Size = new System.Drawing.Size(218, 161);
            this.grbusr.TabIndex = 1;
            this.grbusr.TabStop = false;
            this.grbusr.Text = "user\'s pick";
            // 
            // radscissors
            // 
            this.radscissors.AutoSize = true;
            this.radscissors.Location = new System.Drawing.Point(24, 114);
            this.radscissors.Name = "radscissors";
            this.radscissors.Size = new System.Drawing.Size(64, 17);
            this.radscissors.TabIndex = 2;
            this.radscissors.TabStop = true;
            this.radscissors.Text = "Scissors";
            this.radscissors.UseVisualStyleBackColor = true;
            // 
            // radpaper
            // 
            this.radpaper.AutoSize = true;
            this.radpaper.Location = new System.Drawing.Point(24, 75);
            this.radpaper.Name = "radpaper";
            this.radpaper.Size = new System.Drawing.Size(53, 17);
            this.radpaper.TabIndex = 1;
            this.radpaper.TabStop = true;
            this.radpaper.Text = "Paper";
            this.radpaper.UseVisualStyleBackColor = true;
            // 
            // radrock
            // 
            this.radrock.AutoSize = true;
            this.radrock.BackgroundImage = global::Rock__Paper__Scissors_zach.Properties.Resources.Fieldstone;
            this.radrock.Location = new System.Drawing.Point(24, 37);
            this.radrock.Name = "radrock";
            this.radrock.Size = new System.Drawing.Size(51, 17);
            this.radrock.TabIndex = 0;
            this.radrock.TabStop = true;
            this.radrock.Text = "Rock";
            this.radrock.UseVisualStyleBackColor = true;
            // 
            // grbcpu
            // 
            this.grbcpu.Controls.Add(this.radcpuscissors);
            this.grbcpu.Controls.Add(this.radcpupaper);
            this.grbcpu.Controls.Add(this.radcpurock);
            this.grbcpu.Location = new System.Drawing.Point(540, 1);
            this.grbcpu.Name = "grbcpu";
            this.grbcpu.Size = new System.Drawing.Size(287, 161);
            this.grbcpu.TabIndex = 3;
            this.grbcpu.TabStop = false;
            this.grbcpu.Text = "computer pick";
            // 
            // radcpuscissors
            // 
            this.radcpuscissors.AutoSize = true;
            this.radcpuscissors.Location = new System.Drawing.Point(24, 114);
            this.radcpuscissors.Name = "radcpuscissors";
            this.radcpuscissors.Size = new System.Drawing.Size(64, 17);
            this.radcpuscissors.TabIndex = 2;
            this.radcpuscissors.TabStop = true;
            this.radcpuscissors.Text = "Scissors";
            this.radcpuscissors.UseVisualStyleBackColor = true;
            // 
            // radcpupaper
            // 
            this.radcpupaper.AutoSize = true;
            this.radcpupaper.Location = new System.Drawing.Point(24, 75);
            this.radcpupaper.Name = "radcpupaper";
            this.radcpupaper.Size = new System.Drawing.Size(53, 17);
            this.radcpupaper.TabIndex = 1;
            this.radcpupaper.TabStop = true;
            this.radcpupaper.Text = "Paper";
            this.radcpupaper.UseVisualStyleBackColor = true;
            // 
            // radcpurock
            // 
            this.radcpurock.AutoSize = true;
            this.radcpurock.BackgroundImage = global::Rock__Paper__Scissors_zach.Properties.Resources.Fieldstone;
            this.radcpurock.Location = new System.Drawing.Point(24, 37);
            this.radcpurock.Name = "radcpurock";
            this.radcpurock.Size = new System.Drawing.Size(51, 17);
            this.radcpurock.TabIndex = 0;
            this.radcpurock.TabStop = true;
            this.radcpurock.Text = "Rock";
            this.radcpurock.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(883, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnVs
            // 
            this.btnVs.Location = new System.Drawing.Point(380, 263);
            this.btnVs.Name = "btnVs";
            this.btnVs.Size = new System.Drawing.Size(128, 94);
            this.btnVs.TabIndex = 4;
            this.btnVs.Text = "V.S";
            this.btnVs.UseVisualStyleBackColor = true;
            this.btnVs.Click += new System.EventHandler(this.btnVs_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(286, 360);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(164, 165);
            this.lblscore.TabIndex = 5;
            this.lblscore.Text = "srcore\r\n\r\n\r\n";
            // 
            // radhide
            // 
            this.radhide.AutoSize = true;
            this.radhide.Location = new System.Drawing.Point(122, 75);
            this.radhide.Name = "radhide";
            this.radhide.Size = new System.Drawing.Size(64, 17);
            this.radhide.TabIndex = 3;
            this.radhide.TabStop = true;
            this.radhide.Text = "Scissors";
            this.radhide.UseVisualStyleBackColor = true;
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 562);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.btnVs);
            this.Controls.Add(this.grbcpu);
            this.Controls.Add(this.grbusr);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RockPaperScissors";
            this.Text = "Rock, Paper, Scissors";
            this.Load += new System.EventHandler(this.RockPaperScissors_Load);
            this.grbusr.ResumeLayout(false);
            this.grbusr.PerformLayout();
            this.grbcpu.ResumeLayout(false);
            this.grbcpu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbusr;
        private System.Windows.Forms.RadioButton radscissors;
        private System.Windows.Forms.RadioButton radpaper;
        private System.Windows.Forms.RadioButton radrock;
        private System.Windows.Forms.GroupBox grbcpu;
        private System.Windows.Forms.RadioButton radcpuscissors;
        private System.Windows.Forms.RadioButton radcpupaper;
        private System.Windows.Forms.RadioButton radcpurock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVs;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.RadioButton radhide;
    }
}

