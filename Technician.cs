using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class Technician

    {
        #region Constructors
        public Technician()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private int _EmployeeID;
        private Employee _Employee;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this Technician object.
        /// </summary>
        /// <remarks></remarks>

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        /// <summary>
        /// Gets or sets the Employee for this Technician object.
        /// </summary>
        /// <remarks></remarks>
       ///[XmlIgnore]
        public Employee Employee
        {
            get
            {
                if (_Employee == null)
                {
                    _Employee = DAL.GetEmployee(_EmployeeID);
                }
                return _Employee;
            }
            set
            {
                _Employee = value;
                if (value == null)
                {
                    _EmployeeID = -1;
                }
                else
                {
                    _EmployeeID = value.ID;
                }
            }
        }
        /// <summary>
        /// Gets or sets the EmployeeID for this Technician object.
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

        #endregion

    }
}