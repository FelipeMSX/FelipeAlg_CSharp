using System;

namespace AlgorithmsTests
{
    public class ObjectTest 
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public ObjectTest()
        {

        }

        public ObjectTest(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public static Comparison<ObjectTest> ComparisonObjectTest = ((x, y) =>
        {
            if (x.Id > y.Id)
                return 1;
            else
            if (x.Id < y.Id)
                return -1;
            else
                return 0;

        });
    }


}
