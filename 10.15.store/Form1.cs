namespace _10._15.store
{

    public partial class Form1 : Form
    {
        private List<Ware> wares=new List<Ware>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("OK!");
                Ware ware = new Ware();
                ware.Name = form2.GetwName();
                ware.Description = form2.GetwDescription();
                ware.Characteristics = form2.GetwCharacteristics();
                ware.Price = form2.GetwPrice();
                wares.Add(ware);
                comboBox1.Items.Add(ware.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = wares[comboBox1.SelectedIndex].Price.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                listBox1.Items.Add( String.Format("{0}. Price: {1}\n",
                    wares[comboBox1.SelectedIndex],
                    wares[comboBox1.SelectedIndex].Price
                    ));
            }
        }
    }


    public class Ware
    {
        public string? Name
        {
            get;
            set;
        }
        public string? Description
        {
            get;
            set;
        }
        public string? Characteristics
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
        public override string ToString()
        {
            return String.Format("{0}. {2} Characteristics: {1}",
                this.Name, this.Description, this.Characteristics
                );
        }
    }
}