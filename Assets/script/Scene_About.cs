using UnityEngine;
using System.Collections;

namespace Game {
	public class Scene_About{

		public void Update () {
			if (BuildUtils.isDebugBuild) {
				Debug.Log ("::: GAME - Scene About Update");
				if (Input.GetKeyUp (KeyCode.Space)) {
					Application.LoadLevel ("scene_onlines");
					GameSceneManager.instance.SetCurrentScene ((int)EnumScene.SCENE_ONLINES);
				}
			}
		}
	}
}