using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGenerator120 : MonoBehaviour
{
    [SerializeField] Note120 notePrefab;
    [SerializeField] Vector3 generatepos;
    [SerializeField] string tagname;

    // NoteÇê∂ê¨Ç∑ÇÈ
    //Prefab:Instantiate

    /* private void Start()
     {
         SpawnNote();
     }*/

    public void SpawnNote()
    {
        //Instantiate(ê∂ê¨ÇµÇΩÇ¢Ç‡ÇÃ, èÍèä, äpìx);
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
