using System;
using System.Windows.Forms;
namespace AdditionApp
{
    public class AdditionForm : Form
    {
        private Label label1;
        private Label label2;
        private Label resultLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button addButton;
        public AdditionForm()
        {
            // Initialize components
            this.Text = "Addition App";
            this.Width = 400;
            this.Height = 300;
            // First number label
            label1 = new Label();
            label1.Text = "Enter First Number:";
            label1.Location = new System.Drawing.Point(20, 30);
            this.Controls.Add(label1);

            // First number textbox
            textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(180, 30);
            this.Controls.Add(textBox1);
            // Second number label
            label2 = new Label();
            label2.Text = "Enter Second Number:";
            label2.Location = new System.Drawing.Point(20, 70);
            this.Controls.Add(label2);
            // Second number textbox
            textBox2 = new TextBox();
            textBox2.Location = new System.Drawing.Point(180, 70);
            this.Controls.Add(textBox2);
            // Add button
            addButton = new Button();
            addButton.Text = "Add";
            addButton.Location = new System.Drawing.Point(150, 120);
            addButton.Click += new EventHandler(OnAddButtonClick);
            this.Controls.Add(addButton);
            // Result label
            resultLabel = new Label();
            resultLabel.Text = "Result: ";
            resultLabel.Location = new System.Drawing.Point(20, 170);
            resultLabel.Width = 350;
            this.Controls.Add(resultLabel);
        }

        private void OnAddButtonClick(object sender, EventArgs e){
            try
            {
                // Get numbers from textboxes
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                // Perform addition
                double sum = num1 + num2;
                // Display result
                resultLabel.Text = $"Result: {num1} + {num2} = {sum}";
            }
            catch (FormatException)
            {
                // Handle invalid input
                MessageBox.Show("Please enter valid numbers.", 
                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdditionForm());
        }
    }
}
