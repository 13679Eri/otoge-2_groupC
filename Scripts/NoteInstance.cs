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
        //Debug.Log("音が鳴るよ");
        //ド、ファ、シ
        noteGenerator1.SpawnNote();
    }

    public void NoteSEvent()
    {
        //レ、ソ
        noteGenerator2.SpawnNote();
    }

    public void NoteDEvent()
    {
        //ミ、ラ
        noteGenerator3.SpawnNote();
    }

}
