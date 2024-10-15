using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Obj_dataController : MonoBehaviour
{
    
    public enum Language
    {
        Viet, English, France
    }
    public Language language;
    public int lastHistoricalSites=10;
    private void Awake()
    {
        GameObject[] Obj_Ctrs = GameObject.FindGameObjectsWithTag("Language");
        if (Obj_Ctrs.Length >1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
