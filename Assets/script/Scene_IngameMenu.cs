using UnityEngine;
using System.Collections;

namespace Game {
	public class Scene_IngameMenu {
		public void Update () {
			if (BuildUtils.isDebugBuild) {
				Debug.Log ("::: GAME - Scene IGM Update");
				if (Input.GetKeyUp (KeyCode.Space)) {
					Application.LoadLevel ("scene_about");
					GameSceneManager.instance.SetCurrentScene ((int)EnumScene.SCENE_ABOUT);
				}
			}
		}
	}
}