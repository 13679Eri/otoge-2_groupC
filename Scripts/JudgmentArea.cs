using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgmentArea : MonoBehaviour
{
    //�m�[�c�������Ă����Ƃ��ɁA�L�[�{�[�h���������画�肵����
    //�E�L�[�{�[�h����
    //�E�߂��Ƀm�[�c������̂�:Ray���΂��ē���������߂��I
    //�E�ǂ̂��炢�̋߂��Ȃ̂��@=> �]��

�@  //�]���G�t�F�N�g����
   //�E�\�����镶����prefab���쐬(EffectCanvas�쐬����)
   //�E����̃^�C�~���O��prefab�𐶐�
   //�E��������prefab�̕�����ς��� => Text�R���|�[�l���g��ҏW����(����p�̃N���X�����)

    [SerializeField] float radius;
    //GameManager��AddScore�����s������
    [SerializeField] GameManager gameManager = default;
    [SerializeField] int areanumber;

    [SerializeField] GameObject textEffectPrefab;
    [SerializeField] float posy;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && areanumber == 1)
        {
            GetComponent<AudioSource>().Play();  // ���ʉ���炷
            Debug.Log("a�����");
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
            if (hit2D.transform.gameObject.CompareTag("Note1"))
            {
                Debug.Log("�G���A1�Ńm�[�c���Ԃ�����");
                float distance = Mathf.Abs (hit2D.transform.position.y - transform.position.y); //1-2 => -1
                Vector3 textpos = new Vector3(hit2D.transform.position.x, posy, hit2D.transform.position.z);
                if (distance < 3)
                {
                    //Debug.Log("Good!");
                    gameManager.AddScore(100);
                    SpawmTextEffct("Excellent!", textpos);
                }
                else if (distance < 5)
                {
                    //Debug.Log("�܂��܂�");
                    gameManager.AddScore(10);
                    SpawmTextEffct("Good", textpos);
                }
                else
                {
                    //Debug.Log("�Ђǂ�");
                    gameManager.AddScore(0);
                    SpawmTextEffct("Miss", textpos);
                }

                //�Ԃ�������j�󂷂�
                Destroy(hit2D.collider.gameObject);
            }
        }
        if (Input.GetKeyDown(KeyCode.S) && areanumber == 2)
        {
            GetComponent<AudioSource>().Play();  // ���ʉ���炷
            Debug.Log("s�����");
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
            if (hit2D.transform.gameObject.CompareTag("Note2"))
            {
                Debug.Log("�G���A2�Ńm�[�c���Ԃ�����");
                float distance = Mathf.Abs(hit2D.transform.position.y - transform.position.y); //1-2 => -1
                Vector3 textpos = new Vector3(hit2D.transform.position.x, posy, hit2D.transform.position.z);
                if (distance < 3)
                {
                    //Debug.Log("Good!");
                    gameManager.AddScore(100);
                    SpawmTextEffct("Excellent!", textpos);
                }
                else if (distance < 5)
                {
                    //Debug.Log("�܂��܂�");
                    gameManager.AddScore(10);
                    SpawmTextEffct("Good", textpos);
                }
                else
                {
                    //Debug.Log("�Ђǂ�");
                    gameManager.AddScore(0);
                    SpawmTextEffct("Miss", textpos);
                }

                //�Ԃ�������j�󂷂�
                Destroy(hit2D.collider.gameObject);
            }
        }

        if (Input.GetKeyDown(KeyCode.D) && areanumber == 3)
        {
            GetComponent<AudioSource>().Play();  // ���ʉ���炷
            Debug.Log("d�����");
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
            if (hit2D.transform.gameObject.CompareTag("Note3"))
            {
                Debug.Log("�G���A3�Ńm�[�c���Ԃ�����");
                float distance = Mathf.Abs(hit2D.transform.position.y - transform.position.y); //1-2 => -1
                Vector3 textpos = new Vector3(hit2D.transform.position.x, posy, hit2D.transform.position.z);
                if (distance < 3)
                {
                    //Debug.Log("Good!");
                    gameManager.AddScore(100);
                    SpawmTextEffct("Excellent!", textpos);
                }
                else if (distance < 5)
                {
                    //Debug.Log("�܂��܂�");
                    gameManager.AddScore(10);
                    SpawmTextEffct("Good", textpos);
                }
                else
                {
                    //Debug.Log("�Ђǂ�");
                    gameManager.AddScore(0);
                    SpawmTextEffct("Miss", textpos);
                }

                //�Ԃ�������j�󂷂�
                Destroy(hit2D.collider.gameObject);
            }
        }
    }

    void SpawmTextEffct(string  message, Vector3 position)
    {
        GameObject effect = Instantiate(textEffectPrefab, position, Quaternion.identity);
        JudgmentEffect judgmentEffect = effect.GetComponent<JudgmentEffect>();
        judgmentEffect.SetText(message);
    }

    //�ȉ��͉����c�[��
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
