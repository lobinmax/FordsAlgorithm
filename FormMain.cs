using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FordsAlgorithm
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void ОписатьГраф(Граф ГрафFord)
        {
            if (ГрафFord == null)
            {
                return;
            }
            var описание = new List<string>();
            описание.Add(УправлениеГрафами.ТекущийГраф.ИмяГрафа);
            foreach (var r in ГрафFord.Ребра.OrderBy(f => f.ВекторКонец.НомерВершины).OrderBy(f => f.ВекторНачало.НомерВершины))
            {
                описание.Add($"От вершины <{r.ВекторНачало.НомерВершины}> к вершине <{r.ВекторКонец.НомерВершины}>. Вес - <{r.Вес}>");
            }
            ЗаписатьВконсоль(описание);
        }

        private void ЗаполнитьВыпадалки(Граф граф)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            if (граф == null || граф.КоличествоВершин == 0)
            {
                return;
            }

            foreach (var вершина in граф.Вершины)
            {
                comboBox1.Items.Add(вершина.НомерВершины);
            }
            comboBox1.SelectedIndex = 0;

            foreach (var вершина in граф.Вершины)
            {
                comboBox2.Items.Add(вершина.НомерВершины);
            }
            comboBox2.SelectedIndex = comboBox2.Items.Count - 1;
        }

        private void buttonНайтиПуть_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                return;
            }
            var консоль = new List<string>();
            консоль.Add($"{УправлениеГрафами.ТекущийГраф.ИмяГрафа}. Поиск кратчайщего пути из вершины '{comboBox1.Text}' в вершину '{comboBox2.Text}' ...");
            консоль.Add(УправлениеГрафами.ТекущийГраф.ОпределитьКороткийПуть(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text)));
            ЗаписатьВконсоль(консоль);
        }

        private void ЗаписатьВконсоль(string Строка)
        {
            textBox1.Text += $"{Строка}{Environment.NewLine}";
            textBox1.Text += Environment.NewLine;
            textBox1.Select(textBox1.Text.Length, textBox1.Text.Length);
            textBox1.ScrollToCaret();
        }
        private void ЗаписатьВконсоль(List<string> Строки)
        {
            foreach (var Строка in Строки)
            {
                textBox1.Text += $"{Строка}{Environment.NewLine}";
            }
            textBox1.Text += Environment.NewLine;
            textBox1.Select(textBox1.Text.Length, textBox1.Text.Length);
            textBox1.ScrollToCaret();
        }

        private void УправлениеГрафами_КоличествоРеберChanged(object sender, EventArgs e)
        {
            ЗаписатьВконсоль($"Изменено количество ребер ...");
            ОписатьГраф(УправлениеГрафами.ТекущийГраф);
        }

        private void УправлениеГрафами_МассивГрафовSelectionChanged(object sender, EventArgs e)
        {
            ЗаполнитьВыпадалки(УправлениеГрафами.ТекущийГраф);
        }

        private void gridViewМатрицаСмежности_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            if (e.Column.Name.Equals("#"))
            {
                e.Column.ReadOnly = true;
            }
        }

        private void УправлениеГрафами_МассивГрафовДобавление(object sender, EventArgs e)
        {
            ЗаписатьВконсоль($"Граф добавлен - '{УправлениеГрафами.ТекущийГраф.ИмяГрафа}");
        }

        private void УправлениеГрафами_МассивГрафовУдаление(object sender, EventArgs e)
        {
            ЗаписатьВконсоль($"Граф удален - '{УправлениеГрафами.ТекущийГраф.ИмяГрафа}'");
        }
       
    }
}