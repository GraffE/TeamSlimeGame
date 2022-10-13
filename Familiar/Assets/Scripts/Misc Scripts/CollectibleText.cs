using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectibleText : MonoBehaviour
{
    private Text collectibles;
    public static int numCollectibles;

    // Start is called before the first frame update
    void Start()
    {
        collectibles = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        collectibles.text = " " + numCollectibles;
    }
}
