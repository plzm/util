using System;
using System.Collections.Generic;
using System.Text;

namespace pelazem.util
{
	public static class EncodingExtensionMethods
	{
		public static string EncodeBase64(this Encoding encoding, string text)
		{
			if (string.IsNullOrWhiteSpace(text))
				return string.Empty;

			byte[] textAsBytes = encoding.GetBytes(text);

			return Convert.ToBase64String(textAsBytes);
		}

		public static string DecodeBase64(this Encoding encoding, string encodedText)
		{
			if (string.IsNullOrWhiteSpace(encodedText))
				return string.Empty;

			byte[] textAsBytes = Convert.FromBase64String(encodedText);

			return encoding.GetString(textAsBytes);
		}
	}
}
