using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class SortingFacade
    {
        private readonly SortAlgorithmFactory _sequentialFactory;
        private readonly SortAlgorithmFactory _concurrentFactory;

        public SortingFacade()
        {
            _sequentialFactory = new SequentialMergeSortFactory();
            _concurrentFactory = new ConcurrentMergeSortFactory();
        }

        public void SortSequentially(int[] array)
        {
            var sorter = _sequentialFactory.CreateSortAlgorithm();
            sorter.Sort(array);
        }

        public void SortConcurrently(int[] array)
        {
            var sorter = _concurrentFactory.CreateSortAlgorithm();
            sorter.Sort(array);
        }
    }
}
