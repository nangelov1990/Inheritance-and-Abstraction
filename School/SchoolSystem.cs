namespace School
{
    using System;
    using School.Data;
    using School.Data.People;

    static class SchoolSystem
    {
        static void Main()
        {
            var gosheto = new Student("Gosho Gosheto", 5, "Not brilliant");
            var koko = new Student("Kolio Koko", 15, "Sportsman");
            var gichka = new Student("Gichka P.", 7, "Everybody KNOWS her");
            var meto = new Student("Metodi Izqdeuchebnikov", 18, "Studies hard");
            var ji = new Student("Zhivko", 25);

            var chetene = new Discipline("Chetene", 20, new Student[] {gosheto, meto, ji});
            var risuvane = new Discipline("Risuvane", 15, new Student[] {koko, gichka, ji, meto});
            var sport = new Discipline("Sport", 20, new Student[] {koko}, "Fizichesko vyzpitanie");

            var kipachev = new Teacher("P. Kipachev", new Discipline[] {chetene, risuvane});
            var fochev = new Teacher("K. Fochev", new Discipline[] {sport});

            var klas = new SchoolClass("A", new Teacher[] {kipachev, fochev});

            Console.WriteLine(klas); //Intentionally left the \n for easier comprehension.
        }
    }
}
