﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv6
{
    public class PaymentType
    {
        #region Constructors
        public PaymentType()
        {

        }
        #endregion

        #region Private Variables
        private int _ID;
        private string _Name;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this PaymentType object.
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
        /// Gets or sets the Name for this PaymentType Obect.
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
        #endregion

    }
}