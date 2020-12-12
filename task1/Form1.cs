using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    #region задание 1
    /*
    * а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    * б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов. в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
    * Вся логика игры должна быть реализована в классе с удвоителем.
    */
    #endregion
    public partial class Form1 : Form
    {
        Doubler doubler;
        public Form1()
        {
            doubler = new Doubler();
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnCommand3.Text = "Сброс";
            //lblNumber.Text = "0";
            this.Text = "Удвоитель";
            lblGoal.Visible = false;
            lblSteps.Visible = false;
            lblNumber.Visible = false;
            btnPlay.Text = "Играть";
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            //lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            doubler.Increment();
            Update();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            //lblNumber.Text = (int.Parse(lblNumber.Text) *2).ToString();
            doubler.Double();
            Update();
        }

        private void btnCommand3_Click(object sender, EventArgs e)
        {
            //lblNumber.Text = "1";
            doubler.Reset();
            Update();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            doubler.GetGoal();
            MessageBox.Show($"Получите число {doubler.Goal}");

            btnPlay.Visible = false;
            lblGoal.Visible = true;
            lblSteps.Visible = true;
            lblNumber.Visible = true;
            
            lblGoal.Text = doubler.Goal.ToString();
            lblSteps.Text = doubler.Steps.ToString();
            lblNumber.Text = doubler.Result.ToString();
        }

        public void Update()
        {
            lblNumber.Text = doubler.Result.ToString();
            lblSteps.Text = doubler.Steps.ToString();
            this.Refresh();

            if (doubler.CheckResult())
            {
                MessageBox.Show($"Вы достигли заданного числа за {doubler.Steps} попыток");
                doubler.Reset();
                lblGoal.Visible = false;
                lblSteps.Visible = false;
                lblNumber.Visible = false;
                btnPlay.Visible = true;
            }
        }
    }
}
