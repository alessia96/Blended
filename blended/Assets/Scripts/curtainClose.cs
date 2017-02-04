using UnityEngine;
using UnityEngine.UI;

public class curtainClose : MonoBehaviour {

    public Image FadeImg;
    public float FadeSpeed;

    void Awake() {
        FadeImg.rectTransform.localScale = new Vector2(Screen.width, Screen.height);
    }

    void Fade() {
        FadeImg.color = Color.Lerp(FadeImg.color, Color.black, FadeSpeed * Time.deltaTime);
    }

    void Update() {
        Fade();
    }
}
