using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Nodes;
using Algorithms.Structs;
using System.Collections;
using Algorithms.Interfaces;

namespace AlgorithmsTests
{
	public class ObjectTest : IDefaultComparator<ObjectTest>
    {
        public Comparison<ObjectTest> Comparator { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private string Name { get; set; }
        private int Id { get; set; }

   
    }
}
