using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemCollection : MonoBehaviour
{
    public int gemTotal = 0;

    public TextMeshProUGUI gemCounter;

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
    }
}
