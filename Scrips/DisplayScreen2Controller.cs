using System.Collections;
using UnityEngine;
using UnityEngine.UI;


namespace GameDiTich
{
    public class DisplayScreen2Controller : MonoBehaviour
    {
        public Image imagePanel2;
        public Sprite[] spritesViet;
        public Sprite[] spritesEnglish;
        public Sprite[] spritesFrance;
        Obj_dataController obj_DataController;

        
        // Start is called before the first frame update
        void Start()
        {
            obj_DataController = FindObjectOfType<Obj_dataController>();
            
            SetSprite();
            imagePanel2.gameObject.SetActive(true);
        }
        public void SetTexture(int num)
        {
            imagePanel2.sprite = spritesViet[num - 1];
            switch (obj_DataController.language)
            {
                case Obj_dataController.Language.Viet:
                    imagePanel2.sprite = spritesViet[num - 1];
                    break;
                case Obj_dataController.Language.English:
                    imagePanel2.sprite = spritesEnglish[num - 1];
                    break;
                case Obj_dataController.Language.France:
                    break;
            }
        }

        public void SetSprite()
        {
            if (obj_DataController.lastHistoricalSites<=8)
            {
                SetTexture(obj_DataController.lastHistoricalSites);
            }

        }

    }
}