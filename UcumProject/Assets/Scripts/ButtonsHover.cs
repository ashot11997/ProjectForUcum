using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonsHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Image BtnImage;
	public Image ActiveLine;
	public Text BtnText;

	private bool isActive = false;

	public void OnPointerEnter(PointerEventData eventData)
	{
		if (!isActive)
		{
			BtnImage.color = new Color32(26, 26, 26, 140);
			BtnText.color = new Color32(110, 169, 0, 255);
			ActiveLine.gameObject.SetActive(true);
		}
		else { }
		
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		if (!isActive)
		{
			BtnImage.color = new Color32(26, 26, 26, 120);
			BtnText.color = new Color32(255, 255, 255, 255);
			ActiveLine.gameObject.SetActive(false);
		}
		else { }
		
	}

	public void MakeActive() {
		isActive = true;
		BtnImage.color = new Color32(26, 26, 26, 140);
		BtnText.color = new Color32(110, 169, 0, 255);
		ActiveLine.gameObject.SetActive(true);
	}

	public void MakeDeActive()
	{
		isActive = false;
		BtnImage.color = new Color32(26, 26, 26, 120);
		BtnText.color = new Color32(255, 255, 255, 255);
		ActiveLine.gameObject.SetActive(false);
	}
}
