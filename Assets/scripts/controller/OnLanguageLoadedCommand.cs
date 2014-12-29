using UnityEngine;
using bloodhunt.events;
using bloodhunt.model.language;
using bloodhunt.service;
using strange.extensions.command.impl;

namespace bloodhunt.controller {
	public class OnLanguageLoadedCommand : EventCommand
	{
		[Inject]
		public ILoadLanguageService loadLanguageService {
			get;
			set;
		}

		[Inject]
		public ILanguageModel languageModel {
			get;
			set;
		}

		public override void Execute()
		{
			Debug.Log("Initializing language model...");

			languageModel.Language = languageModel.LANGUAGE_ES;
			languageModel.SetDictionary(loadLanguageService.GetLanguageDictionary(languageModel.Language));

			Debug.Log("Language model initialized.");

			dispatcher.Dispatch(LoadLanguageEvent.LANGUAGE_LOADED);
		}
	}
}

