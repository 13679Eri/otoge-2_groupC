using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectButtonScript : MonoBehaviour
{
    public void OnClickSelectButton()//ボタン押したら
    {
        SceneManager.LoadScene("SampleScene");//SampleSceneに移動
    }

    public void OnClickSelectButton2()//ボタン押したら
    {
        SceneManager.LoadScene("SampleScene2");//SampleSceneに移動
    }

    public void OnClickSelectButton3()//ボタン押したら
    {
        SceneManager.LoadScene("SampleScene3");//SampleSceneに移動
    }

    public void OnHome()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
