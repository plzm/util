using System;
using System.Collections.Generic;
using System.Text;

namespace pelazem.util
{
	/// <summary>
	/// A class suitable for returning from class library operations to indicate operation success,
	/// provide the consumer a message, and return an output value.
	/// </summary>
	/// <author>Patrick El-Azem</author>
	public class OpResult
	{
		#region Variables

		private bool _succeeded = false;
		private string _message = string.Empty;
		private int _countAffected = 0;
		private object _output = null;
		private Dictionary<string, object> _outputs = null;
		private List<OpResult> _results = null;

		#endregion

		#region Properties

		/// <summary>
		/// Whether the operation that generated this OpResult succeeded.
		/// </summary>
		public bool Succeeded
		{
			get { return _succeeded; }
			set { _succeeded = value; }
		}

		/// <summary>
		/// A status or other message provided by the operation.
		/// </summary>
		public string Message
		{
			get { return _message; }
			set { _message = value; }
		}

		public object Output
		{
			get { return _output; }
			set { _output = value; }
		}

		/// <summary>
		/// Output values from the operation. Key-value pairs.
		/// </summary>
		public Dictionary<string, object> Outputs
		{
			get
			{
				if (_outputs == null)
					_outputs = new Dictionary<string, object>();

				return _outputs;
			}
		}

		public int CountAffected
		{
			get { return _countAffected; }
			set { _countAffected = value; }
		}

		public List<OpResult> Results
		{
			get
			{
				if (_results == null)
					_results = new List<OpResult>();

				return _results;
			}
		}

		#endregion

		#region Constructors

		public OpResult() { }

		public OpResult(bool result, string message, int countAffected)
		{
			_succeeded = result;
			_message = message;
			_countAffected = countAffected;
		}

		#endregion
	}
}
