using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class machinegunUI : MonoBehaviour
{

    private msMachineGun msmachinegun;

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
