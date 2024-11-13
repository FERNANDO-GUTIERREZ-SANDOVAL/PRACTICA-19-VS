namespace PRACTICA_19_vs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal1, cal2, cal3, cal4, prom;
            cal1= double.Parse(textBox1.Text);
            cal2= double.Parse(textBox2.Text);
            cal3= double.Parse(textBox3.Text);
            cal4= double.Parse(textBox4.Text);

            prom = (cal1 + cal2 + cal3 + cal4) / 4;

        }
    }
}