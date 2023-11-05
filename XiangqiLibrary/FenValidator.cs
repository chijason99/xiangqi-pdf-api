using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XiangqiPdf.Domain;
public static class FenValidator
{
	public static bool Validate(string fen)
	{
		const string validFenCharactersPattern = "^[krncabpKRNCABP1]+$";

		string[] splittedFen = fen.Split('/');
		if (splittedFen.Length == 0) return false;

		string[] lastPartOfSplittedFen = splittedFen[splittedFen.Length - 1].Split(' ');

		// Only keep the last row of the Fen in the splitted Fen array
		splittedFen[splittedFen.Length - 1] = lastPartOfSplittedFen[0];

		if(splittedFen.Length != 10) return false;

		string[] decodedFen = new string[10];

		for(int i = 0; i < 10; i++)
		{
			string decodedRowFen = splittedFen[i]
				.Replace("9", "111111111")
				.Replace("8", "11111111")
				.Replace("7", "1111111")
				.Replace("6", "111111")
				.Replace("5", "11111")
				.Replace("4", "1111")
				.Replace("3", "111")
				.Replace("2", "11");

			if (decodedRowFen.Length != 9) return false;

			if (!Regex.IsMatch(decodedRowFen, validFenCharactersPattern)) return false;

			decodedFen[i] = decodedRowFen;
		}

		return true;
	}
}
