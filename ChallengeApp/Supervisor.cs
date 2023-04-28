namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public string Sex { get; private set; }

        public void AddGrade(int grade)
        {
            var gradeAsFloat = (float)grade;
            grades.Add(gradeAsFloat);
        }
        public void AddGrade(double grade)
        {
            var gradeAsFloat = (float)grade;
            grades.Add(gradeAsFloat);
        }
        public void AddGrade(char grade)
        {
            var gradesAsFloat = (float)grade;
            grades.Add(gradesAsFloat);
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "-6":
                case "6-":
                    this.grades.Add(95);
                    break;
                case "+5":
                case "5+":
                    this.grades.Add(85);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "-5":
                case "5-":
                    this.grades.Add(75);
                    break;
                case "+4":
                case "4+":
                    this.grades.Add(65);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "-4":
                case "4-":
                    this.grades.Add(55);
                    break;
                case "+3":
                case "3+":
                    this.grades.Add(45);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;
                case "+2":
                case "2+":
                    this.grades.Add(25);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "-2":
                case "2-":
                    this.grades.Add(15);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                default:
                    throw new Exception("Wrong string");
            }

        }
        public Statistics GetStatistics()
        {
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics2.Max = Math.Max(statistics2.Max, grade);
                    statistics2.Min = Math.Min(statistics2.Min, grade);
                    statistics2.Average += grade;
                }
            }

            statistics2.Average /= this.grades.Count;

            statistics2.AverageLetter = statistics2.Average
                switch
            {
                var average when average >= 80 => 'A',
                var average when average >= 60 => 'B',
                var average when average >= 40 => 'C',
                var average when average >= 20 => 'D',
                _ => 'E',
            };
            return statistics2;
         
        }
    }
}
