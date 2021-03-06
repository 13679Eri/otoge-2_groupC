using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGenerator120 : MonoBehaviour
{
    [SerializeField] Note120 notePrefab;
    [SerializeField] Vector3 generatepos;
    [SerializeField] string tagname;

    // Noteを生成する
    //Prefab:Instantiate

    /* private void Start()
     {
         SpawnNote();
     }*/

    public void SpawnNote()
    {
        //Instantiate(生成したいもの, 場所, 角度);
        Note120 note = Instantiate(notePrefab, generatepos, Quaternion.identity);
        note.gameObject.tag = tagname;
    }

    /* private void Update()
     {
         if (Input.GetKeyDown(KeyCode.Space))
         {
             SpawnNote();
         }
     }*/
}
