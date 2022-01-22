using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gaze : MonoBehaviour
{

    List<InfoBehaviour> infos = new List<InfoBehaviour>();
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        infos = FindObjectsOfType<InfoBehaviour>().ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("hasInfo"))
            {
                OpenInfo(go.GetComponent<InfoBehaviour>());
            }
            else
            {
                CloseAll();
            }
        }
    }

    void OpenInfo(InfoBehaviour desiredInfo)
    {
        foreach(InfoBehaviour info in infos)
        {
            if(info == desiredInfo)
            {
                info.OpenInfo();
            }
            else
            {
                info.CloseInfo();
            }
        }
    }

    void CloseAll()
    {
        foreach (InfoBehaviour info in infos)
        {
            info.CloseInfo();
        }
    }
}
