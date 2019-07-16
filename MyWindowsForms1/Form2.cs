using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsForms1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private List<Player> coll;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (coll == null || coll.Count == 0)
            {
                MessageBox.Show("Коллекция пуста");
            }
            else
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
                var query = from st in coll
                            where st.name == form3.name
                            select st;
                short count = 0;
                foreach (Player p in query)
                {
                    count++;
                    listBox2.Items.Add(p.name + "-" + p.points + "-" + p.rebounds + ".");
                }
                if (count == 0)
                {
                    MessageBox.Show("invalid name");
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int count;
            if (Result.Text == "" || (count = Convert.ToInt32(Result.Text)) == 0)
            {
                MessageBox.Show("Нету игроков");
                this.coll = null;
            }
            else
            {
                coll = new List<Player>(count);
                Player pl;
                for (int i = 0; i < count; i++)
                {
                    pl = new Player();
                    coll.Add(pl);
                }
                foreach (Player p in coll)
                {
                    listBox1.Items.Add(p.name + "-" + p.points + "-" + p.rebounds + ".");
                }


            }
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            if (coll == null || coll.Count == 0)
            {
                MessageBox.Show("Нету игроков");
            }
            else
            {
                coll.Sort();
                foreach (Player p in coll)
                {
                    listBox3.Items.Add(p.name + "-" + p.points + "-" + p.rebounds + ".");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            if (coll == null || coll.Count == 0)
            {
                MessageBox.Show("Коллекция пуста");
            }
            else
            {
                Player st = new Player();
                coll.Sort(0, coll.Count, st);
                foreach (Player p in coll)
                {
                    listBox3.Items.Add(p.name + "-" + p.points + "-" + p.rebounds + ".");
                }
            }
        }

      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
