﻿namespace AtYarisi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnStart = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1161, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(0, 147);
            label2.Name = "label2";
            label2.Size = new Size(1161, 25);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(0, 298);
            label3.Name = "label3";
            label3.Size = new Size(1161, 25);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(0, 439);
            label4.Name = "label4";
            label4.Size = new Size(1161, 25);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(1161, 0);
            label5.Name = "label5";
            label5.Size = new Size(25, 464);
            label5.TabIndex = 4;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(12, 508);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(101, 62);
            btnStart.TabIndex = 5;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.horse1;
            pictureBox1.Location = new Point(0, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.horse2;
            pictureBox2.Location = new Point(0, 192);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resource1.horse3;
            pictureBox3.Location = new Point(0, 336);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(449, 522);
            label6.Name = "label6";
            label6.Size = new Size(115, 35);
            label6.TabIndex = 9;
            label6.Text = "Winner :";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(1069, 508);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(101, 62);
            btnReset.TabIndex = 10;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1182, 608);
            Controls.Add(btnReset);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnStart);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnStart;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private Button btnReset;
    }
}