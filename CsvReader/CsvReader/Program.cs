using System;
using System.IO;
using System.Linq;
using CsvHelper.Configuration;

namespace CsvReader
{
	internal class Record
	{
		public DateTime Date;
	}

	class Program
	{
		static void Main()
		{
			using (TextReader tr = File.OpenText("exp.csv"))
			{
				using (CsvHelper.CsvReader reader = new CsvHelper.CsvReader(tr))
				{
					var tmp2 = new DefaultCsvClassMap<Record>();
					tmp2.Map(c => c.Date);
					var tmp = reader.GetRecords<Record>().ToList();
				}
			}
		}
	}
}