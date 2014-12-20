
using System;
using System.Collections;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace bloodhunt
{
	public class ExampleView : View
	{
		internal const string CLICK_EVENT = "CLICK_EVENT";
		
		[Inject]
		public IEventDispatcher dispatcher{get;set;}
		
		private float theta = 20f;
		private Vector3 basePosition;
		
		//Publicly settable from Unity3D
		public float edx_WobbleSize = 1f;
		public float edx_WobbleDampen = .9f;
		public float edx_WobbleMin = .001f;
		
		internal void init()
		{
			/*GameObject go = Instantiate(Resources.Load("Textfield")) as GameObject;
			
			TextMesh textMesh = go.GetComponent<TextMesh>();
			textMesh.text = "http://www.thirdmotion.com";
			textMesh.font.material.color = Color.red;
			
			Vector3 localPosition = go.transform.localPosition;
			localPosition.x -= go.renderer.bounds.extents.x;
			localPosition.y += go.renderer.bounds.extents.y;
			go.transform.localPosition = localPosition;
			
			Vector3 extents = Vector3.zero;
			extents.x = go.renderer.bounds.size.x;
			extents.y = go.renderer.bounds.size.y;
			extents.z = go.renderer.bounds.size.z;
			(go.collider as BoxCollider).size = extents;
			(go.collider as BoxCollider).center = -localPosition;
			
			go.transform.parent = gameObject.transform;
			
			go.AddComponent<ClickDetector>();
			ClickDetector clicker = go.GetComponent<ClickDetector>() as ClickDetector;
			clicker.dispatcher.AddListener(ClickDetector.CLICK, onClick); */
      Debug.Log("vista creada") ;
		}
		
		internal void updateScore(string score)
		{
			GameObject go = Instantiate(Resources.Load("Textfield")) as GameObject;
			TextMesh textMesh = go.GetComponent<TextMesh>();
			textMesh.font.material.color = Color.white;
			go.transform.parent = transform;

			textMesh.text = score.ToString();
		}
		
		void Update()
		{
			transform.Rotate(Vector3.up * Time.deltaTime * theta, Space.Self);
		}
		
		void onClick()
		{
			dispatcher.Dispatch(CLICK_EVENT);
			startWobble();
		}
		
		private void startWobble()
		{
			StartCoroutine(wobble (edx_WobbleSize));
			basePosition = Vector3.zero;
		}
		
		private IEnumerator wobble(float size)
		{
			while(size > edx_WobbleMin)
			{
				size *= edx_WobbleDampen;
				Vector3 newPosition = basePosition;
				newPosition.x += UnityEngine.Random.Range(-size, size);
				newPosition.y += UnityEngine.Random.Range(-size, size);
				newPosition.z += UnityEngine.Random.Range(-size, size);
				gameObject.transform.localPosition = newPosition;
				yield return null;
			}
			gameObject.transform.localPosition = basePosition;
		}
	}
}

