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

        private void button10_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) < 0 || int.Parse(textBox1.Text) > 6)
            {
                MessageBox.Show("Dato inserito non valido");
            }
            else if (car.ControlloMarcia(int.Parse(textBox1.Text)))
            {
                car.Marcia = int.Parse(textBox1.Text);
                if (car.Marcia == 1)
                {
                    button6.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    button8.BackColor = Color.White;
                    button7.BackColor = Color.White;
                    button9.BackColor = Color.White;
                }
                if (car.Marcia == 2)
                {
                    button6.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button4.BackColor = Color.Red;
                    button3.BackColor = Color.White;
                    button8.BackColor = Color.White;
                    button7.BackColor = Color.White;
                    button9.BackColor = Color.White;
                }
                if (car.Marcia == 3)
                {
                    button6.BackColor = Color.White;
                    button5.BackColor = Color.Red;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button8.BackColor = Color.White;
                    button7.BackColor = Color.White;
                    button9.BackColor = Color.White;
                }
                if (car.Marcia == 4)
                {
                    button6.BackColor = Color.Red;
                    button5.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button8.BackColor = Color.White;
                    button7.BackColor = Color.White;
                    button9.BackColor = Color.White;
                }
                if (car.Marcia == 5)
                {
                    button6.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button8.BackColor = Color.White;
                    button7.BackColor = Color.Red;
                    button9.BackColor = Color.White;
                }
                if (car.Marcia == 6)
                {
                    button6.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button8.BackColor = Color.Red;
                    button7.BackColor = Color.White;
                }
                if (car.Marcia == 0)
                {
                    button6.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button8.BackColor = Color.White;
                    button7.BackColor = Color.White;
                    button9.BackColor = Color.Red;
                }
            }
        }
    }
}