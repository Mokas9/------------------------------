using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace индивидуальное_задание
{
    [Serializable]
    public class Student
    {
        string _name;
        string _surname;
        string _otchestvo;
        string _city;
        int _math;
        int _fisics;
        int _literatura;
        public string time;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Otchestvo
        {
            get { return _otchestvo; }
            set { _otchestvo = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }
        public int Fisics
        {
            get { return _fisics; }
            set { _fisics = value; }
        }
        public int Literatura
        {
            get { return _literatura; }
            set { _literatura = value; }
        }

        public Student(string Name, string Surname, string Otchestvo, string City, int Math, int Fisics, int Literatura)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Otchestvo = Otchestvo;
            this.City = City;
            this.Math = Math;
            this.Fisics = Fisics;
            this.Literatura = Literatura;
        }
        public Student()
        { }
           
    }
}
