namespace DailyTemps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Monday = Convert.ToInt32(textBox1.Text);
            int Tuesday = Convert.ToInt32(textBox2.Text);
            int Wednesday = Convert.ToInt32(textBox3.Text);
            int Thursday = Convert.ToInt32(textBox4.Text);
            int Friday = Convert.ToInt32(textBox5.Text);
            int Saturday = Convert.ToInt32(textBox6.Text);
            int Sunday = Convert.ToInt32(textBox7.Text);
            int total;
            if (Monday >= -20 && Monday <= 130)
            {
                label9.Text = "This temperature is valid";   
            }
            else
            {
              label9.Text = "This temperature is invalid";
                return;
            }
                total = Monday;
            if (Tuesday >= -20 && Tuesday <= 130)
            {
                label10.Text = "This temperature is valid";  
            }
            else
            {
               label10.Text = "This temperature is invalid";
                return;
            }
                total = Monday + Tuesday;
            if (Wednesday >= -20 && Wednesday <= 130)
            {
                label11.Text = "This temperature is valid";

            }
            else
            { 
                label11.Text = "This temperature is invalid";
                return;
            }
            total = Monday + Tuesday + Wednesday;
            if (Thursday >= -20 && Thursday <= 130)
            {
                label12.Text = "This temperature is valid";

            }
            else
            { 
                label12.Text = "This temperature is invalid";
                return;
            }
            total = Monday + Tuesday + Wednesday + Thursday;
            if (Friday >= -20 && Friday <= 130)
            {
                label13.Text = "This temperature is valid";

            }
            else 
            { 
                label13.Text = "This temperature is invalid";
                return;
            }
            total = Monday + Tuesday + Wednesday + Thursday + Friday;
            if (Saturday >= -20 && Saturday <= 130)
            {
                label14.Text = "This temperature is valid";

            }
            else 
            { 
                label14.Text = "This temperature is invalid";
                return;
            }
            total = Monday + Tuesday + Wednesday + Thursday + Friday + Saturday;
            if (Sunday >= -20 && Sunday <= 130)
            {
                label15.Text = "This temperature is valid";
            }
            else
            {
                label15.Text = "This temperature is invalid";
                return;
            }
            total = Monday + Tuesday + Wednesday + Thursday + Friday + Saturday + Sunday;
            int average = total / 7;
            if (total == Monday + Tuesday + Wednesday + Thursday + Friday + Saturday + Sunday)
            {
                label8.Text += string.Format("Monday's high was {0}\n Tuesday's high was {1}\n Wednesday's high was {2}\n Thursday's high was {3}\n Friday's high was {4}\n Saturday's high was {5}\n Sunday's high was {6}\n The average daily high temperature was ", Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday) + average.ToString();
                button1.Enabled = false;
            }
           







        }
    }
}
