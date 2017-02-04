using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class typewriter : MonoBehaviour {
    public string text;
    public float speed = 0.6f;
    public string currentText;

    void Start () {
        StartCoroutine(showDialogue());
	}

    IEnumerator showDialogue() {
        for (int i = 0; i < text.Length; i++) {
            currentText = text.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(speed);
        }
    }
}
