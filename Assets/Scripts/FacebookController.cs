using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Facebook.Unity;

public class FacebookController : MonoBehaviour
{
/*    [SerializeField] Button fbLogin;
    [SerializeField] Button fbLogout;

    private void Awake()
    {
        if (!FB.IsInitialized)
        {
            FB.Init(InitCallback, OnHideUnity);
        }
        else
        {
            FB.ActivateApp();
        }
        fbLogin.onClick.AddListener(FacebookLogin);
        fbLogout.gameObject.SetActive(false);
        fbLogout.onClick.AddListener(FacebookLogout);
    }

    private void InitCallback()
    {
        if (FB.IsInitialized)
        {
            FB.ActivateApp();
            //...
        }
        else
        {
            Debug.Log("FB couldnt initialize");
        }
    }
    private void OnHideUnity(bool isGameShown)
    {
        if (!isGameShown)
        {
            // Pause the game - we will need to hide
            Time.timeScale = 0;
        }
        else
        {
            // Resume the game - we're getting focus again
            Time.timeScale = 1;
        }
    }

    public void FacebookLogin()
    {
        var permission = new List<string>() { "public_profile", "email" };
        FB.LogInWithReadPermissions(permission, AuthCallBack);

    }

    private void AuthCallBack(ILoginResult result)
    {
        if (FB.IsLoggedIn)
        {
            var token = Facebook.Unity.AccessToken.CurrentAccessToken;
            Debug.Log(token.UserId);
            fbLogout.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("FB user cancelled login");
        }
    }

    public void FacebookLogout()
    {
        FB.LogOut();
        fbLogout.gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        fbLogin.onClick.RemoveListener(FacebookLogin);
        fbLogout.onClick.RemoveListener(FacebookLogout);
    }*/
}
