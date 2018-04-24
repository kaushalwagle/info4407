using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class Address

    {
        #region Constructors
        public Address()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private string _LineOne;
        private string _LineTwo;
        private int _ZipCodeID;
        private ZipCode _ZipCode;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this Address object.
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
        /// Gets or sets the LineOne for this Address Obect.
        /// </summary>
        /// <remarks></remarks>

        public string LineOne
        {
            get
            {
                return _LineOne;
            }
            set
            {
                _LineOne = value.Trim();
            }
        }

        /// <summary>
        /// Gets or sets the LineTwo for this Address Obect.
        /// </summary>
        /// <remarks></remarks>

        public string LineTwo
        {
            get
            {
                return _LineTwo;
            }
            set
            {
                _LineTwo = value.Trim();
            }
        }
        /// <summary>
        /// Gets or sets the ZipCode for this Address object.
        /// </summary>
        /// <remarks></remarks>
       // [XmlIgnore]
        public ZipCode ZipCode        {
            get
            {
                if (_ZipCode == null)
                {
                    _ZipCode = DAL.GetZipCode(_ZipCodeID);
                }
                return _ZipCode;
            }
            set
            {
                _ZipCode = value;
                if (value == null)
                {
                    _ZipCodeID = -1;
                }
                else
                {
                    _ZipCodeID = value.ID;
                }
            }
        }
        /// <summary>
        /// Gets or sets the ZipCodeID for this Address object.
        /// </summary>
        /// <remarks></remarks>
        public int ZipCodeID
        {
            get
            {
                return _ZipCodeID;
            }
            set
            {
                _ZipCodeID = value;
            }
        }

        #endregion

    }
}