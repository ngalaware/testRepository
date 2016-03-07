using UnityEngine;
using System.Collections;

namespace Game {
	public class Scene_Gameplay {
		public void Update () {
			if (BuildUtils.isDebugBuild) {
				Debug.Log ("::: GAME - Scene Gameplay Update");
				if (Input.GetKeyUp (KeyCode.Space)) {
					Application.LoadLevel ("scene_ingamemenu");
					GameSceneManager.instance.SetCurrentScene ((int)EnumScene.SCENE_IGM);
				}
			}
		}
	}
}