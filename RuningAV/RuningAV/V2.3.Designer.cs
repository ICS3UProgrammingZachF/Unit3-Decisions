namespace RuningAV
{
    partial class form2
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
            this.btn = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblaverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(69, 166);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "calcualte";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(59, 86);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 1;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(325, 89);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(10, 13);
            this.lbltotal.TabIndex = 2;
            this.lbltotal.Text = " ";
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.Location = new System.Drawing.Point(325, 171);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(10, 13);
            this.lblaverage.TabIndex = 3;
            this.lblaverage.Text = " ";
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 260);
            this.Controls.Add(this.lblaverage);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btn);
            this.Name = "form2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblaverage;
    }
}

