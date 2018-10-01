using UnityEngine;
using System;

public class Intent : MonoBehaviour {

	public void launchApp(String bundleId)
	{
		AndroidJavaClass up = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject ca = up.GetStatic<AndroidJavaObject>("currentActivity");
		AndroidJavaObject packageManager = ca.Call<AndroidJavaObject>("getPackageManager");

		AndroidJavaObject launchIntent = null;
		try
		{
			launchIntent = packageManager.Call<AndroidJavaObject>("getLaunchIntentForPackage", bundleId);
		}
		catch (Exception e)
		{
		}

		ca.Call("startActivity", launchIntent);
		up.Dispose();
		ca.Dispose();
		packageManager.Dispose();
		launchIntent.Dispose();
	}

}
