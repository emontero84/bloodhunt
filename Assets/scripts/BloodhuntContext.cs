using System;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace bloodhunt {
	public class BloodhuntContext : MVCSContext
	{
		public BloodhuntContext (MonoBehaviour view) : base(view) {
		}

		public BloodhuntContext (MonoBehaviour view, ContextStartupFlags flags) : base(view, flags) {
		}

		protected override void mapBindings()
		{
			// Model binding.
			injectionBinder.Bind<ILanguageModel>().To<LanguageModel>().ToSingleton();

			// View to Mediator binding.
			mediationBinder.Bind<CharacterSelectionScreenView>().To<CharacterSelectionScreenViewMediator>();

			// Event to Command binding.
			commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once ();
			commandBinder.Bind(LoadLanguageEvent.LOAD_LANGUAGE).To<LoadLanguageCommand>().Once ();
			commandBinder.Bind(LoadLanguageEvent.LANGUAGE_XML_LOADED).To<OnLanguageLoadedCommand>().Once ();
			commandBinder.Bind(LoadLanguageEvent.LANGUAGE_LOADED).To<AddMainViewCommand>().Once ();

			commandBinder.Bind(BloodhuntEvent.LOAD_SCENE).To<LoadNewSceneCommand>();

			// Service binding.
			injectionBinder.Bind<ILoadLanguageService>().To<LoadLanguageService>().ToSingleton();

		}
	}
}

