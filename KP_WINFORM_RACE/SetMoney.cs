using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_WINFORM_RACE
{
    public partial class SetMoney: Form
    {
        private uint _money;
        private Menu menu;
        public SetMoney(Menu menu)
        {
            this.menu = menu;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.SetMoney(_money);
            Close();
        }

        private void SetMoney_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!uint.TryParse(tbSet.Text, out _money))
            {
                tbSet.Text = "0";
                tbSet.Select(tbSet.Text.Length, 0);
            }
        }
    }
}
