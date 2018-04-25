using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class PersonPhoneNumber
    {
        #region Constructors
        public PersonPhoneNumber()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private int _PhoneNumberID;
        private PhoneNumber _PhoneNumber;
        private int _PersonID;
        private Person _Person;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this PersonPhoneNumber object.
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
        /// Gets or sets the PhoneNumber for this PersonPhoneNumber object.
        /// </summary>
        /// <remarks></remarks>
       // [XmlIgnore]
        public PhoneNumber PhoneNumber
        {
            get
            {
                if (_PhoneNumber == null)
                {
                    _PhoneNumber = DAL.GetPhoneNumber(_PhoneNumberID);
                }
                return _PhoneNumber;
            }
            set
            {
                _PhoneNumber = value;
                if (value == null)
                {
                    _PhoneNumberID = -1;
                }
                else
                {
                    _PhoneNumberID = value.ID;
                }
            }
        }
        /// <summary>
        /// Gets or sets the PhoneNumberID  for this PersonPhoneNumber object.
        /// </summary>
        /// <remarks></remarks>
        public int PhoneNumberID
        {
            get
            {
                return _PhoneNumberID;
            }
            set
            {
                _PhoneNumberID = value;
            }
        }

        /// <summary>
        /// Gets or sets the Person for this PersonPhoneNumber object.
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
        /// Gets or sets the PersonID  for this PersonPhoneNumber object.
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