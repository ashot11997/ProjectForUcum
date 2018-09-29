using UnityEngine.UI;
using UnityEngine;
using System;

public class HeaderUIController : MonoBehaviour {

	public Text TimeText;

	private float m_timer = 0;
	private float m_timeToUpdateTime = 60f;

	void Start () {
		
	}

	void Update () {
		if (m_timer > 0)
		{
			m_timer -= Time.deltaTime;
		}
		else
		{
			m_timer = m_timeToUpdateTime;
			SetTime();
		}
	}

	private void SetTime()
	{
		TimeText.text = DateTime.Now.ToShortTimeString();
	}
}
