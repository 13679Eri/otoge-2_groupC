using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGenerator : MonoBehaviour
{
    [SerializeField] Note notePrefab;
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
        Note note = Instantiate(notePrefab, generatepos, Quaternion.identity);
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
