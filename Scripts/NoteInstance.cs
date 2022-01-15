using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{
    [SerializeField] NoteGenerator noteGenerator1 = default;
    [SerializeField] NoteGenerator noteGenerator2 = default;
    [SerializeField] NoteGenerator noteGenerator3 = default;

    public void NoteAEvent()
    {
        //Debug.Log("�������");
        //�h�A�t�@�A�V
        noteGenerator1.SpawnNote();
    }

    public void NoteSEvent()
    {
        //���A�\
        noteGenerator2.SpawnNote();
    }

    public void NoteDEvent()
    {
        //�~�A��
        noteGenerator3.SpawnNote();
    }

}
