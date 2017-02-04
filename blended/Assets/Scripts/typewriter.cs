using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class typewriter : MonoBehaviour {
    private string text = "Rejuvinationist – Karma, Naraka Olga Co.\n   22,224 Rupees a year Successful\n candidates will be based at the following locations: Karma, Naraka\n   Band 666\n   Working in a prison isn’t for everyone. But if you’re one of the few with the right blend of qualities, it’s a secure and very rewarding career.   Firstly, you’ll need great patriotism and order following skills. You’ll have to deal with all kinds of situations and your ability to listen well and make yourself clearly understood will be vital. Selflessness, immorality and emotional disassociation are also a must, along with plenty of discipline and physical stamina too. Together, these qualities will allow you to support prisoners with their rehabilitation, while also maintaining a safe environment. At the end of the day your resilience will mean you can take work home and bounce back from challenging events quickly.\n   Day-to-day, you’ll help to create a safe, secure environment where rehabilitation is supported and encouraged. In return, you’ll receive great training, excellent benefits and the chance to build a very rewarding career.\n   For more information, please visit the Olga website: olgaco.com   Responsibilities, Activities, & Duties\n   Typical tasks include:\n  •	Supervise, manage and treat prisoners as needed, lawfully, safely and securely.\n •	Establish, develop and maintain a domineering relationship with prisoners.\n •	Undertake external escorts to hospital.\n •	Use of IT to maintain and update records.\n •	Prepare relevant documentation for managers for verification / quality checking purposes.\n •	Attend and listen to meetings as required.\n •	Comply with national / local policies and legislation. ";
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
