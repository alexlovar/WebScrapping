namespace CarScraping
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
            this.buttonScrap0 = new System.Windows.Forms.Button();
            this.webBrowser0 = new System.Windows.Forms.WebBrowser();
            this.textBoxBasePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonScrap0
            // 
            this.buttonScrap0.Location = new System.Drawing.Point(247, 195);
            this.buttonScrap0.Name = "buttonScrap0";
            this.buttonScrap0.Size = new System.Drawing.Size(75, 23);
            this.buttonScrap0.TabIndex = 0;
            this.buttonScrap0.Text = "Start";
            this.buttonScrap0.UseVisualStyleBackColor = true;
            this.buttonScrap0.Click += new System.EventHandler(this.buttonScrap0_Click);
            // 
            // webBrowser0
            // 
            this.webBrowser0.Location = new System.Drawing.Point(24, 139);
            this.webBrowser0.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser0.Name = "webBrowser0";
            this.webBrowser0.Size = new System.Drawing.Size(548, 29);
            this.webBrowser0.TabIndex = 1;
            this.webBrowser0.Visible = false;
            // 
            // textBoxBasePath
            // 
            this.textBoxBasePath.Location = new System.Drawing.Point(116, 49);
            this.textBoxBasePath.Name = "textBoxBasePath";
            this.textBoxBasePath.Size = new System.Drawing.Size(384, 20);
            this.textBoxBasePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Store Path";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(506, 49);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(59, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "...Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(116, 94);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCountry.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 231);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBasePath);
            this.Controls.Add(this.webBrowser0);
            this.Controls.Add(this.buttonScrap0);
            this.Name = "FormMain";
            this.Text = "CarScraping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonScrap0;
        private System.Windows.Forms.WebBrowser webBrowser0;
        private System.Windows.Forms.TextBox textBoxBasePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label label2;
    }
}

