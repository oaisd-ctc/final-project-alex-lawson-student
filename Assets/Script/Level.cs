using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    [SerializeField] SkillCheck scs;
    public MonoBehaviour it, em, sc, pr;
    public GameObject LE, pl;
    public TextMeshProUGUI WT, Cmax, HP;
    public Animator animWT;
    public Animator animE;
    public float LvlTime = 25, MaxSpeed = 10, mag = 5, HpT = 0f;
    public bool end = false;
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

            animWT.speed = (MaxSpeed * math.pow(LvlTimeP, mag)) / math.pow(LvlTime, mag) + 0.2f;
            LE.SetActive(false);
        }
        else
        {
            LE.SetActive(true);
            animE.SetBool("EU", false);
            animE.SetBool("ED", true);


            if (animE.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f && end == false)
            {
                animE.SetBool("ED", false);
                end = true;
                animWT.speed = 0;
                LvlTimeP = 0;
                LvlTime = 0;
            }
            {
                pl.SetActive(false);
                HP.text = scs.HP.ToString("") + " / " + HpT;

                float[] myArray = { scs.HCg, scs.HCy, scs.HCo, scs.HCr };

                switch (System.Array.IndexOf(myArray, Mathf.Max(myArray)))
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
            if(Input.GetKeyDown(KeyCode.Space))
            {
                animE.SetBool("ED", false);
                animE.SetBool("EU", true);
                Cmax.text = "";
                HP.text = "";
                if (animE.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f)
                {
                    LE.SetActive(false);
                }
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                animE.SetBool("ED", false);
                animE.SetBool("EU", true);
                Cmax.text = "";
                HP.text = "";
                if (animE.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f)
                {
                    LE.SetActive(false);
                }
            }

        }
    }
}
