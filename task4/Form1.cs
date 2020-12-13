using System;
using System.Windows.Forms;

#region задание 4
/*
* Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
* Программа, позволяющая сохранять слова с переводм в словарь и сохраняющая добавленные слова в формате xml
*/
#endregion

namespace task4
{
    public partial class Form1 : Form
    {
        MyDictionary dct;
        public Form1()
        {
            dct = new MyDictionary("words.xml");
            InitializeComponent();
            dct.Load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string word = txtboxWord.Text;
            string translate = txtBoxTranslate.Text;
            if (!string.IsNullOrEmpty(word) && !string.IsNullOrEmpty(translate))
            {
                bool isExist = dct.CheckWord(txtboxWord.Text);
                if (isExist)
                    MessageBox.Show($"Слово {word} уже добавлено в словарь");
                else
                {
                    dct.Add(word, translate);
                    MessageBox.Show($"Слово '{txtboxWord.Text}' добавлено в словарь");
                }
                txtboxWord.Clear();
                txtBoxTranslate.Clear();
            }   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dct.Save();
            MessageBox.Show($"Добавленные слова сохранены в файл words.xml");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            dct.Save();
            this.Close();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtboxWord.Text))
                MessageBox.Show(dct.ShowTranslate(txtboxWord.Text));
        }
    }
}
