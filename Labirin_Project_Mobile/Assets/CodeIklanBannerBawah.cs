using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class CodeIklanBannerBawah : MonoBehaviour
{
    private BannerView bannerView;

    public string appId;
    public string adUnitId;
    // Use this for initialization
    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
        this.RequestBanner();


    }
    private void RequestBanner()
    {
        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);




        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);

    }
    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("Banner failed to load: " + args.Message);
        // Handle the ad failed to load event.
    }

    void Update()
    {

    }
}
