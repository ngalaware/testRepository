using UnityEngine;
using System.Collections;

namespace Game{
	public class Scene_Loading {
		
		public void Update () {
			if (BuildUtils.isDebugBuild) {
				Debug.Log ("::: GAME - Scene Loading Update");
				if (Input.GetKeyUp (KeyCode.Space)) {
					Application.LoadLevel ("scene_mainmenu");
					GameSceneManager.instance.SetCurrentScene ((int)EnumScene.SCENE_MAINMENU);
				}
			}
		}
	}
}