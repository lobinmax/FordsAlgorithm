using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FordsAlgorithm
{
    [Serializable]
    public class Граф
    {
        public string ИмяГрафа;
        [NonSerialized]public Guid? UIDГрафа;
        public List<Вершина> Вершины = new List<Вершина>();
        public List<Ребро> Ребра = new List<Ребро>();

        public Граф(string ИмяГрафа, int КоличествоВершин = 0)
        {
            this.UIDГрафа = Guid.NewGuid();
            this.ИмяГрафа = ИмяГрафа;
            for (var i = 1; i <= КоличествоВершин; i++)
            {
                ДобавитьВершину(new Вершина(i));
            }
        }

        public Граф(Guid UIDГрафа, string ИмяГрафа, int КоличествоВершин = 0)
        {
            this.UIDГрафа = UIDГрафа;
            this.ИмяГрафа = ИмяГрафа;
            for (var i = 1; i <= КоличествоВершин; i++)
            {
                ДобавитьВершину(new Вершина(i));
            }
        }

        public int КоличествоВершин
        {
            get
            {
                return Вершины.Count();
            }
        }

        public int КоличествоРебер
        {
            get
            {
                return Ребра.Count();
            }
        }

        public void ДобавитьВершину(Вершина вершина)
        {
            if (Вершины.Where(f => f.НомерВершины == вершина.НомерВершины).Any()) 
            {
                MessageBox.Show($"Вершина c номером '{вершина.НомерВершины}' уже существует в графе.",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Вершины.Add(вершина);
        }

        public void ДобавитьРебро(Ребро ребро)
        {
            if (Ребра.Where(f => f.ВекторКонец.НомерВершины == ребро.ВекторКонец.НомерВершины && f.ВекторНачало.НомерВершины == ребро.ВекторНачало.НомерВершины).Any())
            {
                if(MessageBox.Show($@"Ребро c вершинами '{ребро.ВекторНачало.НомерВершины} → {ребро.ВекторКонец.НомерВершины}' уже существует в графе.
Удалить его?",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    УдалитьРебро(Ребра.Where(f => f.ВекторКонец.НомерВершины == ребро.ВекторКонец.НомерВершины && f.ВекторНачало.НомерВершины == ребро.ВекторНачало.НомерВершины).Single());
                    return;
                }
            }
            if (ребро.ВекторНачало.НомерВершины == ребро.ВекторКонец.НомерВершины)
            {
                MessageBox.Show($"Начальная и конечная вершина добавляемого ребра, имеет один и тот же номер.",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Ребра.Add(ребро);
        }

        public void УдалитьРебро(Ребро ребро)
        {
            if (Ребра.Where(f => f.Equals(ребро)).Any())
            {
                Ребра.Remove(ребро);
            }
        }

        public Вершина ВершинаПоНомеру(int НомерВершины)
        {
            var вершина = Вершины.Where(f => f.НомерВершины == НомерВершины).Single();
            return вершина;
        }

        public void ОчиститьГраф()
        {
            Вершины.Clear();
            Ребра.Clear();
        }

        private int? ОпределитьБесконечность()
        {
            if (!Вершины.Any())
            {
                MessageBox.Show("Граф не содержит вершин", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (!Ребра.Any())
            {
                MessageBox.Show("Граф не содержит ребер", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return Ребра.Sum(f => f.Вес) + 1;
        }

        public string ОпределитьКороткийПуть(int ПутьСтарт, int ПутьФиниш)
        {
            if (Вершины.SingleOrDefault(f => f.НомерВершины == ПутьСтарт) == null)
            {
                MessageBox.Show(
                   $"Вершина под номером <{ПутьСтарт}> не найдена.",
                   "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return $"Вершина под номером <{ПутьСтарт}> не найдена.";
            }

            if (Вершины.SingleOrDefault(f => f.НомерВершины == ПутьФиниш) == null)
            {
                MessageBox.Show(
                   $"Вершина под номером <{ПутьФиниш}> не найдена.",
                   "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return $"Вершина под номером <{ПутьФиниш}> не найдена.";
            }

            var INF = ОпределитьБесконечность(); ///значение бесконечности
            Вершины.ForEach(f => f.Источник = null);
            Вершины.ForEach(f => f.Потенциал = INF);

            Вершины.Single(f => f.НомерВершины == ПутьСтарт).Потенциал = 0;

            for (var i = 1; i < Вершины.Count(); i++)
            {
                РасчетПотенциалаВершин(Вершины.Single(f => f.НомерВершины == ПутьСтарт), ref i);
            }

            foreach (var ребро in Ребра)
            {
                if (ребро.ВекторКонец.Потенциал > (ребро.ВекторНачало.Потенциал + ребро.Вес))
                {
                    MessageBox.Show(
                        "Ошибка расчета кратчайшего пути. Граф имеет отрицательный цикл.",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "Ошибка расчета кратчайшего пути. Граф имеет отрицательный цикл.";
                }
            }

            var КратчайшийПутьlist = new List<string>();
            КратчайшийПуть(ВершинаПоНомеру(ПутьФиниш), ref КратчайшийПутьlist);
            КратчайшийПутьlist.Reverse();

            if (!КратчайшийПутьlist.Any())
            {
                return $"Пути из вершины <{ПутьСтарт}> в вершину <{ПутьФиниш}> не существует";
            }

            return $"Кратчайший путь из вершины <{ПутьСтарт}> в вершину <{ПутьФиниш}> :{String.Join(" | ", КратчайшийПутьlist)}. Расстояние - {ВершинаПоНомеру(ПутьФиниш).Потенциал} единиц.";

        }

        private List<Вершина> РасчетПотенциалаВершин(Вершина вершина, ref int УровеньДостижимости)
        {
            var СмежныеВершины = new List<Вершина>();
            var Счетчик = УровеньДостижимости ;
            Счетчик--;
            foreach(var ребро in Ребра.Where(f => f.ВекторНачало.Equals(вершина)).ToList())
            {
                if (ребро.ВекторКонец.Потенциал > (ребро.ВекторНачало.Потенциал + ребро.Вес))
                {
                    ребро.ВекторКонец.Потенциал = (ребро.ВекторНачало.Потенциал + ребро.Вес);
                    ребро.ВекторКонец.Источник = ребро.ВекторНачало;
                }

                if (Счетчик > 0)
                {
                    СмежныеВершины.AddRange(РасчетПотенциалаВершин(ребро.ВекторКонец, ref Счетчик));
                }
                else
                {
                    СмежныеВершины.Add(ребро.ВекторКонец);
                }
            }

            return СмежныеВершины.Distinct().ToList();
        }

        private void КратчайшийПуть(Вершина вершина, ref List<string> l)
        {
            if (вершина.Источник != null)
            {
                l.Add($"из '{вершина.Источник.НомерВершины}' в '{вершина.НомерВершины}'");
                КратчайшийПуть(вершина.Источник, ref l);
            }
        }

        public DataTable ПостороитьМатрицуСмежности()
        {
            var Матрица = new DataTable();

            Матрица.Columns.Add(new DataColumn() { ColumnName = "#" });
            for (var i = 0; i<Вершины.Count; i++ )
            {
                Матрица.Columns.Add(new DataColumn() { ColumnName = $"Вершина {i + 1}", DataType = typeof(string) });
            }
            for (var i = 0; i < Вершины.Count; i++)
            {
                Матрица.Rows.Add(Матрица.NewRow());
            }

            for(var row = 1; row <= Матрица.Rows.Count; row++)
            {
                Матрица.Rows[row - 1][0] = row;
                for (var col = 1; col <= Матрица.Rows.Count; col++)
                {
                    var ребро = Ребра.Where(f => f.ВекторНачало.НомерВершины == row && f.ВекторКонец.НомерВершины == col).SingleOrDefault();
                    if (ребро != null)
                    {
                        Матрица.Rows[row - 1][col] = $"√ Вес = {ребро.Вес}";
                    }
                }
            }

            return Матрица;
        }

    }
}
