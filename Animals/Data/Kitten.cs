namespace Animals.Data
{
    using Animals.Data.Enum;

    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Genders.Female)
        {
        }
    }
}
