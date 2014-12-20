using System;
using UnityEngine;
using strange.extensions.context.impl;

namespace bloodhunt
{
	public class ProjectRoot : ContextView
	{

		void Awake()
		{
			context = new BloodhuntContext(this);
		}
	}
}

