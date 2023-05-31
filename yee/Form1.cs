namespace yee
    
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = " ";
            slumptalet = slump.Next(1, Convert.ToInt32(textBox1.Text)+1);
            felgissningar = 0;
            label3.Text = "Antal felgissningar: " + Convert.ToString(felgissningar);

            //label4.Text = slumptalet.ToString();
        }
        int felgissningar = 0;
        int gissning = 0;
        Random slump=new Random();
        int slumptalet = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            gissning = Convert.ToInt32(textBox2.Text);
            if (gissning == slumptalet) 
            {
                label5.Text="Du hade rätt! Talet var: " + slumptalet.ToString();
            }
            else
            {
                felgissningar++;
                label3.Text ="Antal felgissningar: " +Convert.ToString(felgissningar);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Text=("Antal felgissningar :"+felgissningar);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}