using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberButtonController : MonoBehaviour {
    // ボタンのオブジェクトを宣言
    public GameObject NumberButtonprefab;
    // ボタンに設定する数値
    public int Number;
    // ボタンのサイズを設定
    public int Width = 70;
    public int Hight = 70;

	// Use this for initialization
	void Start () {
        // ボタンのサイズを変更

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Number);
            // クリックしたら消える
            Destroy(this.gameObject);
        }
    }
}
