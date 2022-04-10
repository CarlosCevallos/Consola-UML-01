using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola_UML_01
{
    public abstract class Employee
    {

        public int BirthDate
        {
            get => default;
            set
            {
            }
        }

        public int FirstName
        {
            get => default;
            set
            {
            }
        }

        public int HiringDate
        {
            get => default;
            set
            {
            }
        }

        public int Id
        {
            get => default;
            set
            {
            }
        }

        public int IsActive
        {
            get => default;
            set
            {
            }
        }

        public int LastName
        {
            get => default;
            set
            {
            }
        }

        public void GetValueToPay()
        {
            throw new System.NotImplementedException();
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}