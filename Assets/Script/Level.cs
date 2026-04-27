using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Level : MonoBehaviour
{
    public GameObject LE;
    public TextMeshProUGUI TextT;
    public Animator anim;
    public float LvlTime = 25;
    public float MaxSpeed = 10;
    public float mag = 5;
    float OLtime;
    float LvlTimeP;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TextT.text = (LvlTime-LvlTimeP).ToString("F2");


        if (LvlTimeP <= LvlTime && LvlTime != 0)
        {
            LvlTimeP += Time.deltaTime;

            OLtime = (MaxSpeed * math.pow(LvlTimeP, mag)) / math.pow(LvlTime, mag) + 0.2f;
            anim.speed = (MaxSpeed * math.pow(LvlTimeP, mag)) / math.pow(LvlTime, mag) + 0.2f;
            LE.SetActive(false);
        }
        else
        {
            LvlTimeP = 0;
            LvlTime = 0;
            LE.SetActive(true);
        }
    }
}
