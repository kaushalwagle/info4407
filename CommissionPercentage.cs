using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class CommssionPercentage
    {
        #region Constructors
        public CommssionPercentage()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private float _Percentage;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this CommissionPercentage object.
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
        /// Gets or sets the Percentage for this CommissionPercentage Obect.
        /// </summary>
        /// <remarks></remarks>

        public float Percentage
        {
            get
            {
                return _Percentage;
            }
            set
            {
                _Percentage = value;
            }
        }
        #endregion

    }
}