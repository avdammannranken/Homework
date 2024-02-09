namespace CalculateInvestment
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
            groupBox1 = new GroupBox();
            radFutureValue = new RadioButton();
            radMonthlyInvestment = new RadioButton();
            lblMonthlyInvestment = new Label();
            lblYearlyInvestmentRate = new Label();
            lblNumberOfYears = new Label();
            lblFutureValues = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            btnCalculate = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radMonthlyInvestment);
            groupBox1.Controls.Add(radFutureValue);
            groupBox1.Font = new Font("Verdana", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculate";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radFutureValue
            // 
            radFutureValue.AutoSize = true;
            radFutureValue.Location = new Point(77, 40);
            radFutureValue.Name = "radFutureValue";
            radFutureValue.Size = new Size(130, 22);
            radFutureValue.TabIndex = 0;
            radFutureValue.TabStop = true;
            radFutureValue.Text = "Future Value";
            radFutureValue.UseVisualStyleBackColor = true;
            // 
            // radMonthlyInvestment
            // 
            radMonthlyInvestment.AutoSize = true;
            radMonthlyInvestment.Location = new Point(480, 40);
            radMonthlyInvestment.Name = "radMonthlyInvestment";
            radMonthlyInvestment.Size = new Size(193, 22);
            radMonthlyInvestment.TabIndex = 1;
            radMonthlyInvestment.TabStop = true;
            radMonthlyInvestment.Text = "Monthly Investment";
            radMonthlyInvestment.UseVisualStyleBackColor = true;
            // 
            // lblMonthlyInvestment
            // 
            lblMonthlyInvestment.AutoSize = true;
            lblMonthlyInvestment.Location = new Point(77, 195);
            lblMonthlyInvestment.Name = "lblMonthlyInvestment";
            lblMonthlyInvestment.Size = new Size(114, 15);
            lblMonthlyInvestment.TabIndex = 1;
            lblMonthlyInvestment.Text = "Monthly Investment";
            // 
            // lblYearlyInvestmentRate
            // 
            lblYearlyInvestmentRate.AutoSize = true;
            lblYearlyInvestmentRate.Location = new Point(77, 250);
            lblYearlyInvestmentRate.Name = "lblYearlyInvestmentRate";
            lblYearlyInvestmentRate.Size = new Size(106, 15);
            lblYearlyInvestmentRate.TabIndex = 2;
            lblYearlyInvestmentRate.Text = "Yearly Interest Rate";
            // 
            // lblNumberOfYears
            // 
            lblNumberOfYears.AutoSize = true;
            lblNumberOfYears.Location = new Point(77, 303);
            lblNumberOfYears.Name = "lblNumberOfYears";
            lblNumberOfYears.Size = new Size(95, 15);
            lblNumberOfYears.TabIndex = 3;
            lblNumberOfYears.Text = "Number of Years";
            // 
            // lblFutureValues
            // 
            lblFutureValues.AutoSize = true;
            lblFutureValues.ForeColor = SystemColors.ControlText;
            lblFutureValues.Location = new Point(77, 355);
            lblFutureValues.Name = "lblFutureValues";
            lblFutureValues.Size = new Size(72, 15);
            lblFutureValues.TabIndex = 4;
            lblFutureValues.Text = "Future Value";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(455, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(455, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(455, 303);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(455, 355);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(355, 453);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(568, 453);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(108, 453);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 529);
            Controls.Add(btnCalculate);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblFutureValues);
            Controls.Add(lblNumberOfYears);
            Controls.Add(lblYearlyInvestmentRate);
            Controls.Add(lblMonthlyInvestment);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radMonthlyInvestment;
        private RadioButton radFutureValue;
        private Label lblMonthlyInvestment;
        private Label lblYearlyInvestmentRate;
        private Label lblNumberOfYears;
        private Label lblFutureValues;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnClear;
        private Button btnExit;
        private Button btnCalculate;
    }
}
