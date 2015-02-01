namespace Animals.Data
{
    using System;
    using Animals.Data.Enum;
    using Animals.Data.Interfaces;

    public abstract class Animal : ISound
    {
        private string _name;
        private int _age;
        private Genders _gender;

        public Animal(string name, int age, Genders gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Genders Gender
        {
            get
            {
                return this._gender;
            }

            set
            {
                this._gender = value;
            }
        }

        public int Age
        {
            get
            {
                return this._age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can not be negative!");
                }

                this._age = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name", "Name can not be null or empty!");
                }

                this._name = value;
            }
        }

        public abstract void ProduceSound();
    }
}
