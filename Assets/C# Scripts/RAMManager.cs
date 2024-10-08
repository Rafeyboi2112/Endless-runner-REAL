using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RAMManager : MonoBehaviour
{
    public int coinCount;
    public Text coinText;

    // Update is called once per frame
    void Update()
    {
        coinText.text = coinCount.ToString();
    }
}
