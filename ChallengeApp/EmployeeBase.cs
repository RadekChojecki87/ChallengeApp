namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;

        private static int average;

        void GradesAdded(object sender, EventArgs args)
        {
            Console.WriteLine("Dodano nową ocenę");
        }
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;           
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }    
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(long grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(string grade);
        public abstract void AddGrade(byte grade);
        public abstract void AddGrade(short grade);

        
        public abstract Statistics GetStatistics();
        
 

    }
}
