using System;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace bloodhunt
{
	public class GameplayContext : MVCSContext
	{
		
		public GameplayContext (MonoBehaviour view) : base(view)
		{
		}
		
		public GameplayContext (MonoBehaviour view, ContextStartupFlags flags) : base(view, flags)
		{
		}
		
		protected override void mapBindings()
		{

			// View to Mediator binding.
			mediationBinder.Bind<GameplayView>().To<GameplayViewMediator>();

			// Event to Command binding.
			commandBinder.Bind(ContextEvent.START).To<AddGameplayViewCommand>().Once ();



		}
	}
}

