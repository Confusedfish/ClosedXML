﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClosedXML.Excel
{
    internal class XLRangeParameters
    {
        public XLRangeParameters(IXLRangeAddress rangeAddress, IXLStyle defaultStyle)
        {
            RangeAddress = rangeAddress;
          
            DefaultStyle = defaultStyle;
        }
        #region Properties

        // Public
        public IXLRangeAddress RangeAddress { get; private set; }
        
        public IXLStyle DefaultStyle { get; private set; }
        public Boolean IgnoreEvents { get; set; }

        // Private

        // Override


        #endregion

    }
}
