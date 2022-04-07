using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public static class IAPProduct
{
    public const string coin1 = "com.kkingStudio.UnityDemo.1coin";
    public const string removeAds = "com.kkingStudio.UnityDemo.removeAds";
}



public class IAP : MonoBehaviour
{
    [SerializeField] IAPButton coin1Button;
    [SerializeField] IAPButton removeAdsButton;

    private void Awake()
    {
        coin1Button.onPurchaseComplete.AddListener(product => OnPurchaseComplete(product));
        coin1Button.onPurchaseFailed.AddListener((product, reason) => OnPurchaseFailed(product, reason));
        removeAdsButton.onPurchaseComplete.AddListener(product => OnPurchaseComplete(product));
        removeAdsButton.onPurchaseFailed.AddListener((product, reason) => OnPurchaseFailed(product, reason));
    }

    public void OnPurchaseComplete(Product product)
    {
        switch (product.definition.id)
        {
            case (IAPProduct.coin1):
                Debug.Log("give 1 coin");
                break;
            case (IAPProduct.removeAds):
                Debug.Log("Remove ads");
                break;
        }
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
    {
        Debug.Log(product.definition.id + " failed because " + reason);
    }


    private void OnDestroy()
    {
        coin1Button.onPurchaseComplete.RemoveListener(OnPurchaseComplete);
        coin1Button.onPurchaseFailed.RemoveListener(OnPurchaseFailed);
        removeAdsButton.onPurchaseComplete.RemoveListener(OnPurchaseComplete);
        removeAdsButton.onPurchaseFailed.RemoveListener(OnPurchaseFailed);
    }
}
