using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ChartboostSDK

[RequireComponent(typeof(AudioSource))]
public class MainGUI : MonoBehaviour {

	public GUIStyle debugGUIStyle;

	// int variables that hold width & height of
	// users's device for cross-platform modes
	public int screenWidth;
	public int screenHeight;

	// variable to hold UI object
	Slider theSlider;

	public Slider mainSlider;

	// bool variable that detemrines whether the user has pressed a button to 
	// either exit the main menu to another menu or begin a level in game
	// (starts off true because the app starts in main menu when booted up)
	private bool mainMenu = true;

	//////////////////////////////////////////
	///  MUSIC SHIT/
	/// 

	// AUDIO RENDERER?

	// ASSIGNED IN INSPECTOR
	public AudioSource introMusic;
	//public AudioClip introuMusic2;

	public AudioClip ButtonSelect;

	// AppController script held in a variable
	AppController theAppController

	// Use this for pre-initializaiton
	void Awake ()
	{

		if 

	}

	// Use this for initialization
	void Start ()
	{

		// get/ set Audio Source from HELL MUSIC and play!
		//AudioSource introAudio = GetComponent<AudioSource> ();
		AudioSource introAudio = introMusic;
		introAudio.Play ();
		introAudio.Play (44100);

		//Displays the value of the slider in the console.
		Debug.Log(mainSlider.value);
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		// Displays the value of the slider in the console.
		Debug.Log(mainSlider.value);

		// rotates 30 degress per second around x axis
		theStatue.transform.Rotate (0, 30 * Time.deltaTime, 0);
		
	}

	public void LoadMusicPlayer()
	{


	}

	public void LoadRecentUpdates()
	{

		

	}

	public void LoadVideoPlayer()
	{



	}


}
