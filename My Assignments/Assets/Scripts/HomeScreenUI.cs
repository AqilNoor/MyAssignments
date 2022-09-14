using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreenUI : MonoBehaviour
{
    public Text scoreText, coinText, lifeText;
    int score = 0, coin = 0, life = 1;
    [SerializeField]
    private GameObject moreButtonPanel;
    private Animator animator;
    [SerializeField]
    private GameObject homeScreen;
    [SerializeField]
    private GameObject playModeScreen;
    private bool isHomeScreenActive;

    void Awake()
    {
        isHomeScreenActive = true;
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        UpdateTextValue(scoreText, score, 1);
        UpdateTextValue(coinText, coin, 1);
        UpdateTextValue(scoreText, score, 1);
    }

    public void PlayButtonOnHomeScreen()
    {
        if (isHomeScreenActive)
        {
            playModeScreen.SetActive(true);
        }
        isHomeScreenActive = false;
        homeScreen.SetActive(false);
    }
    public void BackToHomeScreen()
    {
        if (!isHomeScreenActive)
        {
            homeScreen.SetActive(true);
        }
        playModeScreen.SetActive(false);
        isHomeScreenActive = true;
    }

    public void UpdateTextValue(Text text, int value, int increment)
    {
        value += increment;
        text.text = value.ToString();
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

    public void OpenFacebook()
    {
        // open facebook
        Application.OpenURL("https://www.facebook.com/campaign/landing.php?campaign_id=1653377901&extra_1=s%7Cc%7C318307045135%7Ce%7Cfacebook%27%7C&placement=&creative=318307045135&keyword=facebook%27&partner_id=googlesem&extra_2=campaignid%3D1653377901%26adgroupid%3D65139789042%26matchtype%3De%26network%3Dg%26source%3Dnotmobile%26search_or_content%3Ds%26device%3Dc%26devicemodel%3D%26adposition%3D%26target%3D%26targetid%3Dkwd-362360550869%26loc_physical_ms%3D1011082%26loc_interest_ms%3D%26feeditemid%3D%26param1%3D%26param2%3D&gclid=CjwKCAjw1ICZBhAzEiwAFfvFhAyZHkZJq1Rlo7Kmm361LLzav4RgELzm5h81FnDthWAFd0AySc7-lxoC3BQQAvD_BwE");

    }
    public void OpenRateUsPage()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.zgs.zealgames.uphill.tuktuk.driving.auto.rikshaw");
    }

    public void FindMoreGames()
    {
        Application.OpenURL("https://play.google.com/store/apps/developer?id=Zeal+Games+Studio");
    }

    bool hasMoreButtonPanelEntered = false;
    public void MoreButtonClicked()
    {
        if (!hasMoreButtonPanelEntered)
        {
            moreButtonPanel.GetComponent<Animator>().CrossFade("MoreButtonEnteringAnimation", 0.5f);
        }
        else
        {
            moreButtonPanel.GetComponent<Animator>().CrossFade("MoreButtonExitingAnimation", 0.1f);
        }

        hasMoreButtonPanelEntered = !hasMoreButtonPanelEntered;
    }
}
