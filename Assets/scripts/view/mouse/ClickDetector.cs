using System;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace bloodhunt
{
	public class ClickDetector : EventView
	{
		public const string CLICK = "ClickDetector.CLICK";

		void OnMouseDown()
		{
			dispatcher.Dispatch(CLICK);
		}
	}
}

