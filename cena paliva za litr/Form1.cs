namespace cena_paliva_za_litr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string typ_paliva = "";
        int price;
        int liters;

        warning_box.Hide();

        private void button2_Click(object sender, EventArgs e)
        {
            price = Int32.Parse(price_input.Text);
            liters = Int32.Parse(liters_input.Text);

            if (typ_paliva == "")
            {
                warning_box.Show();
            }
            else if (typ_paliva == "nafta")
            {
                warning_box.Hide();
            }else if (typ_paliva == "benzin")
            {
                output.Text = ToString(liters * 34.90);
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nafta_CheckedChanged(object sender, EventArgs e)
        {
            typ_paliva = "nafta";
        }

        private void benzin_CheckedChanged(object sender, EventArgs e)
        {
            typ_paliva = "benzin";
        }

        private void liters_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
