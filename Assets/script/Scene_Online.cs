using UnityEngine;
using System.Collections;

namespace Game {
	public class Scene_Online {

		public void Update () {
			if (BuildUtils.isDebugBuild) {
				Debug.Log ("::: GAME - Scene Onlines Update");
			}
		}
	}
}