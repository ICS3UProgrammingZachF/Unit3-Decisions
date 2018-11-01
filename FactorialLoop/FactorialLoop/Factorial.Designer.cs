namespace FactorialLoop
{
    partial class Factorial
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
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.lstFactorial = new System.Windows.Forms.ListBox();
            this.btncount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblanwser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFactorial
            // 
            this.txtFactorial.Location = new System.Drawing.Point(300, 81);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.Size = new System.Drawing.Size(100, 20);
            this.txtFactorial.TabIndex = 0;
            // 
            // lstFactorial
            // 
            this.lstFactorial.FormattingEnabled = true;
            this.lstFactorial.Location = new System.Drawing.Point(159, 122);
            this.lstFactorial.Name = "lstFactorial";
            this.lstFactorial.Size = new System.Drawing.Size(120, 95);
            this.lstFactorial.TabIndex = 1;
            // 
            // btncount
            // 
            this.btncount.Location = new System.Drawing.Point(300, 138);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(75, 23);
            this.btncount.TabIndex = 2;
            this.btncount.Text = "calculate";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "enter a number here";
            // 
            // lblanwser
            // 
            this.lblanwser.AutoSize = true;
            this.lblanwser.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanwser.Location = new System.Drawing.Point(12, 245);
            this.lblanwser.Name = "lblanwser";
            this.lblanwser.Size = new System.Drawing.Size(152, 55);
            this.lblanwser.TabIndex = 4;
            this.lblanwser.Text = "label2";
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 399);
            this.Controls.Add(this.lblanwser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.lstFactorial);
            this.Controls.Add(this.txtFactorial);
            this.Name = "Factorial";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFactorial;
        private System.Windows.Forms.ListBox lstFactorial;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblanwser;
    }
}

