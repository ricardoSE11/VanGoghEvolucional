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
            this.txtbox_size = new System.Windows.Forms.TextBox();
            this.txtb_genes = new System.Windows.Forms.TextBox();
            this.txtb_cross = new System.Windows.Forms.TextBox();
            this.txtb_uducks = new System.Windows.Forms.TextBox();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.lbl_CrossPrcnt = new System.Windows.Forms.Label();
            this.lbl_UglyDucks = new System.Windows.Forms.Label();
            this.lbl_GenesPrcnt = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.txtb_amount = new System.Windows.Forms.TextBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.picBox_test = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_metaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_generatedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_test)).BeginInit();
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
            this.picBox_metaImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_metaImage.InitialImage = null;
            this.picBox_metaImage.Location = new System.Drawing.Point(62, 33);
            this.picBox_metaImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBox_metaImage.Name = "picBox_metaImage";
            this.picBox_metaImage.Size = new System.Drawing.Size(266, 266);
            this.picBox_metaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.btn_Manhattan.Text = "Manhattan";
            this.btn_Manhattan.UseVisualStyleBackColor = false;
            this.btn_Manhattan.Click += new System.EventHandler(this.btn_Manhattan_Click);
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
            this.btn_PremioNobel.Click += new System.EventHandler(this.btn_PremioNobel_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Cancelar.Location = new System.Drawing.Point(230, 320);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(98, 32);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancel";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txtbox_size
            // 
            this.txtbox_size.Location = new System.Drawing.Point(422, 372);
            this.txtbox_size.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_size.Name = "txtbox_size";
            this.txtbox_size.Size = new System.Drawing.Size(71, 20);
            this.txtbox_size.TabIndex = 7;
            // 
            // txtb_genes
            // 
            this.txtb_genes.Location = new System.Drawing.Point(443, 453);
            this.txtb_genes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb_genes.Name = "txtb_genes";
            this.txtb_genes.Size = new System.Drawing.Size(50, 20);
            this.txtb_genes.TabIndex = 8;
            // 
            // txtb_cross
            // 
            this.txtb_cross.Location = new System.Drawing.Point(609, 375);
            this.txtb_cross.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb_cross.Name = "txtb_cross";
            this.txtb_cross.Size = new System.Drawing.Size(52, 20);
            this.txtb_cross.TabIndex = 9;
            this.txtb_cross.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtb_uducks
            // 
            this.txtb_uducks.Location = new System.Drawing.Point(622, 416);
            this.txtb_uducks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb_uducks.Name = "txtb_uducks";
            this.txtb_uducks.Size = new System.Drawing.Size(39, 20);
            this.txtb_uducks.TabIndex = 10;
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Location = new System.Drawing.Point(392, 375);
            this.lbl_Size.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(27, 13);
            this.lbl_Size.TabIndex = 11;
            this.lbl_Size.Text = "Size";
            this.lbl_Size.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_CrossPrcnt
            // 
            this.lbl_CrossPrcnt.AutoSize = true;
            this.lbl_CrossPrcnt.Location = new System.Drawing.Point(560, 375);
            this.lbl_CrossPrcnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CrossPrcnt.Name = "lbl_CrossPrcnt";
            this.lbl_CrossPrcnt.Size = new System.Drawing.Size(44, 13);
            this.lbl_CrossPrcnt.TabIndex = 12;
            this.lbl_CrossPrcnt.Text = "Cross %";
            // 
            // lbl_UglyDucks
            // 
            this.lbl_UglyDucks.AutoSize = true;
            this.lbl_UglyDucks.Location = new System.Drawing.Point(560, 416);
            this.lbl_UglyDucks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UglyDucks.Name = "lbl_UglyDucks";
            this.lbl_UglyDucks.Size = new System.Drawing.Size(60, 13);
            this.lbl_UglyDucks.TabIndex = 13;
            this.lbl_UglyDucks.Text = "Ugly ducks";
            // 
            // lbl_GenesPrcnt
            // 
            this.lbl_GenesPrcnt.AutoSize = true;
            this.lbl_GenesPrcnt.Location = new System.Drawing.Point(392, 456);
            this.lbl_GenesPrcnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GenesPrcnt.Name = "lbl_GenesPrcnt";
            this.lbl_GenesPrcnt.Size = new System.Drawing.Size(46, 13);
            this.lbl_GenesPrcnt.TabIndex = 14;
            this.lbl_GenesPrcnt.Text = "Genes%";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(392, 414);
            this.lbl_Amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_Amount.TabIndex = 15;
            this.lbl_Amount.Text = "Amount";
            // 
            // txtb_amount
            // 
            this.txtb_amount.Location = new System.Drawing.Point(439, 414);
            this.txtb_amount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb_amount.Name = "txtb_amount";
            this.txtb_amount.Size = new System.Drawing.Size(54, 20);
            this.txtb_amount.TabIndex = 16;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(62, 358);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(98, 30);
            this.btn_test.TabIndex = 17;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox_test
            // 
            this.picBox_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_test.InitialImage = null;
            this.picBox_test.Location = new System.Drawing.Point(710, 309);
            this.picBox_test.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_test.Name = "picBox_test";
            this.picBox_test.Size = new System.Drawing.Size(220, 236);
            this.picBox_test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_test.TabIndex = 18;
            this.picBox_test.TabStop = false;
            // 
            // form_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 556);
            this.Controls.Add(this.picBox_test);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.txtb_amount);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_GenesPrcnt);
            this.Controls.Add(this.lbl_UglyDucks);
            this.Controls.Add(this.lbl_CrossPrcnt);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.txtb_uducks);
            this.Controls.Add(this.txtb_cross);
            this.Controls.Add(this.txtb_genes);
            this.Controls.Add(this.txtbox_size);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_PremioNobel);
            this.Controls.Add(this.picBox_generatedImage);
            this.Controls.Add(this.btn_Manhattan);
            this.Controls.Add(this.picBox_metaImage);
            this.Controls.Add(this.btn_LoadImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form_MainWindow";
            this.Text = "Van Gogh Evolucional";
            this.Load += new System.EventHandler(this.form_MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_metaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_generatedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_test)).EndInit();
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
        private System.Windows.Forms.TextBox txtbox_size;
        private System.Windows.Forms.TextBox txtb_genes;
        private System.Windows.Forms.TextBox txtb_cross;
        private System.Windows.Forms.TextBox txtb_uducks;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Label lbl_CrossPrcnt;
        private System.Windows.Forms.Label lbl_UglyDucks;
        private System.Windows.Forms.Label lbl_GenesPrcnt;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.TextBox txtb_amount;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.PictureBox picBox_test;
    }
}

