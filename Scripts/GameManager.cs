using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine.Timeline;


[RequireComponent(typeof(PlayableDirector))]
public class GameManager : MonoBehaviour
{
    //カウントダウンのテキスト
    [SerializeField] Text countDownText = default;

    //ゲーム終了時のリザルトパネル
    [SerializeField] GameObject resultPanel = default;
    //リトライボタン：シーンの再読み込み

    //ゲーム中のスコア表示
    [SerializeField] Text scoreText = default;

    //ゲーム終了後のスコア表示
    [SerializeField] Text textScore = default;

    [SerializeField] PlayableDirector playableDirector;

    //timelineの配列
   // [SerializeField] private TimelineAsset[] timelines;
   // private PlayableDirector director;

    int score;

    void Start()
    {
        StartCoroutine(GameMain());
        //timeline
        //director = this.GetComponent<PlayableDirector>();
    }

    IEnumerator GameMain()
    {
        countDownText.text = "3";
        yield return new WaitForSeconds(1);
        countDownText.text = "2";
        yield return new WaitForSeconds(1);
        countDownText.text = "1";
        yield return new WaitForSeconds(1);
        countDownText.text = "GO!";
        yield return new WaitForSeconds(0.5f);
        countDownText.text = "";
        playableDirector.Play();
    }

    //どのタイミングでスコアを上昇させる
    public void AddScore(int point)
    {
        score += point;
        scoreText.text = score.ToString();
        textScore.text = score.ToString();
        Debug.Log(score);
    }

    public void OnEndEvent()
    {
        Debug.Log("ゲーム終了:結果表示"); //タイムライン終了の検知
        resultPanel.SetActive(true);
    }

    public void OnRetry()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnRetry2()
    {
        SceneManager.LoadScene("SampleScene2");
    }

    public void OnRetry3()
    {
        SceneManager.LoadScene("SampleScene3");
    }

    public void OnHome()
    {
        SceneManager.LoadScene("HomeScene");
    }

    /*public void EventPlay()
    {
        int number = SongName.a;
        Debug.Log("曲は");
        Debug.Log(number);
        switch (number)
        {
            case 1:
                director.Play(timelines[0]);
                break;
            case 2:
                director.Play(timelines[1]);
                break;
            case 3:
                director.Play(timelines[2]);
                break;
        }
    }*/
}
