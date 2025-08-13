using System;

namespace CSharpBasicsPractice
{
    public class Employee
    {
        int Enumber;
        string Ename, Job, Dname, Location;
        double Salray;

        public Employee(int Enumber,  string Ename, double Salray, string Job, string Dname, string Location)
        {
            this.Enumber = Enumber;
            this.Ename = Ename;
            this.Salray = Salray;
            this.Job = Job;
            this.Dname = Dname;
            this.Location = Location;
        }

        //Createing an indexer
        public object this[int index]
        {
            get {
                if (index == 0) return Enumber;
                else if (index == 1) return Ename;
                else if (index == 2) return Salray;
                else if (index == 3) return Job;
                else if (index == 4) return Dname;
                else if (index == 5) return Location;
                else return null;
            }

            set
            {
                if (index == 0)
                {
                    Enumber = (int)value;
                }
                else if (index == 1)
                {
                    Ename = (string)value;
                }
                else if (index == 2)
                {
                    Salray = (double)value;
                }
                else if (index == 3)
                {
                    Job = (string)value;
                }
                else if (index == 4)
                {
                    Dname = (string)value;
                }
                else if (index == 5)
                {
                    Location = (string)value;
                }
            }
        }
    }
}
