using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;

namespace bloodhunt.service {
	public interface ILoadLanguageService
	{
		void LoadLanguageXML(string url);

		Dictionary<string, string> GetLanguageDictionary(string languageID);
	}
}

