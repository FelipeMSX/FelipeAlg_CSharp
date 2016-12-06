using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsForms.DataTableStudy
{
	class DataTableExtreme
	{

		DataTable dtStudy  = new DataTable();

		string value = "boa[";

		public DataTableExtreme()
		{
			dtStudy.Columns.Add(new DataColumn("Name", typeof(string)));
			dtStudy.Columns.Add(new DataColumn("Description", typeof(string)));
			dtStudy.Columns.Add(new DataColumn("Value", typeof(int)));
			dtStudy.Rows.Add("Maçã", "Uma fruta muito$ 'boa'.", 40);
			dtStudy.Rows.Add("Manga", "Melhor fruta d'o' mundo.", 100);
			dtStudy.Rows.Add("Goiaba", "É boa, mas tem muito caroço.", 50);
			dtStudy.AcceptChanges();
			ApplyFilter();
		}

		#region estudos sobre tratamento de caracteres especiais.

		public void ApplyFilter()
		{
			dtStudy.DefaultView.RowFilter = "Name = '" + value + "]' OR Description = '" +value +"]'";
			
		}

		#endregion


		public  string CheckValue(string value)
		{
			StringBuilder sBuilder = new StringBuilder();

			string pattern = @"([-\]\[<>\?\*\\\""/\|\~\(\)\#/=><+\%&\^\'])";
			
			Regex expression = new Regex(pattern);

			if (expression.IsMatch(value))
			{
				foreach (char c in value)
				{
					switch (c)
					{
						case '\\':
							sBuilder.Append("\\");
							break;
						case '[':
							sBuilder.Append(@"[[]");
							break;
						case ']':
							sBuilder.Append(@"[]]");
							break;
						default:
							sBuilder.Append(c);
							break;
					}
				}
			}
			return sBuilder.ToString();
		}

	}
}
