using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectButtonScript : MonoBehaviour
{
    public void OnClickSelectButton()//�{�^����������
    {
        SceneManager.LoadScene("SampleScene");//SampleScene�Ɉړ�
    }

    public void OnClickSelectButton2()//�{�^����������
    {
        SceneManager.LoadScene("SampleScene2");//SampleScene�Ɉړ�
    }

    public void OnClickSelectButton3()//�{�^����������
    {
        SceneManager.LoadScene("SampleScene3");//SampleScene�Ɉړ�
    }

    public void OnHome()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
