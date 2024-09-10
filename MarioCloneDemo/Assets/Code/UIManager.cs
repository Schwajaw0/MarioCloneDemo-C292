using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    
    [SerializeField] private TextMeshProUGUI cointext;
    private int coincount;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(instance);
        }
    }

    public void UpdateCointext(int coinValue)
    {
        coincount += coinValue;
        cointext.text = "x" + coincount;
    }


}
