using System;
using UnityEngine;
using bloodhunt.events;
using bloodhunt.model.language;
using bloodhunt.service;
using bloodhunt.view;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace bloodhunt.controller {
	public class OnLanguageLoadedCommand : EventCommand
	{
		[Inject]
		public ILoadLanguageService loadLanguageService
		{
			get;
			set;
		}

		[Inject]
		public ILanguageModel languageModel
		{
			get;
			set;
		}

		public override void Execute()
		{
			Debug.Log("Initializing language model...");

			//TODO languageModel.Language = languageModel.LANGUAGE_ES;
			//TODO languageModel.SetDictionary(loadLanguageService.xml);

			loadLanguageService.GetLanguageDictionary("es");

			dispatcher.Dispatch(LoadLanguageEvent.LANGUAGE_LOADED);
			Debug.Log("Language model initialized.");
		}
	}
}

