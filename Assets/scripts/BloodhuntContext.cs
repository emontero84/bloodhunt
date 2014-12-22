using System;
using UnityEngine;
using bloodhunt.controller;
using bloodhunt.model;
using bloodhunt.view;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace bloodhunt
{
	public class BloodhuntContext : MVCSContext
	{
		public BloodhuntContext (MonoBehaviour view) : base(view)
		{
		}

		public BloodhuntContext (MonoBehaviour view, ContextStartupFlags flags) : base(view, flags)
		{
		}

		protected override void mapBindings()
		{
			// Model binding.
			injectionBinder.Bind<IBloodhuntModel>().To<BloodhuntModel>().ToSingleton();

			// View to Mediator binding.
			mediationBinder.Bind<ExampleView>().To<ExampleMediator>();

			// Event to Command binding.
			//commandBinder.Bind(BloodhuntEvent.REQUEST_WEB_SERVICE).To<CallWebServiceCommand>();
			commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once ();

			// Service binding.
			//injectionBinder.Bind<IExampleService>().To<ExampleService>().ToSingleton();

		}
	}
}

