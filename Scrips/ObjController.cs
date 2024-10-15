using System.Drawing;
using UnityEngine;
namespace GameDiTich
{
    public class ObjController : MonoBehaviour
    {
        public int numObj;
        public Sprite spriteActive;
        private SpriteRenderer ren;
        private MeshRenderer meshRen;
        private BoxCollider2D box;
        private ObjController script;
        private DisplayScreen2Controller displayScreen2Controller;
        private GameController gameController;
        public AudioSource _Au;
        private LightCircleController lightCircleScrip;
        public GameObject lightCircle;
        public Obj_dataController obj_DataController;
        [SerializeField] UnityEngine.Color color;
        // Start is called before the first frame update
        void Start()
        {
            lightCircleScrip = this.GetComponentInChildren<LightCircleController>();
            lightCircle = lightCircleScrip.gameObject;
            obj_DataController = FindObjectOfType<Obj_dataController>();
            displayScreen2Controller = FindAnyObjectByType<DisplayScreen2Controller>();
            gameController = FindAnyObjectByType<GameController>();
            script = GetComponent<ObjController>();
            box = GetComponent<BoxCollider2D>();
            ren = this.GetComponent<SpriteRenderer>();
            meshRen = this.GetComponentInChildren<MeshRenderer>();
            meshRen.enabled = false;
            _Au = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.transform.tag.Equals(this.transform.tag))
            {
                // take ID Historical
                obj_DataController.lastHistoricalSites = numObj;

                // change sprite of icon in map
                color = ren.color;
                color.a = 255;
                ren.sprite = spriteActive;
                ren.color = color;


                // change image of screen 2
                displayScreen2Controller.SetTexture(numObj);

                // turn off scrip
                script.enabled = false;

                // turn on text
                meshRen.enabled = true;

                // turn off boxColider
                box.enabled = false;

                //turn off lightCircle
                lightCircle.SetActive(false);

                // turn off obj icon move
                collision.gameObject.SetActive(false);

                // reset obj handler
                gameController.obj = null;

                //
                gameController.countDitich++;

                // play audio
                _Au.Play();
                Debug.Log(gameController.countDitich);
            }
        }
    }
}
