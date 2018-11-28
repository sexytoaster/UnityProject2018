using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopScene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Button shop = gameObject.GetComponent<Button>();
        shop.onClick.AddListener(delegate () { ChangeShop("ShopMenu"); });
    }

    // Update is called once per frame
    public void ChangeShop(string level)
    {
        SceneManager.LoadScene("ShopMenu");
    }
}