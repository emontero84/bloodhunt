using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;

namespace bloodhunt {
	public class LoadLanguageService : ILoadLanguageService
	{
		[Inject(ContextKeys.CONTEXT_DISPATCHER)]
		public IEventDispatcher dispatcher {
			get;
			set;
		}

		private XmlDocument _xml;

		public LoadLanguageService () {
		}

		public XmlDocument xml {
			get {
				return _xml;
			}
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
			foreach (XmlNode node in _xml.GetElementsByTagName("lang")) {
				if (node.Attributes["id"].InnerText == languageID) {
					foreach (XmlNode phrase in node.SelectNodes("phrase")) {
						dictionary.Add(phrase.Attributes["id"].InnerText, phrase.InnerText);
					}
					break;
				}
			}
			return dictionary;
		}

	}
}

