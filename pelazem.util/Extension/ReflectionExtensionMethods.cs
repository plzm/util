using System;
using System.Reflection;

namespace pelazem.util
{
	public static class ReflectionExtensionMethods
	{
		public static object GetValueEx(this PropertyInfo prop, object obj)
		{
			object result = null;

			try
			{
				result = prop.GetValue(obj, null);
			}
			catch (Exception ex)
			{
				result = null;

				// Log

				throw ex;
			}

			return result;
		}

		public static void SetValueEx(this PropertyInfo prop, object obj, object value)
		{
			try
			{
				prop.SetValue(obj, value, null);
			}
			catch (Exception ex)
			{
				// Log

				throw ex;
			}
		}
	}
}
