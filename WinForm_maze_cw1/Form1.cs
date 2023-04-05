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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Move_to_start();  
        }

        private void lb_finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Вы проходите во второй уровень", "Level II");
            Form2 Form2 = new Form2();
            // Form2.Show();//Вызов не модального окна (Можно вызывать с главного окна еще окна)
            Form2.ShowDialog();//Выов модального окна - Модальная форма которая перехватит все управление            
            
            Close();
        }
        public  void Move_to_start()
        {
            Point start_point = panel1.Location;
            start_point.Offset(25, 20);
            Cursor.Position = PointToScreen(start_point);
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            Move_to_start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Первое окно","Задание №2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult res = MessageBox.Show("Второе окно", "Задание №2", MessageBoxButtons.YesNo);
            MessageBox.Show($"Третье окно, вы нажали кнопку {res}");            
        }
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Clip = this.Bounds;
            Move_to_start();
        }

    }
}
