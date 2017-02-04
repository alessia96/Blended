using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class curtainOpen : MonoBehaviour {

    public Image FadeImg;
    public float fadeSpeed = 1.5f;

    void Awake() {
        FadeImg.rectTransform.localScale = new Vector2(Screen.width, Screen.height);
    }

    void fadeToClear() {
        FadeImg.color = Color.Lerp(FadeImg.color, Color.clear, fadeSpeed * Time.deltaTime);
    }

    void Update() {
        fadeToClear();
    }
}
