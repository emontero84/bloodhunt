using System;
using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace bloodhunt {
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

			dispatcher.Dispatch(BloodhuntEvent.LOAD_SCENE, "Gameplay");
		}
	}
}

