using System;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace bloodhunt
{
	public class CharacterSelectionScreenViewMediator : EventMediator
	{
		[Inject]
		public CharacterSelectionScreenView view
		{
			get;
			set;
		}

		[Inject]
		public ILanguageModel languageModel
		{
			get;
			set;
		}

		public override void OnRegister()
		{

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
				languageModel.GetString("BRUJAH"),
				languageModel.GetString("GANGREL"),
				languageModel.GetString("MALKAVIAN"),
				languageModel.GetString("NOSFERATU"),
				languageModel.GetString("TOREADOR"),
				languageModel.GetString("TREMERE"),
				languageModel.GetString("VENTRUE")
			};
			string[] descriptions  = new string[VAMPIRE_CLANS]{
				languageModel.GetString("DESCRIPTION_BRUJAH"),
				languageModel.GetString("DESCRIPTION_GANGREL"),
				languageModel.GetString("DESCRIPTION_MALKAVIAN"),
				languageModel.GetString("DESCRIPTION_NOSFERATU"),
				languageModel.GetString("DESCRIPTION_TOREADOR"),
				languageModel.GetString("DESCRIPTION_TREMERE"),
				languageModel.GetString("DESCRIPTION_VENTRUE")
			};

			string nameText =languageModel.GetString("NAME");
			view.init (nameText, portraitPaths, clanNames, descriptions);
		}

		public override void OnRemove()
		{
			//Clean up listeners when the view is about to be destroyed
			//view.dispatcher.RemoveListener(ExampleView.CLICK_EVENT, onViewClicked);

			view.destroy();
		}

		private void onViewClicked()
		{
			Debug.Log("View click detected");
			dispatcher.Dispatch(BloodhuntEvent.REQUEST_WEB_SERVICE);
		}

	}
}

