using System;
using System.Xml.Serialization;
using System.Data.SqlClient;


namespace Deliv6
{
    public class Employee
    {

        #region Private Variables
        private int _EmployeeID;
        private string _EmployeeNumber;
        private int _PersonID;
        private Person _Person;

        #endregion
        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this Employee object.
        /// </summary>
        /// <remarks></remarks>
        public int EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                _EmployeeID = value;
            }
        }

        /// <summary>
        /// Gets or sets the EmployeeNumber for this Employee object.
        /// </summary>
        /// <remarks></remarks>
        public string EmployeeNumber
        {
            get
            {
                return _EmployeeNumber;
            }
            set
            {
                _EmployeeNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets the Person for this Employee object.
        /// </summary>
        /// <remarks></remarks>
        [XmlIgnore]
        public Person Person
        {
            get
            {
                if (_Person == null)
                {
                    _Person = DAL.GetPerson(_PersonID);
                }
                return _Person;
            }
            set
            {
                _Person = value;
                if (value == null)
                {
                    _PersonID = -1;
                }
                else
                {
                    _PersonID = value.PersonID;
                }
            }
        }

        #endregion


        /// <summary>
        /// Takes in an SqlDataReader Object and a Person Object, and fills the Employee
        /// </summary>
        /// <param name="dr">SqlDataReader</param>
        /// <param name="Pers">Person</param>
        public void FillEmployee(SqlDataReader dr, Person Pers)
        {
            Person = Pers;
            int.TryParse(dr["EmployeeID"].ToString(), out int EmployeeID);
            EmployeeNumber = dr["EmployeeNumber"].ToString();
        }

        /// <summary>
        /// Formats the Employee with their "FullName" | EmployeeNumber: "EmployeeNumber"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
           return String.Format("{0} | Employee Number:{1}",
                Person.ToString(), EmployeeNumber);
        }

    }
}
