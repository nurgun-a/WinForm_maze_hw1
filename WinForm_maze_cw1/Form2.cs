using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_maze_cw1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); 
        }

        private void lb_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("ПОБЕДА!","Выйти?", MessageBoxButtons.YesNo);
            
            if (res==DialogResult.Yes)
            {
                Close();
            }
            else if (res == DialogResult.No)
            {
                Form1 Form1 = new Form1();               
                Form1.ShowDialog();
                this.Close();
            }
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            new Form1().Move_to_start();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Clip = this.Bounds;
            new Form1().Move_to_start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Первое окно");
            MessageBox.Show("Второе окно", "Задание №2.1");
            DialogResult res = MessageBox.Show("Третье окно", "Задание №2.1", MessageBoxButtons.YesNoCancel);
            MessageBox.Show($"Четвертое окно, вы выбрали {res}");            
        }
    }
}
