using UnityEngine.UI;
using UnityEngine;

public class MovieController : MonoBehaviour {

	private enum MovieName
	{
		Azizyanner,
		HinArqaner
	};

	public Button Movie1;
	public Button Movie2;

	[SerializeField] NewPlaybackSystem VideoPlayer;

	public Material TvPano;
	public GameObject Menu;

	void Awake()
	{
		Movie1.onClick.AddListener(() => {
			OpenMovie(MovieName.Azizyanner);
		});
		Movie2.onClick.AddListener(() => {
			OpenMovie(MovieName.HinArqaner);
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
			case MovieName.Azizyanner:
				//VideoPlayer.Open();
				VideoPlayer.PlayYoutubeVideo("9aHlFdot3kI");
				/*RenderSettings.skybox = TvPano;
				Menu.SetActive(false);*/
				break;
			case MovieName.HinArqaner:
				//VideoPlayer.Open();
				VideoPlayer.PlayYoutubeVideo("NX9I3HuYu3k");
				/*RenderSettings.skybox = TvPano;
				Menu.SetActive(false);*/
				break;
		}
	}
}
