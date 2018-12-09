using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Author
    {
        //clone
        public Author(Author autor)
        {
            this.Name = autor.Name;

        }

        //custom constructor
        public Author(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        private string email;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public void SetEmail(string val)
        {
            this.email = val;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public string Country { get; set; }

        public DateTime BirthDate;

        public double ComputeAge(double year)
        {
            double age = DateTime.Now.Year - this.BirthDate.Year;

            return age;
        }

        public int ComputeAge()
        {
            int age = DateTime.Now.Year - this.BirthDate.Year;

            return age;
        }

        public int ComputeAge(int year)
        {
            int age = year - this.BirthDate.Year;

            return age;
        }
    }
}
