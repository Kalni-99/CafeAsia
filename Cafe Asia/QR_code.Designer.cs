using System;

namespace Cafe_Asia
{
    partial class QR_code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_code));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_encode = new Guna.UI2.WinForms.Guna2Button();
            this.btn_saveQR = new Guna.UI2.WinForms.Guna2Button();
            this.btn_decodeQR = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(405, 464);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(792, 38);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(612, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 324);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(8)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.iconPictureBox9);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 729);
            this.panel1.TabIndex = 5;
            // 
            // iconPictureBox9
            // 
            this.iconPictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(8)))), ((int)(((byte)(35)))));
            this.iconPictureBox9.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.iconPictureBox9.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox9.IconSize = 42;
            this.iconPictureBox9.Location = new System.Drawing.Point(33, 672);
            this.iconPictureBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox9.Name = "iconPictureBox9";
            this.iconPictureBox9.Size = new System.Drawing.Size(47, 42);
            this.iconPictureBox9.TabIndex = 15;
            this.iconPictureBox9.TabStop = false;
            this.iconPictureBox9.Click += new System.EventHandler(this.iconPictureBox9_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(20, 270);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(317, 246);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Genarate QR Code";
            // 
            // btn_encode
            // 
            this.btn_encode.CheckedState.Parent = this.btn_encode;
            this.btn_encode.CustomImages.Parent = this.btn_encode;
            this.btn_encode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(8)))), ((int)(((byte)(35)))));
            this.btn_encode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encode.ForeColor = System.Drawing.Color.White;
            this.btn_encode.HoverState.Parent = this.btn_encode;
            this.btn_encode.Location = new System.Drawing.Point(612, 523);
            this.btn_encode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_encode.Name = "btn_encode";
            this.btn_encode.ShadowDecoration.Parent = this.btn_encode;
            this.btn_encode.Size = new System.Drawing.Size(363, 41);
            this.btn_encode.TabIndex = 6;
            this.btn_encode.Text = "Encode QR Code";
            this.btn_encode.Click += new System.EventHandler(this.btn_encode_Click);
            // 
            // btn_saveQR
            // 
            this.btn_saveQR.CheckedState.Parent = this.btn_saveQR;
            this.btn_saveQR.CustomImages.Parent = this.btn_saveQR;
            this.btn_saveQR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(8)))), ((int)(((byte)(35)))));
            this.btn_saveQR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveQR.ForeColor = System.Drawing.Color.White;
            this.btn_saveQR.HoverState.Parent = this.btn_saveQR;
            this.btn_saveQR.Location = new System.Drawing.Point(612, 592);
            this.btn_saveQR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_saveQR.Name = "btn_saveQR";
            this.btn_saveQR.ShadowDecoration.Parent = this.btn_saveQR;
            this.btn_saveQR.Size = new System.Drawing.Size(363, 41);
            this.btn_saveQR.TabIndex = 10;
            this.btn_saveQR.Text = " Save QR Code To File";
            this.btn_saveQR.Click += new System.EventHandler(this.btn_saveQR_Click);
            // 
            // btn_decodeQR
            // 
            this.btn_decodeQR.CheckedState.Parent = this.btn_decodeQR;
            this.btn_decodeQR.CustomImages.Parent = this.btn_decodeQR;
            this.btn_decodeQR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(8)))), ((int)(((byte)(35)))));
            this.btn_decodeQR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decodeQR.ForeColor = System.Drawing.Color.White;
            this.btn_decodeQR.HoverState.Parent = this.btn_decodeQR;
            this.btn_decodeQR.Location = new System.Drawing.Point(612, 662);
            this.btn_decodeQR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_decodeQR.Name = "btn_decodeQR";
            this.btn_decodeQR.ShadowDecoration.Parent = this.btn_decodeQR;
            this.btn_decodeQR.Size = new System.Drawing.Size(363, 41);
            this.btn_decodeQR.TabIndex = 11;
            this.btn_decodeQR.Text = " Decode QR Code From File";
            this.btn_decodeQR.Click += new System.EventHandler(this.btn_decodeQR_Click);
            // 
            // QR_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1225, 729);
            this.Controls.Add(this.btn_decodeQR);
            this.Controls.Add(this.btn_saveQR);
            this.Controls.Add(this.btn_encode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QR_code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_encode;
        private Guna.UI2.WinForms.Guna2Button btn_saveQR;
        private Guna.UI2.WinForms.Guna2Button btn_decodeQR;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
    }
}

