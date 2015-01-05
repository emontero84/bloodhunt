using System;
using System.Collections.Generic;

namespace bloodhunt {
	public class LanguageModel : ILanguageModel
	{
		private const string _LANGUAGE_EN = "en";
		private const string _LANGUAGE_ES = "es";

		private Dictionary<string, string> _dictionary;

		public LanguageModel() {
		}

		public string LANGUAGE_EN {
			get {
				return _LANGUAGE_EN;
			}
		}
		public string LANGUAGE_ES {
			get {
				return _LANGUAGE_ES;
			}
		}

		public string Language { get; set; }

		public void SetDictionary(Dictionary<string,string> dictionary)
		{
			_dictionary = dictionary;
		}

		public string GetString(string id)
		{
			if (_dictionary.ContainsKey(id)) {
				return _dictionary[id];
			}
			return "Error: [" + id + "] not defined in Language XML";
		}

	}
}