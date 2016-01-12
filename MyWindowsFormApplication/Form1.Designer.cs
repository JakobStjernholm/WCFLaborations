namespace MyWindowsFormApplication
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
            this.numberOne = new System.Windows.Forms.NumericUpDown();
            this.numberTwo = new System.Windows.Forms.NumericUpDown();
            this.twoNumberBtn = new System.Windows.Forms.Button();
            this.twoNumberResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTwo)).BeginInit();
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
            this.labelWeather.Size = new System.Drawing.Size(0, 17);
            this.labelWeather.TabIndex = 1;
            // 
            // numberOne
            // 
            this.numberOne.Location = new System.Drawing.Point(29, 95);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(67, 22);
            this.numberOne.TabIndex = 2;
            // 
            // numberTwo
            // 
            this.numberTwo.Location = new System.Drawing.Point(113, 95);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(67, 22);
            this.numberTwo.TabIndex = 4;
            // 
            // twoNumberBtn
            // 
            this.twoNumberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoNumberBtn.Location = new System.Drawing.Point(64, 123);
            this.twoNumberBtn.Name = "twoNumberBtn";
            this.twoNumberBtn.Size = new System.Drawing.Size(75, 30);
            this.twoNumberBtn.TabIndex = 5;
            this.twoNumberBtn.Text = "=";
            this.twoNumberBtn.UseVisualStyleBackColor = true;
            this.twoNumberBtn.Click += new System.EventHandler(this.twoNumberBtn_Click);
            // 
            // twoNumberResult
            // 
            this.twoNumberResult.AutoSize = true;
            this.twoNumberResult.Location = new System.Drawing.Point(96, 156);
            this.twoNumberResult.Name = "twoNumberResult";
            this.twoNumberResult.Size = new System.Drawing.Size(0, 17);
            this.twoNumberResult.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "2.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.twoNumberResult);
            this.Controls.Add(this.twoNumberBtn);
            this.Controls.Add(this.numberTwo);
            this.Controls.Add(this.numberOne);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.buttonWeather);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWeather;
        private System.Windows.Forms.Label labelWeather;
        private System.Windows.Forms.NumericUpDown numberOne;
        private System.Windows.Forms.NumericUpDown numberTwo;
        private System.Windows.Forms.Button twoNumberBtn;
        private System.Windows.Forms.Label twoNumberResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

