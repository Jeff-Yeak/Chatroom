using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class RewardAd : MonoBehaviour
{
    private RewardedAd rewardedAd;

    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
    }

    public void CreateAndLoadRewardedAd()
    {
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
        string adUnitId = "unexpected_platform";
#endif

        this.rewardedAd = new RewardedAd(adUnitId);

        this.rewardedAd.OnAdLoaded += RewardedAd_OnAdLoaded;
        this.rewardedAd.OnUserEarnedReward += RewardedAd_OnUserEarnedReward;
        this.rewardedAd.OnAdClosed += RewardedAd_OnAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);

    }

    private void RewardedAd_OnAdClosed(object sender, EventArgs e)
    {
        //user close ads
    }

    private void RewardedAd_OnUserEarnedReward(object sender, Reward e)
    {
        //reward user
    }

    private void RewardedAd_OnAdLoaded(object sender, EventArgs e)
    {
        rewardedAd.Show();
    }
}
