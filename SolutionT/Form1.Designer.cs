using System.Windows.Forms;

namespace TankS
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.AntalTryk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nulstil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(159, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(141, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 111);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hold nede";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // AntalTryk
            // 
            this.AntalTryk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AntalTryk.Dock = System.Windows.Forms.DockStyle.Top;
            this.AntalTryk.Location = new System.Drawing.Point(0, 0);
            this.AntalTryk.Name = "AntalTryk";
            this.AntalTryk.Size = new System.Drawing.Size(590, 64);
            this.AntalTryk.TabIndex = 4;
            this.AntalTryk.Text = "Antal Tryk: 0";
            this.AntalTryk.Click += new System.EventHandler(this.AntalTryk_Click);
            // 

            // label2
            // 
            this.label2.Location = new System.Drawing.Point(129, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hold knappen nede og giv slip for at ramme 100.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(590, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AntalTryk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label AntalTryk;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button button1;

        // private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;


       

        #endregion
    }
}