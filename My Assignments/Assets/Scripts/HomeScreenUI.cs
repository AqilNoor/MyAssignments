using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreenUI : MonoBehaviour
{
    public Text scoreText, coinText, lifeText;
    float score = 0, coin = 0, life = 1;
    [SerializeField]
    private GameObject moreButtonPanel;

    void Awake()
    {
        moreButtonPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ScoreManage()
    {
        scoreText.text = score.ToString();
    }

    void CoinManage()
    {
        coinText.text = coin.ToString();
    }

    void LifeManage()
    {
        lifeText.text = life.ToString();
    }

    public void MoreButtonClicked()
    {
        moreButtonPanel.SetActive(true);
    }
}
