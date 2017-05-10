using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.util
{
	public class RegexExpressions
	{
		public const String AddressIP= @"^\d{3}\.\d{3}\.\d{3}\.\d{1,3}$";
		public const String CPF = @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$";
		public const String NUCNPJ = @"^\d{2}\.\d{3}\.\d{3}\W\d{4}\-\d{2}$";
	}
}
