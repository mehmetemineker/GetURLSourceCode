namespace GetURLSourceCode
{
    partial class FormMain
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
            this.buttonGetSourceCode = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSouceCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGetSourceCode
            // 
            this.buttonGetSourceCode.Location = new System.Drawing.Point(514, 51);
            this.buttonGetSourceCode.Name = "buttonGetSourceCode";
            this.buttonGetSourceCode.Size = new System.Drawing.Size(128, 23);
            this.buttonGetSourceCode.TabIndex = 0;
            this.buttonGetSourceCode.Text = "Get Source Code";
            this.buttonGetSourceCode.UseVisualStyleBackColor = true;
            this.buttonGetSourceCode.Click += new System.EventHandler(this.buttonGetSourceCode_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(15, 25);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(627, 20);
            this.textBoxUrl.TabIndex = 1;
            this.textBoxUrl.Text = "https://github.com/mehmetemineker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Url:";
            // 
            // textBoxSouceCode
            // 
            this.textBoxSouceCode.Location = new System.Drawing.Point(15, 80);
            this.textBoxSouceCode.Multiline = true;
            this.textBoxSouceCode.Name = "textBoxSouceCode";
            this.textBoxSouceCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSouceCode.Size = new System.Drawing.Size(627, 305);
            this.textBoxSouceCode.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 397);
            this.Controls.Add(this.textBoxSouceCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonGetSourceCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get URL Source Code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetSourceCode;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSouceCode;
    }
}

