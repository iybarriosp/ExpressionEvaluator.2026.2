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

            txtDisplay.Location = new Point(30, 30);
            txtDisplay.Size = new Size(300, 35);
            txtDisplay.Font = new Font("Comic Sans MS", 18F);

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

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 480);
            Text = "Expression Evaluator";
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
