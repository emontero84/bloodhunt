using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Xml;

namespace bloodhunt {
	public interface ILoadLanguageService
	{
		XmlDocument xml {
			get;
		}

		void LoadLanguageXML(string url);

		Dictionary<string, string> GetLanguageDictionary(string languageID);
	}
}

