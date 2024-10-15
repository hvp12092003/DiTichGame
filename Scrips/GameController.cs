using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

namespace GameDiTich
{
    public class GameController : MonoBehaviour
    {
        public GameObject panelGame, imagePanel2;
        private bool houldMouse;
        private float countTime;
        private float SetcountTime = 360;
        public Transform obj;
        private Color rayColor = Color.red;
        public float countDitich = 0;
        private Vector3 originPos = Vector3.zero;
        [SerializeField] ChangePanelController _changePanel = null;

        [SerializeField] VideoPlayer video4 = null;
        [SerializeField] int TimeViewpanel = 5;

        void Start()
        {
            //obj_DataController = FindObjectOfType<Obj_dataController>();
            countTime = SetcountTime;
            countDitich = 0;
        }

        void Update()
        {
            if (!panelGame.activeSelf)
            {
                countTime -= Time.deltaTime;
            }
            if (Input.GetMouseButtonUp(0))
            {
                countTime = SetcountTime;
            }
            if (countDitich ==11)
            {
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                StartCoroutine(Countdown());
                
            }
            CountTimeForBack();
        }

        public void CountTimeForBack()
        {
            if (countTime <= 0) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        IEnumerator Countdown()
        {
            //Debug.Log("D");
            yield return new WaitForSeconds(TimeViewpanel);
            imagePanel2.SetActive(false);
            video4.Play();
            //yield return new WaitForSeconds(5);
            yield return new WaitForSeconds((float) video4.length);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            _changePanel.ChanPanel();

        }



    }

}
