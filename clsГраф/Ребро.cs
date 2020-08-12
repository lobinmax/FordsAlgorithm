using System;

namespace FordsAlgorithm
{
    [Serializable]
    public class Ребро
    {
        public int Вес;
        public Вершина ВекторНачало;
        public Вершина ВекторКонец;
        
        public Ребро(int Вес, Вершина ВекторНачало, Вершина ВекторКонец)
        {
            this.Вес = Вес;
            this.ВекторНачало = ВекторНачало;
            this.ВекторКонец = ВекторКонец;
        }
    }
}
