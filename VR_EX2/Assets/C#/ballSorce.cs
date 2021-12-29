using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �x�y�����ƺ޲z
/// �T���ϰ찻��
/// </summary>
public class ballSorce : MonoBehaviour
{
    [Header("�i�y�ϰ�")]
    public Vector3 positionBaller;
    public Color colorBallIn = new Color(1, 0.2f, 0.3f, 0.3f);
    [Range(0, 10)]
    public float rangeBallIn = 3;

    [Header("�T���ϰ�")]
    public Vector3 postionThirdPoint;
    public Color colorThirdPoiint = new Color(0.2f, 0.2f, 1, 0.3f);
    public Vector3 sizeThirdPoint = new Vector3(5, 3, 10);

    [Header("�i�y����")]
    public int score = 2;
    public int scoreAdd;
    public Text scoreText;
    //ø�s�i�y�d��
    private void OnDrawGizmos()
    {
        //�i�y�ϰ�
        Gizmos.color = colorBallIn;
        Gizmos.DrawWireSphere(positionBaller, rangeBallIn);
        //�T���ϰ�
        Gizmos.color = colorThirdPoiint;
        Gizmos.DrawCube(postionThirdPoint, sizeThirdPoint);
    }

    //�����y�O�_�i�J�o���d��
    private void CheckBall()
    {
        Collider[] hits = Physics.OverlapSphere(positionBaller, rangeBallIn, 1 << 3);
        if (hits.Length > 0)
        {
            scoreAdd += score;
            scoreText.text = "����:" + score;
            //�i�y����h�k�s�A�N���|���ƥ[��
            hits[0].gameObject.layer = 0;
        }
    }
}
