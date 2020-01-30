using System;
using System.Collections.Generic;
using System.Text;
using AutoMapperTest.Destination;

namespace AutoMapperTestX.Test.Model
{
    internal class TestModel
    {
        public TestModel(string name, string surname)
        {

        }

        public string Name { get; }
        public string SurName { get; }

        public static UrlItemDto GetExpected()
        {
            return new UrlItemDto()
            {
                Id = 1,
                FullName = "Mirko Mirkovic Car"
            };
        }
    }

}
