﻿namespace MyWindowsFormApplication
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
            this.buttonWeather = new System.Windows.Forms.Button();
            this.labelWeather = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonWeather
            // 
            this.buttonWeather.Location = new System.Drawing.Point(27, 24);
            this.buttonWeather.Name = "buttonWeather";
            this.buttonWeather.Size = new System.Drawing.Size(211, 31);
            this.buttonWeather.TabIndex = 0;
            this.buttonWeather.Text = "What wheater is it tomorrow?";
            this.buttonWeather.UseVisualStyleBackColor = true;
            this.buttonWeather.Click += new System.EventHandler(this.buttonWeather_Click);
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Location = new System.Drawing.Point(278, 31);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(46, 17);
            this.labelWeather.TabIndex = 1;
            this.labelWeather.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 511);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.buttonWeather);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWeather;
        private System.Windows.Forms.Label labelWeather;
    }
}

