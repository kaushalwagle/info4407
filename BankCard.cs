using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class BankCard
    {
        #region Constructors
        public BankCard()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private string _Number;
        private DateTime _DateExpiration;
        private int _SecurityCode;
        private int _CardTypeID;
        private CardType _CardType;
        private int _CustomerID;
        private Customer _Customer;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this BankCard object.
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
        /// Gets or sets the Number for this BankCard Obect.
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

        /// <summary>
        /// Gets or sets the DateExpiration for this BankCard Obect.
        /// </summary>
        /// <remarks></remarks>

        public DateTime DateExpiration
        {
            get
            {
                return _DateExpiration;
            }
            set
            {
                _DateExpiration = value;
            }
        }

        /// <summary>
        /// Gets or sets the SecurityCode for this BankCard object.
        /// </summary>
        /// <remarks></remarks>

        public int SecurityCode
        {
            get
            {
                return _SecurityCode;
            }
            set
            {
                _SecurityCode = value;
            }
        }
        /// <summary>
        /// Gets or sets the CardType for this BankCard object.
        /// </summary>
        /// <remarks></remarks>
       // [XmlIgnore]
        public CardType CardType
        {
            get
            {
                if (_CardType == null)
                {
                    _CardType = DAL.GetCardType(_CardTypeID);
                }
                return _CardType;
            }
            set
            {
                _CardType = value;
                if (value == null)
                {
                    _CardTypeID = -1;
                }
                else
                {
                    _CardTypeID = value.ID;
                }
            }
        }
        /// <summary>
        /// Gets or sets the CardTypeID for this BankCard object.
        /// </summary>
        /// <remarks></remarks>
        public int CardTypeID
        {
            get
            {
                return _CardTypeID;
            }
            set
            {
                _CardTypeID = value;
            }
        }

        /// <summary>
        /// Gets or sets the Customer for this BankCard object.
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
        /// <summary>
        /// Gets or sets the CustomerID for this BankCard object.
        /// </summary>
        /// <remarks></remarks>
        public int CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
            }
        }

        #endregion

    }
}