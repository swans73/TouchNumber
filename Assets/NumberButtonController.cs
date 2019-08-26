using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberButtonController : MonoBehaviour {
    public Text Text;
    public int Number;
    public GameObject NumberButtonPrefab;
	// Use this for initialization
	void Start () {
        for (int i = 2; i < 10; i++)
        {
            GameObject gameobject = GameObject.Find("GameObject");
            var instance = Instantiate(NumberButtonPrefab);

            instance.transform.SetParent(gameobject.transform, false);
            instance.GetComponent<NumberButtonController>().Number = i;

            instance.name = "Button" + i;
        }

       
    }
	
	// Update is called once per frame
	void Update () {
        GameObject Button1 = GameObject.Find("Button1");

        Text.text = Number.ToString();
    }
  
    }
