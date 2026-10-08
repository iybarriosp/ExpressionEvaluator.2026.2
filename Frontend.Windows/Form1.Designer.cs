namespace Frontend.Windows
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
            txtDisplay = new TextBox();

            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            
            btnDecimal = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnPower = new Button();
            btnOpenParenthesis = new Button();
            btnCloseParenthesis = new Button();
            btnEquals = new Button();

            btnClear = new Button();
            btnDelete = new Button();

            txtDisplay.Location = new Point(30, 20);
            txtDisplay.AutoSize = false;
            txtDisplay.Size = new Size(300, 35);
            txtDisplay.Font = new Font("Segoe UI", 15F);

            Controls.Add(txtDisplay);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn0);

            Controls.Add(btnDecimal);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnPower);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnEquals);

            Controls.Add(btnClear);
            Controls.Add(btnDelete);

            btn7.Text = "7";
            btn7.Location = new Point(30, 90);
            btn7.Size = new Size(60, 50);
            btn7.Click += Number_Click;

            btn8.Text = "8";
            btn8.Location = new Point(100, 90);
            btn8.Size = new Size(60, 50);
            btn8.Click += Number_Click;

            btn9.Text = "9";
            btn9.Location = new Point(170, 90);
            btn9.Size = new Size(60, 50);
            btn9.Click += Number_Click;

            btn4.Text = "4";
            btn4.Location = new Point(30, 150);
            btn4.Size = new Size(60, 50);
            btn4.Click += Number_Click;

            btn5.Text = "5";
            btn5.Location = new Point(100, 150);
            btn5.Size = new Size(60, 50);
            btn5.Click += Number_Click;

            btn6.Text = "6";
            btn6.Location = new Point(170, 150);
            btn6.Size = new Size(60, 50);
            btn6.Click += Number_Click;

            btn1.Text = "1";
            btn1.Location = new Point(30, 210);
            btn1.Size = new Size(60, 50);
            btn1.Click += Number_Click;

            btn2.Text = "2";
            btn2.Location = new Point(100, 210);
            btn2.Size = new Size(60, 50);
            btn2.Click += Number_Click;

            btn3.Text = "3";
            btn3.Location = new Point(170, 210);
            btn3.Size = new Size(60, 50);
            btn3.Click += Number_Click;

            btn0.Text = "0";
            btn0.Location = new Point(100, 270);
            btn0.Size = new Size(60, 50);
            btn0.Click += Number_Click;

            btnDecimal.Text = ".";
            btnDecimal.Location = new Point(30, 270);
            btnDecimal.Size = new Size(60, 50);
            btnDecimal.Click += Number_Click;

            btnDivide.Text = "/";
            btnDivide.Location = new Point(240, 90);
            btnDivide.Size = new Size(60, 50);
            btnDivide.Click += Operator_Click;

            btnMultiply.Text = "*";
            btnMultiply.Location = new Point(240, 150);
            btnMultiply.Size = new Size(60, 50);
            btnMultiply.Click += Operator_Click;

            btnMinus.Text = "-";
            btnMinus.Location = new Point(240, 210);
            btnMinus.Size = new Size(60, 50);
            btnMinus.Click += Operator_Click;

            btnPlus.Text = "+";
            btnPlus.Location = new Point(240, 270);
            btnPlus.Size = new Size(60, 50);
            btnPlus.Click += Operator_Click;

            btnPower.Text = "^";
            btnPower.Location = new Point(170, 270);
            btnPower.Size = new Size(60, 50);
            btnPower.Click += Operator_Click;

            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.Location = new Point(30, 330);
            btnOpenParenthesis.Size = new Size(60, 50);
            btnOpenParenthesis.Click += Operator_Click;

            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.Location = new Point(100, 330);
            btnCloseParenthesis.Size = new Size(60, 50);
            btnCloseParenthesis.Click += Operator_Click;

            btnEquals.Text = "=";
            btnEquals.Location = new Point(170, 330);
            btnEquals.Size = new Size(130, 50);
            btnEquals.Click += Equals_Click;

            btnClear.Text = "Clear";
            btnClear.Location = new Point(30, 390);
            btnClear.Size = new Size(130, 50);
            btnClear.Click += Clear_Click;

            btnDelete.Text = "Delete";
            btnDelete.Location = new Point(170, 390);
            btnDelete.Size = new Size(130, 50);
            btnDelete.Click += Delete_Click;


            // Calculator background color
            BackColor = Color.FromArgb(45, 45, 45);

            // Green display
            txtDisplay.BackColor = Color.ForestGreen;
            txtDisplay.ForeColor = Color.White;

            // number buttons white
            foreach (var button in new[] {
                btn0, btn1, btn2, btn3, btn4,
                btn5, btn6, btn7, btn8, btn9, btnDecimal
            })
            {
                button.BackColor = Color.White;
                button.UseVisualStyleBackColor = false;
            }

            // operation buttons orange
            foreach (var button in new[] {
                btnPlus, btnMinus, btnMultiply, btnDivide,
                btnPower, btnOpenParenthesis, btnCloseParenthesis,
                btnEquals, btnClear, btnDelete
            })
            {
                button.BackColor = Color.Coral;
                button.UseVisualStyleBackColor = false;
            }

            // Display position and size
            txtDisplay.Location = new Point(20, 20);
            txtDisplay.Size = new Size(530, 40);

            // first line
            btn7.Location = new Point(20, 80);
            btn8.Location = new Point(90, 80);
            btn9.Location = new Point(160, 80);
            btnOpenParenthesis.Location = new Point(230, 80);
            btnCloseParenthesis.Location = new Point(300, 80);
            btnDelete.Location = new Point(370, 80);

            // Second line
            btn4.Location = new Point(20, 140);
            btn5.Location = new Point(90, 140);
            btn6.Location = new Point(160, 140);
            btnMultiply.Location = new Point(230, 140);
            btnDivide.Location = new Point(300, 140);
            btnClear.Location = new Point(370, 140);

            // Third line
            btn1.Location = new Point(20, 200);
            btn2.Location = new Point(90, 200);
            btn3.Location = new Point(160, 200);
            btnPlus.Location = new Point(230, 200);
            btnMinus.Location = new Point(300, 200);
            btnPower.Location = new Point(370, 200);

            // fourth fila
            btn0.Location = new Point(20, 260);
            btnDecimal.Location = new Point(160, 260);
            btnEquals.Location = new Point(230, 260);

            // special sizes
            btn0.Size = new Size(130, 50);
            btnDelete.Size = new Size(180, 50);
            btnClear.Size = new Size(180, 50);
            btnPower.Size = new Size(180, 50);
            btnEquals.Size = new Size(320, 50);

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 340);
            Text = "Functions Evaluator";
        }

        #endregion
        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnDecimal;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnPower;
        private Button btnOpenParenthesis;
        private Button btnCloseParenthesis;
        private Button btnEquals;
        private Button btnClear;
        private Button btnDelete;
    }
    
}
