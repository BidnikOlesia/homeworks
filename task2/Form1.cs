using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    #region задание 1
    /*
    * Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.
    * a) Для ввода данных от человека используется элемент TextBox;
    *Реализовать отдельную форму c TextBox для ввода числа.
    */
    

    public partial class Form1 : Form
    {
        GuessNumber gn;
        public Form1()
        {
            gn = new GuessNumber();
            InitializeComponent();
            btnPlay.Text = "Играть";
            lblInfo.Text = "Попробуйте угадать число от 1 до 100";
            lblCount.Visible = false;
            textBox1.Visible = false;
            lblMessage.Visible = false;
            btnCheck.Visible = false;
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            gn.GetNumber();
            lblCount.Visible = true;
            textBox1.Visible = true;
            btnCheck.Visible = true;
            btnPlay.Visible = false;

            lblCount.Text = $"Количество попыток: {gn.Count}";
            btnCheck.Text = "Проверить";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            gn.Result = int.Parse(textBox1.Text);
            bool isCorrect = gn.CheckResult();

            if (isCorrect)
            {
                textBox1.Clear();
                lblMessage.Visible = true;
                lblCount.Visible = false;
                textBox1.Visible = false;
                btnCheck.Visible = false;
                btnPlay.Visible = true;
                lblMessage.Text = $"Вы угадали число {gn.Number} за {gn.Count} попыток";

            }
            else
            {
                lblMessage.Visible = true;
                string message = gn.CheckRange();
                lblMessage.Text = message;
                textBox1.Clear();
            }
        }
    }
}
