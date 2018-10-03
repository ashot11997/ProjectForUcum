using UnityEngine.UI;
using UnityEngine;

public class NewsController : MonoBehaviour {

	private enum NewsName
	{
		AzatutyunTv,
		HanrainTv
	};

	public Button News1;
	public Button News2;

	[SerializeField] NewPlaybackSystem VideoPlayer;

	void Awake()
	{
		News1.onClick.AddListener(() => {
			OpenNews(NewsName.AzatutyunTv);
		});
		News2.onClick.AddListener(() => {
			OpenNews(NewsName.HanrainTv);
		});
	}

	public void Open() {
		gameObject.SetActive(true);
	}

	public void Close()
	{
		gameObject.SetActive(false);
	}

	void OpenNews(NewsName type)
	{

		switch (type)
		{
			case NewsName.AzatutyunTv:
				VideoPlayer.PlayYoutubeVideo("TcutnIW0Pqw");
				break;
			case NewsName.HanrainTv:
				VideoPlayer.PlayYoutubeVideo("3m-KXvZX8cA");
				break;
		}
	}
}
