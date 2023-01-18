using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrefillTxtInput : MonoBehaviour
{
    //public TMP_InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        TMP_InputField tMP_Input = GetComponent<TMP_InputField>();
        tMP_Input.text = "http://192.168.1.105:8080";

        //inputField.text = "http://192.168.1.105:8080";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
