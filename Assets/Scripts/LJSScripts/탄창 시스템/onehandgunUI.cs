using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onehandgunUI : MonoBehaviour
{

    private msOneHandGun msonehandgun;

    [SerializeField]
    private GameObject GunCanvas;

    [SerializeField]
    private Text[] text_msmachinegunBullet;



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
