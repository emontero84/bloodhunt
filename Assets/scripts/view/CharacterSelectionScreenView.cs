using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace bloodhunt.view {

	public class CharacterSelectionScreenView : EventView
	{
		private Sprite[] _portraits;
		private string[] _clanNames;
		private string[] _descriptions;

		internal void init(string nameText, string[] portraitPaths, string[] clanNames, string[] descriptions)
		{
			_portraits = new Sprite[portraitPaths.Length];
			for (int i = 0; i< portraitPaths.Length; i++)
			{
				_portraits[i] = Resources.Load<Sprite>(portraitPaths[i]);
			}
			_clanNames = clanNames;
			_descriptions = descriptions;

			SetCanvasText("Canvas/NameText", nameText);

			SetClanSelected(0);
		}

		private void SetClanSelected(int index)
		{
			SetCanvasText("Canvas/ClanText", _clanNames[index]);
			SetCanvasText("Canvas/DescriptionText", _descriptions[index]);
			SetPortraitImage("Canvas/PortraitImage", _portraits[index]);
		}
		private void SetCanvasText(string textName, string text)
		{
			GameObject go = GameObject.Find(textName);
			Text textComponent = go.GetComponent<Text>();
			textComponent.text = text;
		}

		private void SetPortraitImage(string imageName, Sprite sprite)
		{
			GameObject go = GameObject.Find(imageName);
			Image imageComponent = go.GetComponent<Image>();
			imageComponent.sprite = sprite;
		}
	}
}

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              