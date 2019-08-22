using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pocion : MonoBehaviour
{
    [SerializeField]
    Text message;
    private void OnTriggerStay(Collider other)
    {
        message.text = "pocion magica";
    }
    private void OnTriggerExit(Collider other)
    {
        message.text = "";
    }
}
