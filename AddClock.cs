using System;
using System.Windows.Forms;

namespace Clock
{
    public partial class AddClock : Form
    {
        public AddClock()
        {
            InitializeComponent();
        }

        private void Name_Click(object sender, EventArgs e)
        {
            Name.Text = "";
        }
        public string SelectedItem1 { get; private set; }
        public string SelectedItem2 { get; private set; }
        public string SelectedItem3 { get; private set; }

        private void Repeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem1 = Repeat.SelectedItem.ToString();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem2 = comboBox2.SelectedItem.ToString();
        }
        public void savebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainScreen mainScreen = new MainScreen();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
