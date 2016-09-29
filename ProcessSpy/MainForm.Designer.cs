namespace ProcessSpy
{
    partial class MainForm
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
            this.rtbProcessFilename = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbProcessFilename
            // 
            this.rtbProcessFilename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbProcessFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbProcessFilename.Location = new System.Drawing.Point(0, 0);
            this.rtbProcessFilename.Name = "rtbProcessFilename";
            this.rtbProcessFilename.Size = new System.Drawing.Size(505, 94);
            this.rtbProcessFilename.TabIndex = 0;
            this.rtbProcessFilename.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 94);
            this.Controls.Add(this.rtbProcessFilename);
            this.Icon = global::ProcessSpy.Properties.Resources.spider;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Process Spy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbProcessFilename;
    }
}

