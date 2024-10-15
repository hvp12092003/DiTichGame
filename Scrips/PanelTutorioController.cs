using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using DGSequence = DG.Tweening.Sequence;
namespace GameDiTich
{

    public class PanelTutorioController : MonoBehaviour
    {
        public GameObject iconPos;
        public GameObject iconMove;
        public Texture iconPosOff, iconPosOn;
        public GameObject textPos;
        public RawImage raw;
        public Vector3 posOrigin;
        DGSequence sequence;

        private void OnEnable()
        {
            sequence = DOTween.Sequence();
            sequence.AppendCallback(() =>
            {
                DoneAction();
            });
            sequence.AppendInterval(3.0f);
            sequence.AppendCallback(() =>
            {
                ResetAction();
            });
            sequence.AppendInterval(1.0f);
            sequence.SetLoops(-1, LoopType.Restart);
        }
        private void DoneAction()
        {
            iconMove.transform.DOMoveX(0.3f, 2).SetEase(Ease.Linear).OnComplete(() =>
            //iconMove.transform.DOMoveX(-0.3f, 1f).SetEase(Ease.Linear).OnComplete(() =>
            {
                raw.texture = iconPosOn;
                textPos.SetActive(true);
                iconMove.SetActive(false);
            });

        }
        private void ResetAction()
        {
            raw.texture = iconPosOff;
            iconMove.transform.position = new Vector3(2.75f, -1f, 0f);
            iconMove.SetActive(true);
            textPos.SetActive(false);
        }
        public void EndAction()
        {
            ResetAction();
            sequence.Kill();
        }
    }
}