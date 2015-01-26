using System;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace bloodhunt
{
	public class MouseOverDetector : EventView
	{
		public const string MOUSE_OVER = "MouseOverDetector.MOUSE_OVER";

		void OnMouseDown()
		{
			dispatcher.Dispatch(MOUSE_OVER);
		}
	}
}

