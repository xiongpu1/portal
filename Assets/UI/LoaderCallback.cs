using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;


public class LoaderCallback : MonoBehaviour
{
    private bool isFirstUpdate = true;

    private void Update()
    {
        if (isFirstUpdate)
        {
            isFirstUpdate = false;
            // �ӳ�2�����Loader.LoaderCallback����
            Invoke("LoadTargetScene", 2f);
        }
    }

    private void LoadTargetScene()
    {
        Loader.LoaderCallback();
    }
}