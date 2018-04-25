using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class Check  

    {
        #region Constructors
        public Check()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private int _Number;
        private int _RoutingNumber;
        private int _AccountNumber;
        private int _CustomerID;
        private Customer _Customer;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this Check object.
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
        /// Gets or sets the Number for this Check object.
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

        /// <summary>
        /// Gets or sets the RoutingNumber for this Check object.
        /// </summary>
        /// <remarks></remarks>

        public int RoutingNUmber
        {
            get
            {
                return _RoutingNumber;
            }
            set
            {
                _RoutingNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets the AccountNumber for this Check object.
        /// </summary>
        /// <remarks></remarks>

        public int AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
            set
            {
                _AccountNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets the Customer for this Check object.
        /// </summary>
        /// <remarks></remarks>
       // [XmlIgnore]
        public Customer Customer
        {
            get
            {
                if (_Customer == null)
                {
                    _Customer = DAL.GetCustomer(_CustomerID);
                }
                return _Customer;
            }
            set
            {
                _Customer = value;
                if (value == null)
                {
                    _CustomerID = -1;
                }
                else
                {
                    _CustomerID = value.ID;
                }
            }
        }
        #endregion

    }
}