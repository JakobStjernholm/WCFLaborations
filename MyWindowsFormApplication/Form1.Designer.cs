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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resultSubtract = new System.Windows.Forms.Label();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.txbTypeName = new System.Windows.Forms.TextBox();
            this.btnGetDate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGetDate = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxFromYear = new System.Windows.Forms.ComboBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.comboBoxToYear = new System.Windows.Forms.ComboBox();
            this.buttonGetCandidates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "4.";
            // 
            // resultSubtract
            // 
            this.resultSubtract.AutoSize = true;
            this.resultSubtract.Location = new System.Drawing.Point(125, 327);
            this.resultSubtract.Name = "resultSubtract";
            this.resultSubtract.Size = new System.Drawing.Size(0, 17);
            this.resultSubtract.TabIndex = 24;
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.Location = new System.Drawing.Point(93, 294);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(75, 30);
            this.buttonSubtract.TabIndex = 23;
            this.buttonSubtract.Text = "=";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(142, 266);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown4.TabIndex = 22;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(58, 266);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown5.TabIndex = 21;
            // 
            // txbTypeName
            // 
            this.txbTypeName.Location = new System.Drawing.Point(437, 24);
            this.txbTypeName.Name = "txbTypeName";
            this.txbTypeName.Size = new System.Drawing.Size(205, 22);
            this.txbTypeName.TabIndex = 27;
            // 
            // btnGetDate
            // 
            this.btnGetDate.Location = new System.Drawing.Point(649, 22);
            this.btnGetDate.Name = "btnGetDate";
            this.btnGetDate.Size = new System.Drawing.Size(92, 23);
            this.btnGetDate.TabIndex = 28;
            this.btnGetDate.Text = "Get date";
            this.btnGetDate.UseVisualStyleBackColor = true;
            this.btnGetDate.Click += new System.EventHandler(this.btnGetDate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "5.";
            // 
            // lblGetDate
            // 
            this.lblGetDate.AutoSize = true;
            this.lblGetDate.Location = new System.Drawing.Point(434, 58);
            this.lblGetDate.Name = "lblGetDate";
            this.lblGetDate.Size = new System.Drawing.Size(0, 17);
            this.lblGetDate.TabIndex = 30;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(437, 160);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 94);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1861",
            "1862",
            "1863",
            "1864",
            "1865"});
            this.comboBox1.Location = new System.Drawing.Point(437, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 24);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "6.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(327, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Amerikanska slag under inbördeskriget 1861-1865";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(273, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Välj årtal för att se alla slagen från de året";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(434, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(273, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "Republikanska kandidater i Presidentvalet";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(402, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "6.";
            // 
            // comboBoxFromYear
            // 
            this.comboBoxFromYear.FormattingEnabled = true;
            this.comboBoxFromYear.Items.AddRange(new object[] {
            "1861",
            "1862",
            "1863",
            "1864",
            "1865"});
            this.comboBoxFromYear.Location = new System.Drawing.Point(437, 294);
            this.comboBoxFromYear.Name = "comboBoxFromYear";
            this.comboBoxFromYear.Size = new System.Drawing.Size(87, 24);
            this.comboBoxFromYear.TabIndex = 37;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(437, 327);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(470, 172);
            this.listView2.TabIndex = 36;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // comboBoxToYear
            // 
            this.comboBoxToYear.FormattingEnabled = true;
            this.comboBoxToYear.Items.AddRange(new object[] {
            "1861",
            "1862",
            "1863",
            "1864",
            "1865"});
            this.comboBoxToYear.Location = new System.Drawing.Point(574, 294);
            this.comboBoxToYear.Name = "comboBoxToYear";
            this.comboBoxToYear.Size = new System.Drawing.Size(87, 24);
            this.comboBoxToYear.TabIndex = 41;
            // 
            // buttonGetCandidates
            // 
            this.buttonGetCandidates.Location = new System.Drawing.Point(667, 292);
            this.buttonGetCandidates.Name = "buttonGetCandidates";
            this.buttonGetCandidates.Size = new System.Drawing.Size(149, 27);
            this.buttonGetCandidates.TabIndex = 42;
            this.buttonGetCandidates.Text = "Get Candidates";
            this.buttonGetCandidates.UseVisualStyleBackColor = true;
            this.buttonGetCandidates.Click += new System.EventHandler(this.buttonGetCandidates_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 511);
            this.Controls.Add(this.buttonGetCandidates);
            this.Controls.Add(this.comboBoxToYear);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxFromYear);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblGetDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGetDate);
            this.Controls.Add(this.txbTypeName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resultSubtract);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown5);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label resultSubtract;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.TextBox txbTypeName;
        private System.Windows.Forms.Button btnGetDate;
        private System.Windows.Forms.Label lblGetDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxFromYear;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ComboBox comboBoxToYear;
        private System.Windows.Forms.Button buttonGetCandidates;
    }
}

