using System;
using System.Collections.Generic;
using System.Text;

namespace pelazem.util
{
	/// <summary>
	/// FORMAT_* strings should be wrapped in an appropriate string format expression, for example:
	/// string.Format("" + Constants.FORMAT_CURRENCY + "", someString);
	/// </summary>
	public struct Constants
	{
		public const string FORMAT_CURRENCY = "c";
		public const string FORMAT_CURRENCY_EXCEL = "$#,##0.00";

		public const string FORMAT_DATE = "d";
		public const string FORMAT_DATETIME = "G";
		public const string FORMAT_DATETIME_UNIVERSAL = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffK";
		public const string FORMAT_TIME = "HH:mm";

		public const string FORMAT_NUM_0 = "n1";
		public const string FORMAT_NUM_1 = "n1";
		public const string FORMAT_NUM_2 = "n2";
		public const string FORMAT_NUM_3 = "n3";
	}
}
