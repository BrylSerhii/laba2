using laba3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class SortContext
    {
        private ISortAlgorithm _sortAlgorithm;

        public void SetSortAlgorithm(ISortAlgorithm sortAlgorithm)
        {
            _sortAlgorithm = sortAlgorithm;
        }

        public void Sort(int[] array)
        {
            _sortAlgorithm.Sort(array);
        }
    }
}
