namespace AutoMapperTest.Test.Model
{
    internal class TestModel
    {
        private TestModel(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }

        public static TestModel CreateInstance(string name, string surname)
        {
            return new TestModel(name, surname);
        }

        public string Name { get; }
        public string SurName { get; }
    }
}
