using System;
using UnityEngine;
using bloodhunt.events;
using bloodhunt.view;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace bloodhunt.controller {
	public class StartCommand : EventCommand
	{
		public override void Execute()
		{
			dispatcher.Dispatch(LoadLanguageEvent.LOAD_LANGUAGE);
		}
	}
}

