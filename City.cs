using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class City

    {
        #region Constructors
        public City()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private string _Name;
        private int _StateID;
        private State _State;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this City object.
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
        /// Gets or sets the Name for this City Obect.
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
        /// Gets or sets the State for this City object.
        /// </summary>
        /// <remarks></remarks>
       // [XmlIgnore]
        public State State
        {
            get
            {
                if (_State == null)
                {
                    _State = DAL.GetState(_StateID);
                }
                return _StateID;
            }
            set
            {
                _StateID = value;
                if (value == null)
                {
                    _StateID = -1;
                }
                else
                {
                    _StateID = value.ID;
                }
            }
        }
        /// <summary>
        /// Gets or sets the StateID for this City object.
        /// </summary>
        /// <remarks></remarks>
        public int StateID
        {
            get
            {
                return _StateID;
            }
            set
            {
                _StateID = value;
            }
        }

        #endregion

    }
}