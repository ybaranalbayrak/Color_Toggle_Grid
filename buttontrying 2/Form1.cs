using System.Drawing.Text;

namespace buttontrying_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 121; i++)
            {
                Button newButton = new Button();
                newButton.Width = 50;
                newButton.Height = 50;

                int column = i % 11;
                int row = i / 11;
                newButton.Left = column * 50;
                newButton.Top = row * 50;

                newButton.Click += GridButton_Click;
                this.Controls.Add(newButton);
            }
        }
         private void GridButton_Click(object sender, EventArgs e)
        {

                Button clikcedButton = (Button)sender;
                
                if(clikcedButton.BackColor == Color.Red)
                {
                   clikcedButton.BackColor = Color.White;
                }
                else
                {
                   clikcedButton.BackColor = Color.Red;
                }
                






        }
    }
}
