namespace Van_Gogh_Evolucional
{
    partial class form_MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_MainWindow));
            this.btn_LoadImage = new System.Windows.Forms.Button();
            this.picBox_metaImage = new System.Windows.Forms.PictureBox();
            this.btn_Manhattan = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.picBox_generatedImage = new System.Windows.Forms.PictureBox();
            this.btn_PremioNobel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_metaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_generatedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoadImage
            // 
            this.btn_LoadImage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_LoadImage.Location = new System.Drawing.Point(62, 320);
            this.btn_LoadImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(98, 32);
            this.btn_LoadImage.TabIndex = 0;
            this.btn_LoadImage.Text = "Load image";
            this.btn_LoadImage.UseVisualStyleBackColor = false;
            this.btn_LoadImage.Click += new System.EventHandler(this.btn_LoadImage_Click);
            // 
            // picBox_metaImage
            // 
            this.picBox_metaImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_metaImage.BackgroundImage")));
            this.picBox_metaImage.InitialImage = null;
            this.picBox_metaImage.Location = new System.Drawing.Point(62, 33);
            this.picBox_metaImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBox_metaImage.Name = "picBox_metaImage";
            this.picBox_metaImage.Size = new System.Drawing.Size(266, 266);
            this.picBox_metaImage.TabIndex = 1;
            this.picBox_metaImage.TabStop = false;
            // 
            // btn_Manhattan
            // 
            this.btn_Manhattan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Manhattan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Manhattan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Manhattan.Location = new System.Drawing.Point(394, 320);
            this.btn_Manhattan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Manhattan.Name = "btn_Manhattan";
            this.btn_Manhattan.Size = new System.Drawing.Size(98, 33);
            this.btn_Manhattan.TabIndex = 2;
            this.btn_Manhattan.Text = "Chino";
            this.btn_Manhattan.UseVisualStyleBackColor = false;
            this.btn_Manhattan.Click += new System.EventHandler(this.btn_Manhattan_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Cancel.Location = new System.Drawing.Point(230, 322);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(98, 32);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox_generatedImage
            // 
            this.picBox_generatedImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_generatedImage.BackgroundImage")));
            this.picBox_generatedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_generatedImage.InitialImage = null;
            this.picBox_generatedImage.Location = new System.Drawing.Point(394, 33);
            this.picBox_generatedImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBox_generatedImage.Name = "picBox_generatedImage";
            this.picBox_generatedImage.Size = new System.Drawing.Size(266, 266);
            this.picBox_generatedImage.TabIndex = 4;
            this.picBox_generatedImage.TabStop = false;
            // 
            // btn_PremioNobel
            // 
            this.btn_PremioNobel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_PremioNobel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PremioNobel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_PremioNobel.Location = new System.Drawing.Point(562, 322);
            this.btn_PremioNobel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_PremioNobel.Name = "btn_PremioNobel";
            this.btn_PremioNobel.Size = new System.Drawing.Size(98, 33);
            this.btn_PremioNobel.TabIndex = 5;
            this.btn_PremioNobel.Text = "PremioNobel";
            this.btn_PremioNobel.UseVisualStyleBackColor = false;
            // 
            // form_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 421);
            this.Controls.Add(this.btn_PremioNobel);
            this.Controls.Add(this.picBox_generatedImage);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Manhattan);
            this.Controls.Add(this.picBox_metaImage);
            this.Controls.Add(this.btn_LoadImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form_MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_metaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_generatedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.PictureBox picBox_metaImage;
        private System.Windows.Forms.Button btn_Manhattan;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.PictureBox picBox_generatedImage;
        private System.Windows.Forms.Button btn_PremioNobel;
    }
}

