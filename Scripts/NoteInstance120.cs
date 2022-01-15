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
