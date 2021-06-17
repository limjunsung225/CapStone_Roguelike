using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cannonUI : MonoBehaviour
{

    private msCannon mscannon;

    [SerializeField]
    private GameObject GunCanvas;

    [SerializeField]
    private Text[] text_cannonBullet;



    void Start()
    {

    }

    void Update()
    {
        CheckBullet();
    }

    private void CheckBullet()
    {

    }
}
