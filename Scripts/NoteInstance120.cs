using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance120 : MonoBehaviour
{
    [SerializeField] NoteGenerator120 noteGenerator1 = default;
    [SerializeField] NoteGenerator120 noteGenerator2 = default;
    [SerializeField] NoteGenerator120 noteGenerator3 = default;

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
