using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace bloodhunt.view {

	public class ExampleView : EventView
	{
		internal void init()
		{
			SetCanvasText("Canvas/BackgroundImage/ClanText", "Nosferatu");
			SetCanvasText("Canvas/BackgroundImage/DescriptionText", "Toma mierder!");

			// TODO: seguir por aquí. La imagen que se carga dinámicamente no es correcta.
			SetPortraitImage("Canvas/BackgroundImage/PortraitImage", "sprites/character_creation_screen/portrait_nosferatu");
		}

		private void SetCanvasText(string textName, string text)
		{
			GameObject go = GameObject.Find(textName);
			Text textComponent = go.GetComponent<Text>();
			textComponent.text = text;
		}

		private void SetPortraitImage(string imageName, string spritePath)
		{
			GameObject go = GameObject.Find(imageName);
			Image imageComponent = go.GetComponent<Image>();
			imageComponent.sprite = Resources.Load<Sprite>(spritePath);
		}
	}
}

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              