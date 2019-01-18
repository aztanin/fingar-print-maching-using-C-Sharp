namespace Fingure_print
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnChoosePic1 = new System.Windows.Forms.Button();
            this.btnChoosePic2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(25, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(433, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 267);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // BtnCheck
            // 
            this.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCheck.Location = new System.Drawing.Point(581, 606);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 23);
            this.BtnCheck.TabIndex = 2;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnChoosePic1
            // 
            this.BtnChoosePic1.Location = new System.Drawing.Point(25, 12);
            this.BtnChoosePic1.Name = "BtnChoosePic1";
            this.BtnChoosePic1.Size = new System.Drawing.Size(223, 23);
            this.BtnChoosePic1.TabIndex = 3;
            this.BtnChoosePic1.Text = "Choose Print1";
            this.BtnChoosePic1.UseVisualStyleBackColor = true;
            this.BtnChoosePic1.Click += new System.EventHandler(this.BtnChoosePic1_Click);
            // 
            // btnChoosePic2
            // 
            this.btnChoosePic2.Location = new System.Drawing.Point(433, 12);
            this.btnChoosePic2.Name = "btnChoosePic2";
            this.btnChoosePic2.Size = new System.Drawing.Size(223, 23);
            this.btnChoosePic2.TabIndex = 4;
            this.btnChoosePic2.Text = "Choose Print2";
            this.btnChoosePic2.UseVisualStyleBackColor = true;
            this.btnChoosePic2.Click += new System.EventHandler(this.btnChoosePic2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChoosePic2);
            this.Controls.Add(this.BtnChoosePic1);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnChoosePic1;
        private System.Windows.Forms.Button btnChoosePic2;
        private System.Windows.Forms.Label label1;
    }
}

