using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class LightCircleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Sestcale());
    }
    IEnumerator Sestcale()
    {
        float randomFloat = Random.Range(0.0f, 1.0f);
        yield return new WaitForSeconds(randomFloat);
        this.transform.DOScale(new Vector3(0.5f, 0.3f), 1f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
