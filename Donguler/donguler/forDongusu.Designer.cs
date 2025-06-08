namespace donguler
{
    partial class forDongusu
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
            this.ankara = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sayilar = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ankara
            // 
            this.ankara.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ankara.FormattingEnabled = true;
            this.ankara.ItemHeight = 29;
            this.ankara.Location = new System.Drawing.Point(12, 12);
            this.ankara.Name = "ankara";
            this.ankara.Size = new System.Drawing.Size(343, 410);
            this.ankara.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(80, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sayilar
            // 
            this.sayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayilar.FormattingEnabled = true;
            this.sayilar.ItemHeight = 29;
            this.sayilar.Location = new System.Drawing.Point(385, 12);
            this.sayilar.Name = "sayilar";
            this.sayilar.Size = new System.Drawing.Size(343, 410);
            this.sayilar.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(461, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "Yazdır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // forDongusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(957, 557);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sayilar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ankara);
            this.Name = "forDongusu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ankara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox sayilar;
        private System.Windows.Forms.Button button2;
    }
}

