using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
	public class targetData : MonoBehaviour
	{

		public Transform TextTargetName;


		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			StateManager sm = TrackerManager.Instance.GetStateManager();
			IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

			foreach (TrackableBehaviour tb in tbs) {
				string name = tb.TrackableName;
				ImageTarget it = tb.Trackable as ImageTarget;
				Vector2 size = it.GetSize ();

				Debug.Log ("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

				//Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

				TextTargetName.GetComponent<Text> ().text = name;
			}
		}
	}
}