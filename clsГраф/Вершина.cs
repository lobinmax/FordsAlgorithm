using System;

namespace FordsAlgorithm
{
    [Serializable]
    public class Вершина
    {
        public int НомерВершины;
        public int? Потенциал;
        public Вершина Источник;
        
        public Вершина(int НомерВершины)
        {
            this.НомерВершины = НомерВершины;
        }
    }
}
