namespace Task5_dll
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
            txtA = new TextBox();
            txtB = new TextBox();
            btnCalc = new Button();
            lblResult = new Label();
            lblA = new Label();
            lblB = new Label();
            lblTitle = new Label();
            lblFormula = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.BackColor = SystemColors.GradientActiveCaption;
            txtA.Location = new Point(38, 167);
            txtA.Name = "txtA";
            txtA.Size = new Size(81, 31);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.BackColor = SystemColors.GradientActiveCaption;
            txtB.Location = new Point(178, 167);
            txtB.Name = "txtB";
            txtB.Size = new Size(82, 31);
            txtB.TabIndex = 1;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.DodgerBlue;
            btnCalc.FlatStyle = FlatStyle.Flat;
            btnCalc.Font = new Font("Microsoft Sans Serif", 9F);
            btnCalc.ForeColor = Color.White;
            btnCalc.Location = new Point(593, 167);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(120, 35);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "Вычислить";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.LightGreen;
            lblResult.Font = new Font("Microsoft Sans Serif", 9F);
            lblResult.ForeColor = Color.DarkGreen;
            lblResult.Location = new Point(333, 167);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(182, 30);
            lblResult.TabIndex = 3;
            lblResult.Text = "Результат";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblA.Location = new Point(38, 144);
            lblA.Name = "lblA";
            lblA.Size = new Size(81, 20);
            lblA.TabIndex = 4;
            lblA.Text = "Катет A:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblB.Location = new Point(178, 144);
            lblB.Name = "lblB";
            lblB.Size = new Size(82, 20);
            lblB.TabIndex = 5;
            lblB.Text = "Катет B:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 10F);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(20, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(272, 25);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "📐 Калькулятор гипотенузы";
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.Font = new Font("Microsoft Sans Serif", 10F);
            lblFormula.ForeColor = Color.Gray;
            lblFormula.Location = new Point(38, 90);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(227, 25);
            lblFormula.TabIndex = 7;
            lblFormula.Text = "Формула: c = √(a² + b²)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(402, 411);
            label1.Name = "label1";
            label1.Size = new Size(375, 20);
            label1.TabIndex = 8;
            label1.Text = "DLL: FormulaDll.dll (вычисление гипотенузы)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblFormula);
            Controls.Add(lblTitle);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblResult);
            Controls.Add(btnCalc);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private Button btnCalc;
        private Label lblResult;
        private Label lblA;
        private Label lblB;
        private Label lblTitle;
        private Label lblFormula;
        private Label label1;
    }
}
