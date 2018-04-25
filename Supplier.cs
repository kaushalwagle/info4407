using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class Supplier
    {
        #region Constructors
        public Supplier()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private string _Name;
        private int _Number;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this Supplier object.
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
        /// Gets or sets the Name for this Supplier Obect.
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
        /// Gets or sets the Number for this Supplier Obect.
        /// </summary>
        /// <remarks></remarks>

        public int Number
        {
            get
            {
                return _Number;
            }
            set
            {
                _Number = value;
            }
        }
        #endregion

    }
}
