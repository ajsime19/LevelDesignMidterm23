using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemCollection : MonoBehaviour
{
    public int gemTotal = 0;
    public int dragonTotal = 0;
    public int keyTotal = 0;

    public TextMeshProUGUI gemCounter;
    public TextMeshProUGUI dragonCounter;
    public TextMeshProUGUI keyCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Gem")
        {
            gemTotal = gemTotal + other.gameObject.GetComponent<Gem>().gemValue;
            gemCounter.text = gemTotal.ToString() + "/100";
            Debug.Log(gemTotal);

            Destroy(other.gameObject);
        }


        if(other.tag == "Dragon")
        {
            dragonTotal = dragonTotal + 1;
            dragonCounter.text = dragonTotal.ToString() + "/6";
            Debug.Log(dragonTotal);

            Destroy(other.gameObject);
        }

        if(other.tag == "Key")
        {
            keyTotal = keyTotal + 1;
            keyCounter.text = dragonTotal.ToString() + "/2";

            Destroy(other.gameObject);
        }
    }
}
