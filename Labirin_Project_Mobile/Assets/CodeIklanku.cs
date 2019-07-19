using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class CodeIklanku : MonoBehaviour
{
    public string appId;
    public string adUnitId;
    private InterstitialAd interstitial;
    // Start is called before the first frame update
    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
        this.RequestInterstitial();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TampilkanIklan() {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
        else {
            Debug.Log("Iklan gagal load");
        }

    }
    private void RequestInterstitial()
    {
        
        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);

    }
    
}
