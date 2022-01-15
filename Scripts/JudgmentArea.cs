using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgmentArea : MonoBehaviour
{
    //ノーツが落ちてきたときに、キーボードを押したら判定したい
    //・キーボード入力
    //・近くにノーツがあるのか:Rayを飛ばして当たったら近い！
    //・どのくらいの近さなのか　=> 評価

　  //評価エフェクト実装
   //・表示する文字のprefabを作成(EffectCanvas作成した)
   //・特定のタイミングでprefabを生成
   //・生成したprefabの文字を変える => Textコンポーネントを編集する(それ用のクラスを作る)

    [SerializeField] float radius;
    //GameManagerのAddScoreを実行したい
    [SerializeField] GameManager gameManager = default;
    [SerializeField] int areanumber;

    [SerializeField] GameObject textEffectPrefab;
    [SerializeField] float posy;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && areanumber == 1)
        {
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
            Debug.Log("aを入力");
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
            if (hit2D.transform.gameObject.CompareTag("Note1"))
            {
                Debug.Log("エリア1でノーツがぶつかった");
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
                    //Debug.Log("まあまあ");
                    gameManager.AddScore(10);
                    SpawmTextEffct("Good", textpos);
                }
                else
                {
                    //Debug.Log("ひどい");
                    gameManager.AddScore(0);
                    SpawmTextEffct("Miss", textpos);
                }

                //ぶつかったら破壊する
                Destroy(hit2D.collider.gameObject);
            }
        }
        if (Input.GetKeyDown(KeyCode.S) && areanumber == 2)
        {
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
            Debug.Log("sを入力");
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
            if (hit2D.transform.gameObject.CompareTag("Note2"))
            {
                Debug.Log("エリア2でノーツがぶつかった");
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
                    //Debug.Log("まあまあ");
                    gameManager.AddScore(10);
                    SpawmTextEffct("Good", textpos);
                }
                else
                {
                    //Debug.Log("ひどい");
                    gameManager.AddScore(0);
                    SpawmTextEffct("Miss", textpos);
                }

                //ぶつかったら破壊する
                Destroy(hit2D.collider.gameObject);
            }
        }

        if (Input.GetKeyDown(KeyCode.D) && areanumber == 3)
        {
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
            Debug.Log("dを入力");
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
            if (hit2D.transform.gameObject.CompareTag("Note3"))
            {
                Debug.Log("エリア3でノーツがぶつかった");
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
                    //Debug.Log("まあまあ");
                    gameManager.AddScore(10);
                    SpawmTextEffct("Good", textpos);
                }
                else
                {
                    //Debug.Log("ひどい");
                    gameManager.AddScore(0);
                    SpawmTextEffct("Miss", textpos);
                }

                //ぶつかったら破壊する
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

    //以下は可視化ツール
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
