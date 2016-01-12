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
            this.label3 = new System.Windows.Forms.Label();
            this.resultAddingThree = new System.Windows.Forms.Label();
            this.btnResultAddingThree = new System.Windows.Forms.Button();
            this.numericNumberTwo = new System.Windows.Forms.NumericUpDown();
            this.numericNumberOne = new System.Windows.Forms.NumericUpDown();
            this.numericNumberThree = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
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
            this.numberOne.Location = new System.Drawing.Point(58, 95);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(67, 22);
            this.numberOne.TabIndex = 2;
            // 
            // numberTwo
            // 
            this.numberTwo.Location = new System.Drawing.Point(142, 95);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(67, 22);
            this.numberTwo.TabIndex = 4;
            // 
            // twoNumberBtn
            // 
            this.twoNumberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoNumberBtn.Location = new System.Drawing.Point(93, 123);
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
            this.twoNumberResult.Location = new System.Drawing.Point(125, 156);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "3.";
            // 
            // resultAddingThree
            // 
            this.resultAddingThree.AutoSize = true;
            this.resultAddingThree.Location = new System.Drawing.Point(168, 246);
            this.resultAddingThree.Name = "resultAddingThree";
            this.resultAddingThree.Size = new System.Drawing.Size(0, 17);
            this.resultAddingThree.TabIndex = 12;
            // 
            // btnResultAddingThree
            // 
            this.btnResultAddingThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultAddingThree.Location = new System.Drawing.Point(142, 204);
            this.btnResultAddingThree.Name = "btnResultAddingThree";
            this.btnResultAddingThree.Size = new System.Drawing.Size(67, 30);
            this.btnResultAddingThree.TabIndex = 11;
            this.btnResultAddingThree.Text = "=";
            this.btnResultAddingThree.UseVisualStyleBackColor = true;
            this.btnResultAddingThree.Click += new System.EventHandler(this.btnResultAddingThree_Click);
            // 
            // numericNumberTwo
            // 
            this.numericNumberTwo.Location = new System.Drawing.Point(0, 0);
            this.numericNumberTwo.Name = "numericNumberTwo";
            this.numericNumberTwo.Size = new System.Drawing.Size(120, 22);
            this.numericNumberTwo.TabIndex = 0;
            // 
            // numericNumberOne
            // 
            this.numericNumberOne.Location = new System.Drawing.Point(0, 0);
            this.numericNumberOne.Name = "numericNumberOne";
            this.numericNumberOne.Size = new System.Drawing.Size(120, 22);
            this.numericNumberOne.TabIndex = 0;
            // 
            // numericNumberThree
            // 
            this.numericNumberThree.Location = new System.Drawing.Point(0, 0);
            this.numericNumberThree.Name = "numericNumberThree";
            this.numericNumberThree.Size = new System.Drawing.Size(120, 22);
            this.numericNumberThree.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "+";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(234, 176);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown1.TabIndex = 18;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(142, 176);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown2.TabIndex = 19;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(52, 176);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown3.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 511);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultAddingThree);
            this.Controls.Add(this.btnResultAddingThree);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultAddingThree;
        private System.Windows.Forms.Button btnResultAddingThree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericNumberThree;
        private System.Windows.Forms.NumericUpDown numericNumberOne;
        private System.Windows.Forms.NumericUpDown numericNumberTwo;
    }
}

