using System;
using UnityEngine;
using strange.extensions.context.impl;

namespace bloodhunt
{
	public class GameplayRoot : ContextView
	{
		
		void Awake()
		{
			context = new GameplayContext(this);
		}
	}
}


