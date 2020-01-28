using System;

namespace AutoMapperTest.Source
{
    public class UrlItem
    {
        public UrlItem(int id, string name, string surName, Guid secretType)
        {
            Id = id;
            Name = name;
            SurName = surName;
            SecretType = secretType;
        }

        public int Id { get; internal set; }

        public string Name { get; internal set; }

        public string SurName { get; internal set; }

        public Guid SecretType { get; internal set; }

        public static UrlItem Default => new UrlItem(1, "Mirko", "Mirkovic", new Guid());

    }
}
