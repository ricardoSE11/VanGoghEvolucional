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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_GenerateImage = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(83, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 327);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_GenerateImage
            // 
            this.btn_GenerateImage.Location = new System.Drawing.Point(169, 471);
            this.btn_GenerateImage.Name = "btn_GenerateImage";
            this.btn_GenerateImage.Size = new System.Drawing.Size(161, 51);
            this.btn_GenerateImage.TabIndex = 2;
            this.btn_GenerateImage.Text = "Generate image";
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
            // form_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 551);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_GenerateImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_LoadImage);
            this.Name = "form_MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_GenerateImage;
        private System.Windows.Forms.Button btn_Cancel;
    }
}

