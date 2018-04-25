using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class PersonAddress
    {
        #region Constructors
        public PersonAddress()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private int _PersonID;
        private Person _Person;
        private int _AddressID;
        private Address _Address;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this PersonAddress object.
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
        /// Gets or sets the Person for this PersonAddress object.
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
        /// Gets or sets the PersonID  for this PersonAddress object.
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
        /// <summary>
        /// Gets or sets the Address for this PersonAddress object.
        /// </summary>
        /// <remarks></remarks>
       // [XmlIgnore]
        public Address Address
        {
            get
            {
                if (_Address == null)
                {
                    _Address = DAL.GetAddress(_AddressID);
                }
                return _Address;
            }
            set
            {
                _Address = value;
                if (value == null)
                {
                    _AddressID = -1;
                }
                else
                {
                    _AddressID = value.ID;
                }
            }
        }
        /// <summary>
        /// Gets or sets the AddressID  for this PersonAddress object.
        /// </summary>
        /// <remarks></remarks>
        public int PhoneNumberID
        {
            get
            {
                return _AddressID;
            }
            set
            {
                _AddressID = value;
            }
        }


        #endregion

    }
}