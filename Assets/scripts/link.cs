using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class link : MonoBehaviour
{
    [SerializeField]
    Text message;
    private void OnTriggerStay(Collider other)
    {
        message.text = "Este es Link peleando";
    }
    private void OnTriggerExit(Collider other)
    {
        message.text = "";
    }
}