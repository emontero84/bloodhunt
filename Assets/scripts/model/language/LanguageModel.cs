using System;
using System.Collections.Generic;
using bloodhunt.model.language;

namespace bloodhunt.model.language
{
	public class LanguageModel : ILanguageModel
	{
		private const string LANGUAGE_EN = "en";
		private const string LANGUAGE_ES = "es";

		private Dictionary<string, string> _dictionary;

		private string _language;

		public LanguageModel()
		{
		}

		public string GetString(string id)
		{
			if (_dictionary.ContainsKey(id))
			{
				return _dictionary[id];
			}
			return "Error: [" + id + "] not defined in Language XML";
		}

	}
}