using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameDiTich
{
    public class UIController : MonoBehaviour
    {
        private bool reload = false;
        public GameObject panelGame;
        [SerializeField] Button btnTrove, btnStart;

        private void Start()
        {
            btnTrove.onClick.AddListener(MoHome);
            btnStart.onClick.AddListener(StartPlayditich);
        }

        void MoHome()
        {
            SceneManager.LoadScene(0);
        }
        void StartPlayditich()
        {
            panelGame.SetActive(false);
        }

        public void ButtonBackMenu()
        {
            Debug.Log("ButtonBackMenu");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        public void ButtonBackStart()
        {
            if (reload)
            {
                Debug.Log(reload);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                panelGame.SetActive(false);
                reload = true;
            }
            else
            {
                panelGame.SetActive(false);
                reload = true;
            }
        }
        public void ButtonNextToSceneDiTich()
        {
            SceneManager.LoadScene(1);
        }

    }
}