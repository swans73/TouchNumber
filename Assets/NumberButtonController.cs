using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberButtonController : MonoBehaviour {

    public int start = 1;
    public int end = 10;

    public Text Text;
    public GameObject NumberButtonPrefab;

    List<int> number = new List<int>();


    // Use this for initialization
    void Start()
    {

        for (int i = start; i < end; i++)
        {
            //List内にnumberを格納
            number.Add(i);
        }

        //numberが0になるまで実行する
        while (number.Count > 0)
        {

            //Random.Rangeを宣言
            int index = Random.Range(0, number.Count);
            int ransu = number[index];



            GameObject NBC = GameObject.Find("NumberButtonController");
            var instance = Instantiate(NumberButtonPrefab);

            //NumberButtonControllerにNumberButtonPrefabを格納
            instance.transform.SetParent(NBC.transform, false);
            //NumberButtonPrefabに値を表示
            instance.GetComponent<NumberButtonController>().Text.text = ransu.ToString();

            Debug.Log(ransu); 
             //ボタンの名前を変更
            instance.name = "Button" + ransu;
            //Listからnumberを削除
            number.RemoveAt(index);


        }

    }

        // Update is called once per frame
        void Update()
        {

        }

    }