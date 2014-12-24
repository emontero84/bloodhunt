using System;
using UnityEngine;
using bloodhunt.service;
using bloodhunt.view;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace bloodhunt.controller {
	public class LoadLanguageCommand : EventCommand
	{
		[Inject]
		public ILoadLanguageService loadLanguageService
		{
			get;
			set;
		}

		public override void Execute()
		{
			Debug.Log("Loading language XML...");
			loadLanguageService.LoadLanguageXML("XML/language");
		}
	}
}

