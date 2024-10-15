using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ChangePanelController : MonoBehaviour
{
    public Image panelCanvas1;
    public Image panelCanvas2;
    public Sprite[] sprites;
    public Obj_dataController obj_DataController;
    // Start is called before the first frame update
    void Start()
    {
        obj_DataController = FindObjectOfType<Obj_dataController>();
        ChanPanel();
    }
    void ChangePanelEngLish()
    {
        panelCanvas1.sprite = sprites[1];
        panelCanvas2.sprite = sprites[1];
    }
    void ChangePanelViet()
    {
        panelCanvas1.sprite = sprites[0];
        panelCanvas2.sprite = sprites[0];
    }

    public void ChanPanel()
    {
        switch (obj_DataController.language)
        {
            case Obj_dataController.Language.Viet:
                ChangePanelViet();
                break;
            case Obj_dataController.Language.English:
                ChangePanelEngLish();
                break;
            case Obj_dataController.Language.France:
                break;
        }
    }
   
}
