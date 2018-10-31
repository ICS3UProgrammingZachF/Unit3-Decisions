namespace DoWhileLoop
{
    partial class DoWhileLoop
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
            this.txtdowhile = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.lstDo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblanwser = new System.Windows.Forms.Label();
            this.mnnuclose = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnnuclose.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdowhile
            // 
            this.txtdowhile.Location = new System.Drawing.Point(231, 68);
            this.txtdowhile.Name = "txtdowhile";
            this.txtdowhile.Size = new System.Drawing.Size(100, 20);
            this.txtdowhile.TabIndex = 0;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(376, 65);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lstDo
            // 
            this.lstDo.FormattingEnabled = true;
            this.lstDo.Location = new System.Drawing.Point(231, 127);
            this.lstDo.Name = "lstDo";
            this.lstDo.Size = new System.Drawing.Size(120, 95);
            this.lstDo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "enter number here:";
            // 
            // lblanwser
            // 
            this.lblanwser.AutoSize = true;
            this.lblanwser.Location = new System.Drawing.Point(274, 266);
            this.lblanwser.Name = "lblanwser";
            this.lblanwser.Size = new System.Drawing.Size(35, 13);
            this.lblanwser.TabIndex = 4;
            this.lblanwser.Text = "label2";
            // 
            // mnnuclose
            // 
            this.mnnuclose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnnuclose.Location = new System.Drawing.Point(0, 0);
            this.mnnuclose.Name = "mnnuclose";
            this.mnnuclose.Size = new System.Drawing.Size(605, 24);
            this.mnnuclose.TabIndex = 5;
            this.mnnuclose.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DoWhileLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 397);
            this.Controls.Add(this.lblanwser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDo);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.txtdowhile);
            this.Controls.Add(this.mnnuclose);
            this.MainMenuStrip = this.mnnuclose;
            this.Name = "DoWhileLoop";
            this.Text = "Do while loop";
            this.mnnuclose.ResumeLayout(false);
            this.mnnuclose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdowhile;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.ListBox lstDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblanwser;
        private System.Windows.Forms.MenuStrip mnnuclose;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

