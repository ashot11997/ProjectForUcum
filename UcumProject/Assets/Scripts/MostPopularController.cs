﻿using UnityEngine.UI;
using UnityEngine;

public class MostPopularController : MonoBehaviour {

	private enum AppName
	{
		Discovery,
		BBC,
		Within,
		Jaint,
		RedBull,
		Disney,
		CNN,
		NewYorkTimes,
		Yoga
	};

	public Button DiscoveryBtn;
	public Button BBCBtn;
	public Button WithinBtn;
	public Button JaintBtn;
	public Button RBBtn;
	public Button DisneyBtn;
	public Button CNNBtn;
	public Button NYTBtn;
	public Button YogaBtn;

	public Intent Intent;

	void Awake()
	{
		DiscoveryBtn.onClick.AddListener(() => {
			OpenApp(AppName.Discovery);
		});
		BBCBtn.onClick.AddListener(() => {
			OpenApp(AppName.BBC);
		});
		WithinBtn.onClick.AddListener(() => {
			OpenApp(AppName.Within);
		});
		JaintBtn.onClick.AddListener(() => {
			OpenApp(AppName.Jaint);
		});
		RBBtn.onClick.AddListener(() => {
			OpenApp(AppName.RedBull);
		});
		DisneyBtn.onClick.AddListener(() => {
			OpenApp(AppName.Disney);
		});
		CNNBtn.onClick.AddListener(() => {
			OpenApp(AppName.CNN);
		});
		NYTBtn.onClick.AddListener(() => {
			OpenApp(AppName.NewYorkTimes);
		});
		YogaBtn.onClick.AddListener(() => {
			OpenApp(AppName.Yoga);
		});
	}

	public void Open() {
		gameObject.SetActive(true);
	}

	public void Close()
	{
		gameObject.SetActive(false);
	}

	void OpenApp(AppName type)
	{

		switch (type)
		{
			case AppName.Discovery:
				Intent.launchApp("com.templegatesgames.DiscoveryGear");
				break;
			case AppName.BBC:
				Intent.launchApp("uk.co.bbc.vr");
				break;
			case AppName.Within:
				Intent.launchApp("com.shakingearthdigital.vrse");
				break;
			case AppName.Jaint:
				Intent.launchApp("com.jauntvr.android.player.gearvr");
				break;
			case AppName.RedBull:
				//Intent.launchApp("com.nousguide.android.rbtv");
				Intent.launchApp("com.oculus.tv");
				break;
			case AppName.Disney:
				Intent.launchApp("com.disney.dmvr");
				break;
			case AppName.CNN:
				Intent.launchApp("com.mobile.cnnvr");
				break;
			case AppName.NewYorkTimes:
				Intent.launchApp("co.vusr.nytvr.gearvr");
				break;
			case AppName.Yoga:
				Intent.launchApp("com.CubicleNinjas.GMVRMobile");
				break;
		}
	}

	/*AndroidJavaClass activityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        activityContext = activityClass.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaClass pluginClass = new AndroidJavaClass("com.lightshaft.youtube.MainActivity");

            if (pluginClass != null)
            {
                activityContext.Call("runOnUiThread", new AndroidJavaRunnable(() =>
                {
                    mycall = pluginClass.CallStatic<AndroidJavaObject>("instance");
                    mycall.Call("setContext", activityContext);
                    if (mycall.Call<bool>("PlayCustomVideoList", videos, youtubeDeveloperKey, startIndex, time, autoplay, lightBoxMode))
                    {
                        Debug.Log("OK PLAYBACK");
                    }
                    else
                    {
                        Debug.Log("YOU DONT HAVE YOUTUBE APP INSTALLED!");
                        Application.OpenURL(youtubeAPPDownload); //Open playstore to download the youtube
                    }
                }));
            }*/
}
