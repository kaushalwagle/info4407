using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class ZipCode

    {
        #region Constructors
        public ZipCode()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private string _Code;
        private int _CityID;
        private City _City;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this ZipCode object.
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
        /// Gets or sets the Code for this ZipCode Obect.
        /// </summary>
        /// <remarks></remarks>

        public string Code
        {
            get
            {
                return _Code;
            }
            set
            {
                _Code = value.Trim();
            }
        }
        /// <summary>
        /// Gets or sets the City for this ZipCode object.
        /// </summary>
        /// <remarks></remarks>
       // [XmlIgnore]
        public City City
        {
            get
            {
                if (_City == null)
                {
                    _City = DAL.GetCity(_CityID);
                }
                return _CityID;
            }
            set
            {
                _CityID = value;
                if (value == null)
                {
                    _CityID = -1;
                }
                else
                {
                    _CityID = value.ID;
                }
            }
        }
        /// <summary>
        /// Gets or sets the StateID for this City object.
        /// </summary>
        /// <remarks></remarks>
        public int CountryID
        {
            get
            {
                return _CityID;
            }
            set
            {
                _CityID = value;
            }
        }

        #endregion

    }
}