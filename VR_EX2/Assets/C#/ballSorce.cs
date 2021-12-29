using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 籃球場分數管理
/// 三分區域偵測
/// </summary>
public class ballSorce : MonoBehaviour
{
    [Header("進球區域")]
    public Vector3 positionBaller;
    public Color colorBallIn = new Color(1, 0.2f, 0.3f, 0.3f);
    [Range(0, 10)]
    public float rangeBallIn = 3;

    [Header("三分區域")]
    public Vector3 postionThirdPoint;
    public Color colorThirdPoiint = new Color(0.2f, 0.2f, 1, 0.3f);
    public Vector3 sizeThirdPoint = new Vector3(5, 3, 10);

    [Header("進球分數")]
    public int score = 2;
    public int scoreAdd;
    public Text scoreText;
    //繪製進球範圍
    private void OnDrawGizmos()
    {
        //進球區域
        Gizmos.color = colorBallIn;
        Gizmos.DrawWireSphere(positionBaller, rangeBallIn);
        //三分區域
        Gizmos.color = colorThirdPoiint;
        Gizmos.DrawCube(postionThirdPoint, sizeThirdPoint);
    }

    //偵測球是否進入得分範圍
    private void CheckBall()
    {
        Collider[] hits = Physics.OverlapSphere(positionBaller, rangeBallIn, 1 << 3);
        if (hits.Length > 0)
        {
            scoreAdd += score;
            scoreText.text = "分數:" + score;
            //進球完塗層歸零，就不會重複加分
            hits[0].gameObject.layer = 0;
        }
    }
}
