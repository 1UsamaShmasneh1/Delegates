using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesAndEvent
{
    public partial class Form1 : Form
    {
        Calculation add = new Calculation(Program.Add);
        Calculation sub = new Calculation(Program.Sub);
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            add(1, 5);
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            sub(1, 5);
        }
    }
}
