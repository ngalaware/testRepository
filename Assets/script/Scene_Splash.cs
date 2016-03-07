using UnityEngine;
using System.Collections;

namespace Game 
{
	public class Scene_Splash
	{
		public void Update () {
			if (BuildUtils.isDebugBuild) {
				Debug.Log (":: GAME - Scene Splash Update");
				if (Input.GetKeyUp (KeyCode.Space)) {
					SetCurrentScene (1);
				}
			}
		}

		public void SetCurrentScene (int scene)
		{
			Application.LoadLevel (scene);
			GameSceneManager.instance.SetCurrentScene ((int)EnumScene.SCENE_LOADING);
		}
	}

}