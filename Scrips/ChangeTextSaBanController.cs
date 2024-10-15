using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeTextSaBanController : MonoBehaviour
{
    public TextMeshProUGUI[] text;
    public string[] inputTextEnglish;
    public string[] inputTextFrance;
    public Obj_dataController obj_DataController;
    // Start is called before the first frame update
    public void Start()
    {
        obj_DataController = GameObject.FindAnyObjectByType<Obj_dataController>().GetComponent<Obj_dataController>();
        switch (obj_DataController.language)
        {
            case Obj_dataController.Language.Viet:
                return;
            case Obj_dataController.Language.English:
                ChangeLanguageEnglish();
                break;
            case Obj_dataController.Language.France:
                break;
        }
    }
    public void ChangeLanguageEnglish()
    {
        for (int x = 0; x < inputTextEnglish.Length; x++)
        {
            text[x].text = inputTextEnglish[x];
        }
    }

}
