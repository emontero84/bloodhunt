
using System;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace bloodhunt
{
	public class ExampleMediator : EventMediator
	{
		[Inject]
		public ExampleView view{ get; set;}
		
		public override void OnRegister()
		{
			
			//Listen to the view for an event
			view.dispatcher.AddListener(ExampleView.CLICK_EVENT, onViewClicked);
			
			//Listen to the global event bus for events
			dispatcher.AddListener(BloodhuntEvent.SCORE_CHANGE, onScoreChange);
			
			view.init ();
		}
		
		public override void OnRemove()
		{
			//Clean up listeners when the view is about to be destroyed
			view.dispatcher.RemoveListener(ExampleView.CLICK_EVENT, onViewClicked);
			dispatcher.RemoveListener(BloodhuntEvent.SCORE_CHANGE, onScoreChange);
			Debug.Log("Mediator OnRemove");
		}
		
		private void onViewClicked()
		{
			Debug.Log("View click detected");
			dispatcher.Dispatch(BloodhuntEvent.REQUEST_WEB_SERVICE);
		}
		
		private void onScoreChange(IEvent evt)
		{
			//float score = (float)evt.data;
			string score = (string)evt.data;
			view.updateScore(score);
		}
	}
}

