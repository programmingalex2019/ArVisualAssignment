using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBehaviour : MonoBehaviour
{

    const float SPEED = 6f;
    private bool added = false;

    // Start is called before the first frame update
    [SerializeField]
    Transform SectionInfo; //that's what we scale

    Vector3 desiredScale = Vector3.zero; //default info

    // Update is called once per frame
    void Update()
    {
        SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale, desiredScale, Time.deltaTime * SPEED);
    }

    public void OpenInfo()
    {

        desiredScale = Vector3.one;

        if (added == false)
        {
            ScoreManager.instance.AddPoint();
            if (!gameObject.GetComponent<AudioSource>().isPlaying)
            {
                gameObject.GetComponent<AudioSource>().Play();
            }
            added = true;
        }

    }

    public void CloseInfo()
    {
        desiredScale = Vector3.zero;
        added = false;
    }

}
