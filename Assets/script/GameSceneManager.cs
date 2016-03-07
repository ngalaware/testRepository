using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Game {
	public class GameSceneManager : MonoBehaviour 
	{
		// Singleton
		public static GameSceneManager instance;
		private int currentScene = (int) EnumScene.SCENE_SPLASH;

		// register splash scene
		public Scene_Splash sceneSplash 	= new Scene_Splash ();
		public Scene_Loading sceneLoading 	= new Scene_Loading ();
		public Scene_MainMenu sceneMainmenu = new Scene_MainMenu ();
		public Scene_Gameplay sceneGameplay = new Scene_Gameplay ();
		public Scene_IngameMenu sceneIGM	= new Scene_IngameMenu ();
		public Scene_About	sceneAbout		= new Scene_About ();
		public Scene_Online sceneOnline		= new Scene_Online();

		// Use this for initialization
		void Start () {
			if (instance != null) {
				GameObject.Destroy (gameObject);
			} else {
				GameObject.DontDestroyOnLoad (gameObject);
				instance = this;
			}
		}

		public GameSceneManager GetGameSceneManagerInstance ()
		{
			return instance;
		}
		// Update is called once per frame
		void Update () {
			switch (GetCurrentScene())
			{
				case (int) EnumScene.SCENE_NONE:
					{
						SetCurrentScene ((int)EnumScene.SCENE_SPLASH);
					}
					break;
				case (int) EnumScene.SCENE_SPLASH:
					{
					sceneSplash.Update ();
					}
					break;
				case (int) EnumScene.SCENE_LOADING:
					{	
					sceneLoading.Update ();
					}
					break;
				case (int) EnumScene.SCENE_MAINMENU:
					{
					sceneMainmenu.Update ();
					}
					break;
				case (int) EnumScene.SCENE_GAMEPLAY:
					{
					sceneGameplay.Update ();
					}
					break;
				case (int) EnumScene.SCENE_IGM:
					{
					sceneIGM.Update ();
					}
					break;
				case (int) EnumScene.SCENE_ABOUT:
					{
					sceneAbout.Update ();
					}
					break;
				case (int) EnumScene.SCENE_ONLINES:
					{
					sceneOnline.Update ();
					}
					break;
				default:
					break;
			}
		}

		// Set Current Scene
		public void SetCurrentScene (int scene)
		{
			this.currentScene = scene;
			Application.LoadLevel (scene);
		}

		// Get Current Scene
		public int GetCurrentScene ()
		{
			return this.currentScene;
			Debug.Log ("Get Current Scene " + this.currentScene);
		}
	}
}