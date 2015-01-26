using System;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace bloodhunt
{
	public class GameplayViewMediator : EventMediator
	{
		[Inject]
		public GameplayView view { get; set; }
		

		public override void OnRegister()
		{
			Debug.Log ("med");
			view.init ();
		}
		
		public override void OnRemove()
		{
			//Clean up listeners when the view is about to be destroyed

			view.destroy();
		}		
	}
}

