using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    //下に落ちる
    //TODO:落ちる速度を局と判定場所との距離から設定する必要がある。
    //音を一小節分遅らせて鳴らす =>　ノーツは一小節分早く生成される
    //判定場所に来た時に音が鳴ればよい =>　速度:判定場所までの距離/1小節分の長さ(s)

    double speed;
    float a;

    //一小節の時間はいくらか？:BPMから計算する(4*60/120)
    //MIDIデータ見ると今回はBPM120 => 60秒間に120回音が入る　=> 1回当たり0.5秒(60/120)
    //一小節:音が4回鳴る => 4*0.5 = 2秒 => 一小節の長さは2秒

    //判定場所までの距離はいくらか？:Unity側の問題
    //70-(-50) => 120  (ノーツの生成場所(NoteGeneratorのY軸)-ジャッジメントエリアのY軸)

    private void Start()
    {
        speed = 62.5; // 120/2
        a = (float)speed;
    }


    void Update()
    {
        transform.Translate(0, -a * Time.deltaTime, 0);
    }

}
