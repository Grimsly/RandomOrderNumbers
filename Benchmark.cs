using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOrderNumbers
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        [Benchmark(Baseline = true)]
        public List<int> CreateIntLinqList() => CreateIntList.CreateIntLinqList(1, 10000);

        [Benchmark]
        public List<int> CreateIntForList() => CreateIntList.CreateIntForList(1, 10000);
    }
}
