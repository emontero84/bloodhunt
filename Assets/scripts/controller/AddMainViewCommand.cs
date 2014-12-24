using System;
using UnityEngine;
using bloodhunt.view;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace bloodhunt.controller {
	public class AddMainViewCommand : EventCommand
	{

		[Inject(ContextKeys.CONTEXT_VIEW)]
		public GameObject contextView {
			get;
			set;
		}

		public override void Execute()
		{
			Debug.Log("Adding main view...");

			GameObject go = new GameObject();
			go.name = "CharacterSelectionScreenView";
			go.AddComponent<CharacterSelectionScreenView>();
			go.transform.parent = contextView.transform;

			Debug.Log("Main view added. Ready to play...");
		}
	}
}

