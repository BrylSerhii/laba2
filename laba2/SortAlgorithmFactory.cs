using laba3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public abstract class SortAlgorithmFactory
    {
        public abstract ISortAlgorithm CreateSortAlgorithm();
    }

    public class SequentialMergeSortFactory : SortAlgorithmFactory
    {
        public override ISortAlgorithm CreateSortAlgorithm()
        {
            return new SequentialMergeSort();
        }
    }

    public class ConcurrentMergeSortFactory : SortAlgorithmFactory
    {
        public override ISortAlgorithm CreateSortAlgorithm()
        {
            return new ConcurrentMergeSort();
        }
    }
}
