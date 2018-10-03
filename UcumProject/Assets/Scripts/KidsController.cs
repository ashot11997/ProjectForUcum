using UnityEngine.UI;
using UnityEngine;

public class KidsController : MonoBehaviour {

	private enum MovieName
	{
		NvagaxmbiErexanery
	};

	public Button Movie1;

	[SerializeField] NewPlaybackSystem VideoPlayer;

	void Awake()
	{
		Movie1.onClick.AddListener(() => {
			OpenMovie(MovieName.NvagaxmbiErexanery);
		});
	}

	public void Open() {
		gameObject.SetActive(true);
	}

	public void Close()
	{
		gameObject.SetActive(false);
	}

	void OpenMovie(MovieName type)
	{

		switch (type)
		{
			case MovieName.NvagaxmbiErexanery:
				VideoPlayer.PlayYoutubeVideo("ZMASACAmQV4");
				break;
		}
	}
}
