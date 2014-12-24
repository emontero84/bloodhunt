using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using bloodhunt.events;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;

namespace bloodhunt.service {
	public class LoadLanguageService : ILoadLanguageService
	{
		[Inject]
		public IEventDispatcher dispatcher {
			get;
			set;
		}

		private XmlDocument _xml;

		public LoadLanguageService () {
		}

		public void LoadLanguageXML(string url)
		{
			_xml = new XmlDocument();
			TextAsset textAsset = (TextAsset)Resources.Load(url);
			_xml.LoadXml(textAsset.text);

			Debug.Log("Language XML loaded.");

			dispatcher.Dispatch(LoadLanguageEvent.LANGUAGE_XML_LOADED);
		}

		public Dictionary<string, string> GetLanguageDictionary(string languageID)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (XmlNode node in _xml.SelectNodes("//lang[@id]"))
			{
				if (node.Attributes["id"].Value == languageID){
					foreach (XmlNode phrase in node.ChildNodes)
					{
						Debug.Log("Phrase " + phrase["id"].Value + " = " + phrase.Value);
						//dictionary.Add(phrase["id"].Value, phrase.Value);
					}
				}
			}
			return dictionary;
		}

	}
}

