using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // ���}�E�X�{�^�����N���b�N������
        {
            SceneManager.LoadScene("SelectScene");    // SampleScene�Ɉړ�
        }
    }
}
