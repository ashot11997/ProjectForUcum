using UnityEngine;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour {

	private enum MenuType
	{
		MostPopular,
		Movies,
		Games,
		Education,
		Kids,
		Music,
		News,
	};

	[SerializeField] MostPopularController MostPopularSection;
	[SerializeField] MovieController MovieSection;
	[SerializeField] NewsController NewsSection;
	[SerializeField] KidsController KidsSection;

	public ButtonsHover MostPopularBtn;
	public ButtonsHover MoviesBtn;
	public ButtonsHover GamesBtn;
	public ButtonsHover EducationBtn;
	public ButtonsHover KidsBtn;
	public ButtonsHover MusicBtn;
	public ButtonsHover NewsBtn;

	void Awake() {
		MostPopularBtn.GetComponent<Button>().onClick.AddListener(() => {
			OpenMenu(MenuType.MostPopular);
		});

		MoviesBtn.GetComponent<Button>().onClick.AddListener(() => {
			OpenMenu(MenuType.Movies);
		});

		NewsBtn.GetComponent<Button>().onClick.AddListener(() => {
			OpenMenu(MenuType.News);
		});

		KidsBtn.GetComponent<Button>().onClick.AddListener(() => {
			OpenMenu(MenuType.Kids);
		});
	}

	void OpenMenu(MenuType type) {
		switch(type)
		{
			case MenuType.MostPopular:
				MovieSection.Close();
				NewsSection.Close();
				KidsSection.Close();

				MostPopularBtn.MakeActive();
				MoviesBtn.MakeDeActive();
				GamesBtn.MakeDeActive();
				EducationBtn.MakeDeActive();
				KidsBtn.MakeDeActive();
				MusicBtn.MakeDeActive();
				NewsBtn.MakeDeActive();

				MostPopularSection.Open();
				break;
			case MenuType.Movies:
				MostPopularSection.Close();
				NewsSection.Close();
				KidsSection.Close();

				MostPopularBtn.MakeDeActive();
				MoviesBtn.MakeActive();
				GamesBtn.MakeDeActive();
				EducationBtn.MakeDeActive();
				KidsBtn.MakeDeActive();
				MusicBtn.MakeDeActive();
				NewsBtn.MakeDeActive();

				MovieSection.Open();
				break;

			case MenuType.News:
				MostPopularSection.Close();
				MovieSection.Close();
				KidsSection.Close();

				MostPopularBtn.MakeDeActive();
				MoviesBtn.MakeDeActive();
				GamesBtn.MakeDeActive();
				EducationBtn.MakeDeActive();
				KidsBtn.MakeDeActive();
				MusicBtn.MakeDeActive();
				NewsBtn.MakeActive();

				NewsSection.Open();
				break;

			case MenuType.Kids:
				MostPopularSection.Close();
				MovieSection.Close();
				NewsSection.Close();

				MostPopularBtn.MakeDeActive();
				MoviesBtn.MakeDeActive();
				GamesBtn.MakeDeActive();
				EducationBtn.MakeDeActive();
				KidsBtn.MakeActive();
				MusicBtn.MakeDeActive();
				NewsBtn.MakeDeActive();

				KidsSection.Open();
				break;
		}
	}
}