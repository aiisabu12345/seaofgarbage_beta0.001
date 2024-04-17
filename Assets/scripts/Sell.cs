using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;
using TMPro;
using System.Collections;


public class Sell : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    public int count = 0;
    public int score = 0;
    int tem;

    void Awake()
    {
        scoreText.text = "Score : " + Score.scoreInt.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        // ��Ǩ�ͺ����ѵ�ط�誹������� Layer ����ͧ����������
        if (other.gameObject.layer == LayerMask.NameToLayer("mini"))
        {
            score += 10;
            tem = score + Score.scoreInt;
            scoreText.text = "Score : " + tem.ToString();
            Destroy(other.gameObject);
            count++;
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("medium"))
        {
            score += 10;
            tem = score + Score.scoreInt;
            scoreText.text = "Score : " + tem.ToString();
            Destroy(other.gameObject);
            count++;
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("big"))
        {
            score += 10;
            tem = score + Score.scoreInt;
            scoreText.text = "Score : " + tem.ToString();
            Destroy(other.gameObject);
            count++;
        }
    }
}
