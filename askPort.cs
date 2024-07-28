namespace Local_Messenger
{
    public partial class askPort : Form
    {

        private Int32 allocatedPort;

        public askPort(Int32 allocatedPort)
        {
            InitializeComponent();
            this.allocatedPort = allocatedPort;
        }

        private void askPortButton_Click(object sender, EventArgs e)
        {
            string input = askPortEntry.Text;

            if (int.TryParse(input, out Int32 targetPort))
            {
                if (targetPort > 65535 || targetPort < 49152)
                {
                    askPortLabel.Text = "El puerto debe estar en el rango 49152-65535";
                } else if (targetPort == allocatedPort)
                {
                    askPortLabel.Text = "¡No puedes utilizar ese puerto!";
                } else
                {
                    messenger messenger = new messenger();
                    messenger.Show();
                    this.Hide();
                }
            }
            else
            {
                askPortLabel.Text = "¡Eso no es un puerto!";
            }
        }
    }
}
