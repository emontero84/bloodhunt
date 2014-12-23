using System;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using bloodhunt.events;

namespace bloodhunt.view
{
	public class CharacterSelectionScreenViewMediator : EventMediator
	{
		[Inject]
		public CharacterSelectionScreenView view
		{
			get;
			set;
		}

		public override void OnRegister()
		{

			//Listen to the view for an event
			//view.dispatcher.AddListener(ExampleView.CLICK_EVENT, onViewClicked);

			const int VAMPIRE_CLANS = 7;
			string[] portraitPaths = new string[VAMPIRE_CLANS]{
				"Sprites/CharacterSelectionScreen/portrait_brujah",
				"Sprites/CharacterSelectionScreen/portrait_gangrel",
				"Sprites/CharacterSelectionScreen/portrait_malkavian",
				"Sprites/CharacterSelectionScreen/portrait_nosferatu",
				"Sprites/CharacterSelectionScreen/portrait_toreador",
				"Sprites/CharacterSelectionScreen/portrait_tremere",
				"Sprites/CharacterSelectionScreen/portrait_ventrue"
			};
			string[] clanNames = new string[VAMPIRE_CLANS]{
				"brujah",
				"gangrel",
				"malkavian",
				"nosferatu",
				"toreador",
				"tremere",
				"ventrue"
			};
			string[] descriptions  = new string[VAMPIRE_CLANS]{
				"Description of brujah",
				"Description of gangrel",
				"Description of malkavian",
				"Description of nosferatu",
				"Description of toreador",
				"Description of tremere",
				"Description of ventrue"
			};

			view.init (portraitPaths, clanNames, descriptions);
		}

		public override void OnRemove()
		{
			//Clean up listeners when the view is about to be destroyed
			//view.dispatcher.RemoveListener(ExampleView.CLICK_EVENT, onViewClicked);
		}

		private void onViewClicked()
		{
			Debug.Log("View click detected");
			dispatcher.Dispatch(BloodhuntEvent.REQUEST_WEB_SERVICE);
		}

	}
}

