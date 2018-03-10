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
            this.picBox_generatedImage = new System.Windows.Forms.PictureBox();
            this.btn_PremioNobel = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.lbl_CrossPrcnt = new System.Windows.Forms.Label();
            this.lbl_UglyDucks = new System.Windows.Forms.Label();
            this.lbl_GenesPrcnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_metaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_generatedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoadImage
            // 
            this.btn_LoadImage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_LoadImage.Location = new System.Drawing.Point(83, 394);
            this.btn_LoadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(131, 39);
            this.btn_LoadImage.TabIndex = 0;
            this.btn_LoadImage.Text = "Load image";
            this.btn_LoadImage.UseVisualStyleBackColor = false;
            this.btn_LoadImage.Click += new System.EventHandler(this.btn_LoadImage_Click);
            // 
            // picBox_metaImage
            // 
            this.picBox_metaImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_metaImage.BackgroundImage")));
            this.picBox_metaImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_metaImage.InitialImage = null;
            this.picBox_metaImage.Location = new System.Drawing.Point(83, 41);
            this.picBox_metaImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_metaImage.Name = "picBox_metaImage";
            this.picBox_metaImage.Size = new System.Drawing.Size(355, 327);
            this.picBox_metaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_metaImage.TabIndex = 1;
            this.picBox_metaImage.TabStop = false;
            // 
            // btn_Manhattan
            // 
            this.btn_Manhattan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Manhattan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Manhattan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Manhattan.Location = new System.Drawing.Point(525, 394);
            this.btn_Manhattan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Manhattan.Name = "btn_Manhattan";
            this.btn_Manhattan.Size = new System.Drawing.Size(131, 41);
            this.btn_Manhattan.TabIndex = 2;
            this.btn_Manhattan.Text = "Manhattan";
            this.btn_Manhattan.UseVisualStyleBackColor = false;
            this.btn_Manhattan.Click += new System.EventHandler(this.btn_Manhattan_Click);
            // 
            // picBox_generatedImage
            // 
            this.picBox_generatedImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_generatedImage.BackgroundImage")));
            this.picBox_generatedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_generatedImage.InitialImage = null;
            this.picBox_generatedImage.Location = new System.Drawing.Point(525, 41);
            this.picBox_generatedImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_generatedImage.Name = "picBox_generatedImage";
            this.picBox_generatedImage.Size = new System.Drawing.Size(355, 327);
            this.picBox_generatedImage.TabIndex = 4;
            this.picBox_generatedImage.TabStop = false;
            // 
            // btn_PremioNobel
            // 
            this.btn_PremioNobel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_PremioNobel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PremioNobel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_PremioNobel.Location = new System.Drawing.Point(749, 396);
            this.btn_PremioNobel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PremioNobel.Name = "btn_PremioNobel";
            this.btn_PremioNobel.Size = new System.Drawing.Size(131, 41);
            this.btn_PremioNobel.TabIndex = 5;
            this.btn_PremioNobel.Text = "PremioNobel";
            this.btn_PremioNobel.UseVisualStyleBackColor = false;
            this.btn_PremioNobel.Click += new System.EventHandler(this.btn_PremioNobel_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Cancelar.Location = new System.Drawing.Point(307, 394);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(131, 39);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancel";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(563, 458);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(591, 509);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(812, 461);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(829, 512);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 22);
            this.textBox4.TabIndex = 10;
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Location = new System.Drawing.Point(522, 461);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(35, 17);
            this.lbl_Size.TabIndex = 11;
            this.lbl_Size.Text = "Size";
            this.lbl_Size.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_CrossPrcnt
            // 
            this.lbl_CrossPrcnt.AutoSize = true;
            this.lbl_CrossPrcnt.Location = new System.Drawing.Point(746, 461);
            this.lbl_CrossPrcnt.Name = "lbl_CrossPrcnt";
            this.lbl_CrossPrcnt.Size = new System.Drawing.Size(60, 17);
            this.lbl_CrossPrcnt.TabIndex = 12;
            this.lbl_CrossPrcnt.Text = "Cross %";
            // 
            // lbl_UglyDucks
            // 
            this.lbl_UglyDucks.AutoSize = true;
            this.lbl_UglyDucks.Location = new System.Drawing.Point(746, 512);
            this.lbl_UglyDucks.Name = "lbl_UglyDucks";
            this.lbl_UglyDucks.Size = new System.Drawing.Size(77, 17);
            this.lbl_UglyDucks.TabIndex = 13;
            this.lbl_UglyDucks.Text = "Ugly ducks";
            // 
            // lbl_GenesPrcnt
            // 
            this.lbl_GenesPrcnt.AutoSize = true;
            this.lbl_GenesPrcnt.Location = new System.Drawing.Point(522, 512);
            this.lbl_GenesPrcnt.Name = "lbl_GenesPrcnt";
            this.lbl_GenesPrcnt.Size = new System.Drawing.Size(62, 17);
            this.lbl_GenesPrcnt.TabIndex = 14;
            this.lbl_GenesPrcnt.Text = "Genes%";
            // 
            // form_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 559);
            this.Controls.Add(this.lbl_GenesPrcnt);
            this.Controls.Add(this.lbl_UglyDucks);
            this.Controls.Add(this.lbl_CrossPrcnt);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_PremioNobel);
            this.Controls.Add(this.picBox_generatedImage);
            this.Controls.Add(this.btn_Manhattan);
            this.Controls.Add(this.picBox_metaImage);
            this.Controls.Add(this.btn_LoadImage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_metaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_generatedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.PictureBox picBox_metaImage;
        private System.Windows.Forms.Button btn_Manhattan;
        private System.Windows.Forms.PictureBox picBox_generatedImage;
        private System.Windows.Forms.Button btn_PremioNobel;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Label lbl_CrossPrcnt;
        private System.Windows.Forms.Label lbl_UglyDucks;
        private System.Windows.Forms.Label lbl_GenesPrcnt;
    }
}

