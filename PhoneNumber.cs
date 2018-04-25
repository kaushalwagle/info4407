using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class PhoneNumber
    {
        #region Constructors
        public PhoneNumber()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private string _Number;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this PhoneNumber object.
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
        /// Gets or sets the Number for this PhoneNumber Obect.
        /// </summary>
        /// <remarks></remarks>

        public string Number
        {
            get
            {
                return _Number;
            }
            set
            {
                _Number = value.Trim();
            }
        }
        #endregion

    }
}
