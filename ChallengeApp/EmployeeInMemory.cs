namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private readonly List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }
       
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid Grade Value");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddGrade(byte grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }
        public override void AddGrade(short grade)
        {
            this.AddGrade((float)grade);
        }
        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.AverageLetter)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;

            }

            return statistics;
        }

        //public override Statistics GetStatisticsWithDoWhile()
        //{
        //    var statistics = new Statistics();
        //    statistics.Average = 0;
        //    statistics.Max = float.MinValue;
        //    statistics.Min = float.MaxValue;

        //    var index = 0;

        //    do
        //    {
        //        statistics.Max = Math.Max(statistics.Max, grades[index]);
        //        statistics.Min = Math.Min(statistics.Min, grades[index]);
        //        statistics.Average += grades[index];
        //        index++;
        //    } while (index < this.grades.Count);

        //    statistics.Average /= this.grades.Count;

        //    return statistics;
        //}

        //public override Statistics GetStatisticsWithFor()
        //{
        //    var statistics = new Statistics();
        //    statistics.Average = 0;
        //    statistics.Max = float.MinValue;
        //    statistics.Min = float.MaxValue;

        //    for (var index = 0; index < this.grades.Count; index++)
        //    {
        //        statistics.Max = Math.Max(statistics.Max, grades[index]);
        //        statistics.Min = Math.Min(statistics.Min, grades[index]);
        //        statistics.Average += grades[index];
        //    }
        //    statistics.Average /= grades.Count;

        //    return statistics;
        //}

        //public override Statistics GetStatisticsWithForEach()
        //{
        //    var statistics = new Statistics();
        //    statistics.Average = 0;
        //    statistics.Max = float.MinValue;
        //    statistics.Min = float.MaxValue;

        //    foreach (var grade in this.grades)
        //    {
        //        statistics.Max = Math.Max(statistics.Max, grade);
        //        statistics.Min = Math.Min(statistics.Min, grade);
        //        statistics.Average += grade;
        //    }
        //    statistics.Average /= this.grades.Count;

        //    return statistics;
        //}

        //public override Statistics GetStatisticsWithWhile()
        //{
        //    var statistics = new Statistics();
        //    statistics.Average = 0;
        //    statistics.Max = float.MinValue;
        //    statistics.Min = float.MaxValue;

        //    int index = 0;

        //    while (index < this.grades.Count)
        //    {
        //        statistics.Max = Math.Max(statistics.Max, grades[index]);
        //        statistics.Min = Math.Min(statistics.Min, grades[index]);
        //        statistics.Average += grades[index];
        //        index++;
        //    }

        //    statistics.Average /= this.grades.Count;

        //    return statistics;
        //}
    }
}