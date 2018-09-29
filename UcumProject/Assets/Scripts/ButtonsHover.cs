using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonsHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Image BtnImage;
	public Image ActiveLine;
	public Text BtnText;

	public void OnPointerEnter(PointerEventData eventData)
	{
		BtnImage.color = new Color32(26,26,26,140);
		BtnText.color = new Color32(110, 169, 0, 255);
		ActiveLine.gameObject.SetActive(true);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		BtnImage.color = new Color32(26, 26, 26, 120);
		BtnText.color = new Color32(255, 255, 255, 255);
		ActiveLine.gameObject.SetActive(false);
	}
}
