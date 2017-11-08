namespace PlakaTanima
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plakaText = new System.Windows.Forms.ListBox();
            this.aracPic = new System.Windows.Forms.PictureBox();
            this.plakaResim = new System.Windows.Forms.PictureBox();
            this.plakaBul = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.plakaYaz = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aracPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plakaResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F);
            this.label3.Location = new System.Drawing.Point(670, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Okunan Plakalar;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F);
            this.label2.Location = new System.Drawing.Point(669, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Plaka Resmi;";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F);
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Araç Resmi;";
            // 
            // plakaText
            // 
            this.plakaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plakaText.FormattingEnabled = true;
            this.plakaText.ItemHeight = 17;
            this.plakaText.Location = new System.Drawing.Point(670, 106);
            this.plakaText.Name = "plakaText";
            this.plakaText.Size = new System.Drawing.Size(294, 89);
            this.plakaText.TabIndex = 13;
            // 
            // aracPic
            // 
            this.aracPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aracPic.Location = new System.Drawing.Point(10, 33);
            this.aracPic.Name = "aracPic";
            this.aracPic.Size = new System.Drawing.Size(653, 501);
            this.aracPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aracPic.TabIndex = 12;
            this.aracPic.TabStop = false;
            // 
            // plakaResim
            // 
            this.plakaResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plakaResim.Location = new System.Drawing.Point(666, 417);
            this.plakaResim.Name = "plakaResim";
            this.plakaResim.Size = new System.Drawing.Size(294, 117);
            this.plakaResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plakaResim.TabIndex = 11;
            this.plakaResim.TabStop = false;
            // 
            // plakaBul
            // 
            this.plakaBul.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F);
            this.plakaBul.Location = new System.Drawing.Point(670, 33);
            this.plakaBul.Name = "plakaBul";
            this.plakaBul.Size = new System.Drawing.Size(291, 37);
            this.plakaBul.TabIndex = 10;
            this.plakaBul.Text = "Plakayı Bul";
            this.plakaBul.UseVisualStyleBackColor = true;
            this.plakaBul.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png|All files (*.*)|*.*";
            // 
            // plakaYaz
            // 
            this.plakaYaz.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plakaYaz.Location = new System.Drawing.Point(670, 257);
            this.plakaYaz.Name = "plakaYaz";
            this.plakaYaz.ReadOnly = true;
            this.plakaYaz.Size = new System.Drawing.Size(294, 82);
            this.plakaYaz.TabIndex = 17;
            this.plakaYaz.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F);
            this.label4.Location = new System.Drawing.Point(673, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Plaka Yazısı;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plakaYaz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plakaText);
            this.Controls.Add(this.aracPic);
            this.Controls.Add(this.plakaResim);
            this.Controls.Add(this.plakaBul);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Plaka Tespit";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.aracPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plakaResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox plakaText;
        private System.Windows.Forms.PictureBox aracPic;
        private System.Windows.Forms.PictureBox plakaResim;
        private System.Windows.Forms.Button plakaBul;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox plakaYaz;
        private System.Windows.Forms.Label label4;
    }
}

