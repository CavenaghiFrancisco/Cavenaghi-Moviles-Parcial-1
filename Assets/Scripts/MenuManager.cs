using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public List<CinemachineVirtualCamera> vcams;
    public List<GameObject> panels;

    private void Start()
    {
        
    }

    private IEnumerator ActivatePanel(CinemachineVirtualCamera camera)
    {
        float time = 0;
        while (time < 1)
        {
            time += Time.deltaTime;
            yield return null;
        }
        for(int i = 0; i < vcams.Count; i++)
        {
            if(vcams[i] == camera)
            {
                panels[i].SetActive(true);
            }
        }
        yield return null;
    }

    public void ActivateCamera(CinemachineVirtualCamera camera)
    {
        foreach(CinemachineVirtualCamera vcam in vcams)
        {
            vcam.gameObject.SetActive(false);
        }
        foreach(GameObject panel in panels)
        {
            panel.SetActive(false);
        }
        camera.gameObject.SetActive(true);
        StartCoroutine(ActivatePanel(camera));
    }
}
