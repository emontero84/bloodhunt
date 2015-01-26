using System;
using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace bloodhunt {
	public class AddGameplayViewCommand : EventCommand
	{
		
		[Inject(ContextKeys.CONTEXT_VIEW)]
		public GameObject contextView {
			get;
			set;
		}
		
		public override void Execute()
		{
			Debug.Log("Adding Gameplay view...");
			
			GameObject go = new GameObject();
			go.name = "GameplayView";
			go.AddComponent<GameplayView>();
			go.transform.parent = contextView.transform;
			
			Debug.Log("Gameplay view added. Ready to play...");
		}
	}
}


