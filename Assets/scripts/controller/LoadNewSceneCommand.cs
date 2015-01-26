using System;
using System.Collections;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.command.impl;
using strange.extensions.dispatcher.eventdispatcher.api;


namespace bloodhunt {
	public class LoadNewSceneCommand : EventCommand
	{
		[Inject(ContextKeys.CONTEXT_VIEW)]
		public GameObject contextView { get; set; }

		public override void Execute()
		{
			string filepath = evt.data as string;
				
			if (String.IsNullOrEmpty(filepath))
			{
				throw new Exception("Can't load a module with a null or empty filepath.");
			}
			Application.LoadLevelAdditive(filepath);
			Debug.Log("Loading new scene " + filepath + "...");
		}
	}
}

