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
    }
}
