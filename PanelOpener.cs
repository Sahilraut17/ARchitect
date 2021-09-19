using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;

    public void Openpanel()
    {
        if(Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
