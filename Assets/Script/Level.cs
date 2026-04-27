using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Level : MonoBehaviour
{
    public GameObject LE;
    [SerializeField] SkillCheck sc;
    public TextMeshProUGUI WT, Cmax, HP;
    public Animator anim;
    public float LvlTime = 25, MaxSpeed = 10, mag = 5, HpT = 0f;
    float LvlTimeP;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WT.text = (LvlTime-LvlTimeP).ToString("F2");


        if (LvlTimeP <= LvlTime && LvlTime != 0)
        {
            LvlTimeP += Time.deltaTime;

            anim.speed = (MaxSpeed * math.pow(LvlTimeP, mag)) / math.pow(LvlTime, mag) + 0.2f;
            LE.SetActive(false);
        }
        else
        {
            LvlTimeP = 0;
            LvlTime = 0;
            LE.SetActive(true);

            HP.text = sc.HP.ToString("") + " / " + HpT;

            float[] myArray = {sc.HCg, sc.HCy, sc.HCo, sc.HCr};

            switch(System.Array.IndexOf(myArray, Mathf.Max(myArray)))
                {
                case 0:
                    Cmax.text = "Green";
                    break;
                case 1:
                    Cmax.text = "Yellow";
                    break;
                case 2:
                    Cmax.text = "Orange";
                    break;
                case 3:
                    Cmax.text = "Red";
                    break;
            }
        }
    }
}
