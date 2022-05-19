namespace Calculator
{
    public partial class MainScreen : Form
    {
        double value1 = 0;
        String operation = "";
        double result = 0;
        public MainScreen()
        {
            InitializeComponent();
             
        }

     
        private void number_Click(object sender, EventArgs e)
        {
                if(TB_output.Text == "0" && TB_output.TextLength == 1)
                {
                    TB_output.Clear();
                }

                Button button = (Button)sender;
                TB_output.Text += button.Text;

        }

        private void operation_Click(object sender, EventArgs e)
        {   
            
            Button button = (Button)sender;

            switch (button.Text)
            {
                case "1/x": 
                    { 
                        result = 1 / Double.Parse(TB_output.Text);
                        writeResults();
                    }
                    break;
                case "x^2":
                    {
                        result = Double.Parse(TB_output.Text) * Double.Parse(TB_output.Text);
                        writeResults();
                    }break;
                case "Root(x)":
                    {
                        result = Math.Sqrt(Double.Parse(TB_output.Text));
                        writeResults();
                    }break;
                case "!":
                    {
                        result = Math.Log(Double.Parse(TB_output.Text));
                        writeResults();
                    }break;
                default:
                    {
                        value1 = Double.Parse(TB_output.Text);
                        operation = button.Text;
                        TB_output.Text = "0";
                        Label_display.Text = "" + value1 + operation;
                    }break;
            }

        }

        private void changeSign_Click(object sender, EventArgs e)
        {
            TB_output.Text = (Double.Parse(TB_output.Text) * -1).ToString();
        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    {
                        result = value1 + Double.Parse(TB_output.Text);
                    }
                    break;
                case "-":
                    {
                        result = value1 - Double.Parse(TB_output.Text);
                    }
                    break;
                case "*":
                    {
                        result = value1 * Double.Parse(TB_output.Text);
                    }break;
                case "/":
                    {
                        if(value1 > 0)
                            result = value1 / Double.Parse(TB_output.Text);
                            
                    }
                    break;
                default: {
                        Console.WriteLine("Invalid Operation");
                    }break;
            }

            writeResults();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch(button.Name)
            {
                case "cancel":
                    {
                        TB_output.Text = "0";
                      
                    }
                    break;
                case "cancelentry":
                    {
                        TB_output.Text = "0";
                        value1 = 0;
                        operation = "";
                        Label_display.Text = "";
                    }break;

                case "delete":
                    {
                        TB_output.Text = TB_output.Text.Remove(TB_output.TextLength - 1,1);
                    }break;
                default: { 
                        Console.WriteLine("Invalid Button");  
                    } break;
            }
        }

        public void writeResults()
        {
            Label_display.Text += TB_output.Text;
            TB_output.Text = result.ToString();
        }
    }
}