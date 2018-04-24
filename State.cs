using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class State
    {
        #region Constructors
        public State()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private string _Name;
        private int _CountryID;
        private Country _Country;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this State object.
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
        /// Gets or sets the Name for this State Obect.
        /// </summary>
        /// <remarks></remarks>

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value.Trim();
            }
        }
        /// <summary>
        /// Gets or sets the Country for this State object.
        /// </summary>
        /// <remarks></remarks>
       // [XmlIgnore]
        public Country Country
        {
            get
            {
                if (_Country == null)
                {
                    _Country = DAL.GetCountry(_CountryID);
                }
                return _Country;
            }
            set
            {
                _Country = value;
                if (value == null)
                {
                    _CountryID = -1;
                }
                else
                {
                    _CountryID = value.ID;
                }
            }
        }
        /// <summary>
        /// Gets or sets the CountryID for this State object.
        /// </summary>
        /// <remarks></remarks>
        public int CountryID
        {
            get
            {
                return _CountryID;
            }
            set
            {
                _CountryID = value;
            }
        }

        #endregion

    }
}