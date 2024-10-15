using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeTextController : MonoBehaviour
{
    public TextMeshProUGUI textButtonBack, textIconMovePanel, textIconPosPanel;
    public string[] _textButtonBack, _textIconMove, _textIconPos;

    public TextMeshPro[] textIconsMove, textIconsPos;
    public string[] _textIconsPosEnglish;
    public Obj_dataController obj_DataController;
    // Start is called before the first frame update
    void Start()
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
    private void ChangeLanguageEnglish()
    {
        for (int x = 0; x < textIconsMove.Length; x++)
        {
            textIconsPos[x].text = textIconsMove[x].text = _textIconsPosEnglish[x];
        }
        textButtonBack.text = _textButtonBack[1];
        textIconMovePanel.text = _textIconMove[1];
        textIconPosPanel.text = _textIconPos[1];
    }
}
