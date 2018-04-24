using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class Customer

    {
        #region Constructors
        public Customer()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private int _PersonID;
        private Person _Person;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this Customer object.
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
        /// Gets or sets the Person for this Customer object.
        /// </summary>
        /// <remarks></remarks>
       // [XmlIgnore]
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
                    _PersonID = value.ID;
                }
            }
        }
        /// <summary>
        /// Gets or sets the PersonID for this Customer object.
        /// </summary>
        /// <remarks></remarks>
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

        #endregion

    }
}