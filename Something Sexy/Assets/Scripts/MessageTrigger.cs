using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (gameObject.activeInHierarchy)
        {   
            RunMessage();
        }
    }

    public void RunMessage()
    {        
        PanelMessageBox panelBox = GetComponent<PanelMessageBox>();
        panelBox.DisplayMessage("I am working!");
    }
}
