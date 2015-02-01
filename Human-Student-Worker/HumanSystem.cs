namespace Human_Student_Worker
{
    using System;
    using System.Text;
    using System.Linq;
    using Human_Student_Worker.Data;

    static class HumanSystem
    {
        static void Main()
        {
            var student01 = new Student("Georgi Georgiev", 1234565890);
            var student02 = new Student("Kuncho Kunchev", 1234567891);
            var student03 = new Student("Petko Petkov", 3234867892);
            var student04 = new Student("Miro Mirov", 2234567893);
            var student05 = new Student("Jelqzko Jelqzkov", 1234557894);
            var student06 = new Student("Dimitar Dimitrov", 4234527895);
            var student07 = new Student("Metodi Genov", 1234267896);
            var student08 = new Student("Gencho Zubev", 1534567897);
            var student09 = new Student("Hristo Mirelkov", 4234567898);
            var student10 = new Student("Emil Vasilev", 2234567899);

            var worker01 = new Worker("Garbiel Jotev", 8, 140m);
            var worker02 = new Worker("Kosi Barmukova", 8, 240m);
            var worker03 = new Worker("Maximillian Albertov", 6, 100m);
            var worker04 = new Worker("Tonny Georgieva", 10, 160m);
            var worker05 = new Worker("Alberto George", 8, 340m);
            var worker06 = new Worker("Vassy Ushewa", 12, 400m);
            var worker07 = new Worker("Leo Georgiev", 10, 740m);
            var worker08 = new Worker("Kamelia Apostolova", 12, 250m);
            var worker09 = new Worker("Kali Ivanova", 8, 1040m);
            var worker10 = new Worker("Borislav Hristev", 14, 540m);

            var students = new Student[]
            {
                student01,
                student02,
                student03,
                student04,
                student05,
                student06,
                student07,
                student08,
                student09,
                student10
            };

            var workers = new Worker[]
            {
                worker01,
                worker02,
                worker03,
                worker04,
                worker05,
                worker06,
                worker07,
                worker08,
                worker09,
                worker10
            };

            var humans = students.Concat<Human>(workers).ToArray();

            var studentsString = new StringBuilder();
            var workersString = new StringBuilder();
            var humansString = new StringBuilder();

            foreach (var student in students
                .OrderBy(student => student.FacultyNumber))
            {
                studentsString.AppendLine(student.ToString());
            }

            foreach (var worker in workers
                .OrderByDescending(worker => worker.PaymentPerHour))
            {
                workersString.AppendLine(worker.ToString());
            }

            foreach (var human in humans
                .OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName))
            {
                humansString.AppendLine(human.ToString());
            }

            var printStudents = string.Format(
                "Students, sorted by faculty number in ascending order:\n{0}\n",
                studentsString);

            var printWorkers = string.Format(
                "Workers, sorted by payment per hour in descending order:\n{0}\n",
                workersString);

            var printHumans = string.Format(
                "Humans, sorted first by first name and then by last name:\n{0}\n",
                humansString);

            var output = printStudents + printWorkers + printHumans;

            Console.WriteLine(output);

        }
    }
}
