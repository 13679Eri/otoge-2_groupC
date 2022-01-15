using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // 左マウスボタンをクリックしたら
        {
            SceneManager.LoadScene("SelectScene");    // SampleSceneに移動
        }
    }
}
