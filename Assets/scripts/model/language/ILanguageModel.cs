using System;
using System.Collections.Generic;

namespace bloodhunt.model.language {
	public interface ILanguageModel
	{
		string LANGUAGE_EN {
			get;
		}
		string LANGUAGE_ES {
			get;
		}

		string Language { get; set; }
		void SetDictionary(Dictionary<string,string> dictionary);

		string GetString(string id);
	}
}