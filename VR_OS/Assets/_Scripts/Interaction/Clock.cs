using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Clock : MonoBehaviour {

    private Text clockText;


    void Start()
    {
        clockText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update () {
        System.DateTime time = System.DateTime.Now;

        clockText.text = time.ToString("hh:mm:tt");

        //for every second
        //StartCoroutine("Blink");

    }



    //a coroutine that 
    //IEnumerator Blink (System.DateTime time)
    //{
       // print(clockText);
    //}

}
