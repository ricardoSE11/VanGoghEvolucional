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
            this.btn_GenerateImage = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.picBox_generatedImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_metaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_generatedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoadImage
            // 
            this.btn_LoadImage.Location = new System.Drawing.Point(83, 394);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(116, 49);
            this.btn_LoadImage.TabIndex = 0;
            this.btn_LoadImage.Text = "Load image";
            this.btn_LoadImage.UseVisualStyleBackColor = true;
            this.btn_LoadImage.Click += new System.EventHandler(this.btn_LoadImage_Click);
            // 
            // picBox_metaImage
            // 
            this.picBox_metaImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_metaImage.BackgroundImage")));
            this.picBox_metaImage.InitialImage = null;
            this.picBox_metaImage.Location = new System.Drawing.Point(83, 41);
            this.picBox_metaImage.Name = "picBox_metaImage";
            this.picBox_metaImage.Size = new System.Drawing.Size(354, 327);
            this.picBox_metaImage.TabIndex = 1;
            this.picBox_metaImage.TabStop = false;
            // 
            // btn_GenerateImage
            // 
            this.btn_GenerateImage.Image = ((System.Drawing.Image)(resources.GetObject("btn_GenerateImage.Image")));
            this.btn_GenerateImage.Location = new System.Drawing.Point(626, 394);
            this.btn_GenerateImage.Name = "btn_GenerateImage";
            this.btn_GenerateImage.Size = new System.Drawing.Size(161, 51);
            this.btn_GenerateImage.TabIndex = 2;
            this.btn_GenerateImage.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(321, 394);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(116, 49);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox_generatedImage
            // 
            this.picBox_generatedImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_generatedImage.BackgroundImage")));
            this.picBox_generatedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_generatedImage.InitialImage = null;
            this.picBox_generatedImage.Location = new System.Drawing.Point(526, 41);
            this.picBox_generatedImage.Name = "picBox_generatedImage";
            this.picBox_generatedImage.Size = new System.Drawing.Size(354, 327);
            this.picBox_generatedImage.TabIndex = 4;
            this.picBox_generatedImage.TabStop = false;
            // 
            // form_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 584);
            this.Controls.Add(this.picBox_generatedImage);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_GenerateImage);
            this.Controls.Add(this.picBox_metaImage);
            this.Controls.Add(this.btn_LoadImage);
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
        private System.Windows.Forms.Button btn_GenerateImage;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.PictureBox picBox_generatedImage;
    }
}

