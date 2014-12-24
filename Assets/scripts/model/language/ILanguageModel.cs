using System;
using System.Collections.Generic;

namespace bloodhunt.model.language
{
	public interface ILanguageModel
	{
		string GetString(string id);
	}
}