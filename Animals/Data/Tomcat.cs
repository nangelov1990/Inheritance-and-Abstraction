namespace Animals.Data
{
    using Animals.Data.Enum;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Genders.Male)
        {
        }
    }

}
