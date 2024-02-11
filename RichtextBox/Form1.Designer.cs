namespace RichtextBox
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.citaj = new System.Windows.Forms.Button();
            this.brisi = new System.Windows.Forms.Button();
            this.spremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(147, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(499, 307);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // citaj
            // 
            this.citaj.Location = new System.Drawing.Point(23, 13);
            this.citaj.Name = "citaj";
            this.citaj.Size = new System.Drawing.Size(97, 32);
            this.citaj.TabIndex = 1;
            this.citaj.Text = "Citaj";
            this.citaj.UseVisualStyleBackColor = true;
            this.citaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // brisi
            // 
            this.brisi.Location = new System.Drawing.Point(652, 13);
            this.brisi.Name = "brisi";
            this.brisi.Size = new System.Drawing.Size(112, 32);
            this.brisi.TabIndex = 2;
            this.brisi.Text = "Brisi";
            this.brisi.UseVisualStyleBackColor = true;
            this.brisi.Click += new System.EventHandler(this.button2_Click);
            // 
            // spremi
            // 
            this.spremi.Location = new System.Drawing.Point(23, 396);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(97, 30);
            this.spremi.TabIndex = 3;
            this.spremi.Text = "Spremi";
            this.spremi.UseVisualStyleBackColor = true;
            this.spremi.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spremi);
            this.Controls.Add(this.brisi);
            this.Controls.Add(this.citaj);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button citaj;
        private System.Windows.Forms.Button brisi;
        private System.Windows.Forms.Button spremi;
    }
}

