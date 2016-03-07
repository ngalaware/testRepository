using UnityEngine;
using System.Collections;

namespace Game 
{
	public class Scene_MainMenu
	{
		public void Update () {
			if (BuildUtils.isDebugBuild) {
				Debug.Log ("Scene Mainmenu Update");
				if (Input.GetKeyUp (KeyCode.Space)) {
					Application.LoadLevel ("scene_gameplay");
					GameSceneManager.instance.SetCurrentScene ((int)EnumScene.SCENE_GAMEPLAY);
				}
			}
		}
	}
}