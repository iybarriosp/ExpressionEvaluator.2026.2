namespace Frontend.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Number_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            txtDisplay.Text += button.Text;
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            txtDisplay.Text += button.Text;
        }
        private void Equals_Click(object sender, EventArgs e)
        {
            var result = Backend.ExpressionEvaluator.Evalute(txtDisplay.Text);
            txtDisplay.Text = result.ToString();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
        }
    }
    
}
