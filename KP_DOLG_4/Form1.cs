namespace KP_DOLG_4
{
    public partial class Form1 : Form
    {
        private Button[,] buttons = new Button[4, 4];

        public Form1()
        {
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            int buttonSize = 50;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    Button button = new Button
                    {
                        Size = new Size(buttonSize, buttonSize),
                        Location = new Point(i * buttonSize, j * buttonSize),
                        Text = $"{i},{j}"
                    };

                    button.Click += Button_Click;
                    buttons[i, j] = button;
                    this.Controls.Add(button);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.Controls.Remove(button);
        }
    }
}
