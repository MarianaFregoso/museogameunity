using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class chunli : MonoBehaviour
{
    [SerializeField]
    Text message;
    private void OnTriggerStay(Collider other)
    {
        message.text = "personaje chunli";
    }
    private void OnTriggerExit(Collider other)
    {
        message.text = "";
    }
}
