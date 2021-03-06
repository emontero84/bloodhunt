using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace bloodhunt {

	public class CharacterSelectionScreenView : EventView
	{
		private Sprite[] _portraits;
		private GameObject[] _characters;
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

			_characters = new GameObject[portraitPaths.Length];
			for (int i = 0; i < portraitPaths.Length; i++)
			{
				_characters[i] = GameObject.Find("Canvas/ClanImage" + (i+1));
				_characters[i].AddComponent<ClickDetector>();
				ClickDetector clicker = _characters[i].GetComponent<ClickDetector>() as ClickDetector;
				clicker.dispatcher.AddListener(ClickDetector.CLICK, onCharacterClick);
			}
		}

		private void SetClanSelected(int index)
		{
			SetCanvasText("Canvas/ClanText", _clanNames[index]);
			SetCanvasText("Canvas/DescriptionText", _descriptions[index]);
			SetCanvasImage("Canvas/PortraitImage", _portraits[index]);
		}

		private void SetCanvasText(string textName, string text)
		{
			GameObject go = GameObject.Find(textName);
			Text textComponent = go.GetComponent<Text>();
			textComponent.text = text;
		}

		private void SetCanvasImage(string imageName, Sprite sprite)
		{
			GameObject go = GameObject.Find(imageName);
			Image imageComponent = go.GetComponent<Image>();
			imageComponent.sprite = sprite;
		}

		private void onCharacterClick()
		{
			Debug.Log ("clic en imagen");
			dispatcher.Dispatch(CharacterSelectionScreenEvent.CLAN_SELECTED);
		}

		public void destroy()
		{
			for (int i = 0; i < _characters.Length; i++)
			{
				ClickDetector clicker = _characters[i].GetComponent<ClickDetector>() as ClickDetector;
				clicker.dispatcher.RemoveListener(ClickDetector.CLICK, onCharacterClick);
			}
			// TODO destroy everything
		}
	}
}

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              