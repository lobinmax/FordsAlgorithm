using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FordsAlgorithm
{
    public partial class UserControlНовыйГраф : UserControl
    {
        private class МассивГрафовClass : DataTable
        {
            public МассивГрафовClass()
            {
                this.Columns.Add("UIDГрафа", typeof(Guid));
                this.Columns.Add("Наименование графа", typeof(string));
                this.Columns.Add("Кол-во вершин", typeof(int));
                this.Columns.Add("Кол-во ребер", typeof(int));
                this.PrimaryKey = new DataColumn[] { this.Columns["UIDГрафа"] };
            }

            public void ДобавитьСтроку(Guid UIDГрафа, string НаименованиеГрафа, int КоличествоВершин = 0, int КоличествоРебер = 0)
            {
                var nRow = this.NewRow();
                nRow["UIDГрафа"] = UIDГрафа;
                nRow["Наименование графа"] = НаименованиеГрафа;
                nRow["Кол-во вершин"] = КоличествоВершин;
                nRow["Кол-во ребер"] = КоличествоРебер;
                this.Rows.Add(nRow);
                this.AcceptChanges();

            }

            public void ОбновитьСтроку(Guid UIDГрафа, string НаименованиеГрафа, int КоличествоВершин = 0, int КоличествоРебер = 0)
            {
                var _Row = this.Rows.Find(UIDГрафа);
                _Row["Наименование графа"] = НаименованиеГрафа;
                _Row["Кол-во вершин"] = КоличествоВершин;
                _Row["Кол-во ребер"] = КоличествоРебер;
                _Row.AcceptChanges();
            }

            public void УдалитьСтроку(Guid? UIDГрафа)
            {
                if (UIDГрафа!= null)
                {
                    this.Rows.Remove(this.Rows.Find(UIDГрафа));
                    this.AcceptChanges();
                }
            }

            public int ИндексСтрокиПоUIDграфа(Guid UIDГрафа)
            {
                for(var i = 0; i < Rows.Count; i++)
                {
                    if (((Guid)Rows[i]["UIDГрафа"]).Equals(UIDГрафа))
                    {
                        return i;
                    }
                }
                return 0;
            }
        }

        private МассивГрафовClass МассивГрафовDT = new МассивГрафовClass();
        private List<Граф> МассивГрафовList = new List<Граф>();
        private int МатрицаТекущийСтолбец;
        private int МатрицаТекущаяСтрока;

        public Guid? UIDТекущегоГрафа
        {
            get
            {
                var curRow = gridViewМассивГрафов.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
                if (curRow != null)
                {
                    return (Guid)curRow.Cells["UIDГрафа"].Value;
                }
                return null;
            }
        }
        public Граф ТекущийГраф
        {
            get
            {
                return МассивГрафовList.SingleOrDefault(f => f.UIDГрафа.Equals(UIDТекущегоГрафа));
            }
        }
        public UserControlНовыйГраф()
        {
            InitializeComponent();
            gridViewМассивГрафов.DataSource = МассивГрафовDT;
            gridViewМассивГрафов.Columns["UIDГрафа"].Visible = false; 
        }
        
        public event EventHandler КоличествоРеберChanged; 
        public event EventHandler МассивГрафовSelectionChanged;
        public event EventHandler МассивГрафовДобавление;
        public event EventHandler МассивГрафовУдаление;


        private void buttonНовыйГраф_Click(object sender, EventArgs e)
        {
            textBoxИмяГрафа.Enabled = true;
            numericКоличествоВершин.Enabled = true;
            buttonСоздатьГраф.Enabled = true;
            buttonУдалитьРебро.Enabled = true;
            numericКоличествоВершин.Value = 2;
            textBoxИмяГрафа.Text = $"Новый граф # {МассивГрафовList.Count + 1}";
            textBoxИмяГрафа.Focus();
            textBoxИмяГрафа.SelectAll();
        }

        private void buttonДобавитьРебро_Click(object sender, EventArgs e)
        {
            var curCell = gridViewМатрицаСмежности.CurrentCell;
            if (curCell == null) { return; }

            МассивГрафовList.Single(f => f.UIDГрафа.Equals(UIDТекущегоГрафа))?.ДобавитьРебро
                (
                    new Ребро
                    (
                        (int)numericВесРебра.Value,
                        ТекущийГраф.ВершинаПоНомеру(curCell.RowIndex + 1),
                        ТекущийГраф.ВершинаПоНомеру(curCell.ColumnIndex)
                    )
                );

            МассивГрафовDT.ОбновитьСтроку(ТекущийГраф.UIDГрафа.Value, ТекущийГраф.ИмяГрафа, ТекущийГраф.КоличествоВершин, ТекущийГраф.КоличествоРебер);
            gridViewМатрицаСмежности.DataSource = ТекущийГраф.ПостороитьМатрицуСмежности();
            gridViewМатрицаСмежности[МатрицаТекущийСтолбец, МатрицаТекущаяСтрока].Selected = true;

            КоличествоРеберChanged?.Invoke(this, new EventArgs());
        }

        private void gridViewМассивГрафов_SelectionChanged(object sender, EventArgs e)
        {
            var focusDR = gridViewМассивГрафов.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
            if(focusDR != null)
            {
                gridViewМатрицаСмежности.DataSource = ТекущийГраф.ПостороитьМатрицуСмежности();
            }
            МассивГрафовSelectionChanged?.Invoke(this, new EventArgs());
        }

        private void buttonСоздатьГраф_Click(object sender, EventArgs e)
        {
            var UID = Guid.NewGuid();

            МассивГрафовList.Add(new Граф(UID, textBoxИмяГрафа.Text, (int)numericКоличествоВершин.Value));
            МассивГрафовDT.ДобавитьСтроку(UID, textBoxИмяГрафа.Text, (int)numericКоличествоВершин.Value);
            МассивГрафовДобавление?.Invoke(this, new EventArgs());
            textBoxИмяГрафа.Enabled = false;
            numericКоличествоВершин.Enabled = false;
            buttonСоздатьГраф.Enabled = false;

            gridViewМассивГрафов.Rows[МассивГрафовDT.ИндексСтрокиПоUIDграфа(UID)].Selected = true;
            groupBox3.Text = $"Массив графов ({gridViewМассивГрафов.RowCount} шт.)";
        }

        private void buttonУдалитьГраф_Click(object sender, EventArgs e)
        {
            МассивГрафовList.Remove(МассивГрафовList.SingleOrDefault(f=>f.UIDГрафа.Equals(UIDТекущегоГрафа)));
            МассивГрафовDT.УдалитьСтроку(UIDТекущегоГрафа);
            groupBox3.Text = $"Массив графов ({gridViewМассивГрафов.RowCount} шт.)";
            gridViewМатрицаСмежности.DataSource = (ТекущийГраф == null) ? null : ТекущийГраф.ПостороитьМатрицуСмежности();
            МассивГрафовУдаление?.Invoke(this, new EventArgs());
        }

        private void gridViewМатрицаСмежности_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            if (e.Column.Name.Equals("#"))
            {
                e.Column.ReadOnly = true;
            }
        }

        private void buttonУдалитьРебро_Click(object sender, EventArgs e)
        {
            var curCell = gridViewМатрицаСмежности.CurrentCell;
            if (curCell == null) { return; }

            var реброУделяемое = ТекущийГраф.Ребра.Where
                (
                    f => f.ВекторНачало.НомерВершины == (curCell.RowIndex + 1) && 
                         f.ВекторКонец.НомерВершины == curCell.ColumnIndex
                ).SingleOrDefault();
            МассивГрафовList.Single(f => f.UIDГрафа.Equals(UIDТекущегоГрафа))?.УдалитьРебро(реброУделяемое);
            МассивГрафовDT.ОбновитьСтроку(ТекущийГраф.UIDГрафа.Value, ТекущийГраф.ИмяГрафа, ТекущийГраф.КоличествоВершин, ТекущийГраф.КоличествоРебер);
            gridViewМатрицаСмежности.DataSource = ТекущийГраф.ПостороитьМатрицуСмежности();
            gridViewМатрицаСмежности[МатрицаТекущийСтолбец, МатрицаТекущаяСтрока].Selected = true;
        }

        private void gridViewМатрицаСмежности_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 0) || ((e.RowIndex + 1) == (e.ColumnIndex)))
            {
                panel2.Enabled = false;
                buttonДобавитьРебро.Text = $"Добавить ребро";
            }
            else
            {
                panel2.Enabled = true;
                buttonДобавитьРебро.Text = $"Добавить ребро <{e.RowIndex + 1} → {e.ColumnIndex}>";
            }

            МатрицаТекущаяСтрока = e.RowIndex;
            МатрицаТекущийСтолбец = e.ColumnIndex;
        }

        private void gridViewМатрицаСмежности_DataSourceChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewColumn col in gridViewМатрицаСмежности.Columns)
            {
                foreach(DataGridViewRow row in gridViewМатрицаСмежности.Rows)
                {
                    if ((row.Index + 1) == (col.Index))
                    {
                        gridViewМатрицаСмежности[col.Index, row.Index].Style.BackColor = System.Drawing.Color.Black;
                    }
                }
            } 
        }

        private void buttonСохранитьКак_Click(object sender, EventArgs e)
        {
            if (gridViewМассивГрафов.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault() == null)
            {
                return;
            }
            var saveFileDialog = new SaveFileDialog()
            {
                Filter = "Файл графа (*.graf)|*.graf",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = $"{ТекущийГраф.ИмяГрафа}.graf"
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var stream = File.Create(saveFileDialog.FileName);
            var formatter = new BinaryFormatter();
            
            formatter.Serialize(stream, ТекущийГраф);
            stream.Close();
        }

        private void buttonОткрытьГраф_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Файл графа (*.graf)|*.graf",
                FilterIndex = 1,
                RestoreDirectory = true,
                Multiselect = false
            };
            if(openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var stream = File.OpenRead(openFileDialog.FileName);
            var formatter = new BinaryFormatter();

            var openГраф = formatter.Deserialize(stream) as Граф;
            openГраф.UIDГрафа = Guid.NewGuid();

            МассивГрафовList.Add(openГраф);
            МассивГрафовDT.ДобавитьСтроку(openГраф.UIDГрафа.Value, openГраф.ИмяГрафа, openГраф.КоличествоВершин, openГраф.КоличествоРебер);

            gridViewМассивГрафов.Rows[МассивГрафовDT.ИндексСтрокиПоUIDграфа(openГраф.UIDГрафа.Value)].Selected = true;
        }
    }
}
    
