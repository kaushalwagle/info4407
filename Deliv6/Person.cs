using System;
using System.Data.SqlClient;

namespace Deliv6
{
    public class Person
    {
        public Person()
        {

        }

        #region Private Variables
        private int _PersonID;
        private string _FirstName;
        private string _MiddleName;
        private string _LastName;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this person object.
        /// </summary>
        public int PersonID
        {
            get
            {
                return _PersonID;
            }
            set
            {
                _PersonID = value;
            }
        }

        /// <summary>
        /// Gets or sets the Name for this person object.
        /// </summary>
        public string FullName
        {
            get
            {
                return String.Format("{0} {1}{2}",
                    _FirstName,
                    _MiddleName + (_MiddleName != "" ? " " : ""),
                    _LastName);
            }
        }

        /// <summary>
        /// Gets or sets the FirstName for this person object.
        /// </summary>
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value.Trim();
            }
        }

        /// <summary>
        /// Gets or sets the MiddleName for this person object.
        /// </summary>
        public string MiddleName
        {
            get
            {
                return _MiddleName;
            }
            set
            {
                _MiddleName = value.Trim();
            }
        }

        /// <summary>
        /// Gets or sets the LastName for this person object.
        /// </summary>
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value.Trim();
            }
        }


        #endregion
        /// <summary>
        /// Takes in a SqlDataReader Object and fills the Person
        /// </summary>
        /// <param name="dr">SqlDataReader</param>
        public void FillPerson(SqlDataReader dr)
        {
            int.TryParse(dr["PersonID"].ToString(), out int PersonID);
            FirstName = dr["FirstName"].ToString();
            MiddleName = dr["MiddleName"].ToString();
            LastName = dr["LastName"].ToString();
        }
        /// <summary>
        /// Formats the Person's name as their FullName
        /// </summary>
        /// <returns>Returns the Person's name as their FullName</returns>
        public override string ToString()
        {
            return FullName;
        }
    }
}