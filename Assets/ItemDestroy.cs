using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    //�J�����̃I�u�W�F�N�g
    private GameObject MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        //MainCamera�̃I�u�W�F�N�g���擾
        this.MainCamera = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update()
    {
        if (MainCamera.transform.position.z + 10 > this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
