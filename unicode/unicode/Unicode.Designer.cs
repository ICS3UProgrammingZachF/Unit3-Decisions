namespace unicode
{
    partial class Unicode
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
            this.btnsart = new System.Windows.Forms.Button();
            this.lstunicode = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnsart
            // 
            this.btnsart.Location = new System.Drawing.Point(160, 59);
            this.btnsart.Name = "btnsart";
            this.btnsart.Size = new System.Drawing.Size(75, 23);
            this.btnsart.TabIndex = 1;
            this.btnsart.Text = "strat";
            this.btnsart.UseVisualStyleBackColor = true;
            this.btnsart.Click += new System.EventHandler(this.btnsart_Click);
            // 
            // lstunicode
            // 
            this.lstunicode.FormattingEnabled = true;
            this.lstunicode.Location = new System.Drawing.Point(129, 121);
            this.lstunicode.Name = "lstunicode";
            this.lstunicode.Size = new System.Drawing.Size(174, 147);
            this.lstunicode.TabIndex = 2;
            // 
            // Unicode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(470, 309);
            this.Controls.Add(this.lstunicode);
            this.Controls.Add(this.btnsart);
            this.Name = "Unicode";
            this.Text = "unicode";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnsart;
        private System.Windows.Forms.ListBox lstunicode;
    }
}

