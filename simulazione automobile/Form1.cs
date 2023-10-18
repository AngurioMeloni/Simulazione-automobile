using System.ComponentModel.DataAnnotations;

namespace simulazione_automobile
{
    public partial class Form1 : Form
    {
        Car car;
        public Form1()
        {
            InitializeComponent();
            car = new Car();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (car.Accensione())
            {
                button1.BackColor = Color.Green;
                label1.Text = "Accesa";
            }
            else
            {
                button1.BackColor = Color.Red;
                label1.Text = "Spenta";
            }
        }
    }
}