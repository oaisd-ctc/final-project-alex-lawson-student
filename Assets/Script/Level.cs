using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Level : MonoBehaviour
{

    [SerializeField] SkillCheck scs;
    public MonoBehaviour it, em, sc, pr;
    public GameObject LE, pl;
    public TextMeshProUGUI WT, Cmax, HP, HPN, CmaxN, info;
    public Animator animWT;
    public Animator animE;
    public float LvlTime = 25, MaxSpeed = 10, mag = 5, HpT = 0, Totorlvl = 0;
    public bool end = false;
    float LvlTimeP;

    private void Start()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        

        if (currentIndex > 1)
        {
            Totorlvl = 5;
        }
        else
        {
            Totorlvl = 0;
        }

        HPN.text = "";
        CmaxN.text = "";
        HP.text = "";
        Cmax.text = "";
        info.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;

        WT.text = (LvlTime-LvlTimeP).ToString("F2");

        if (Input.GetKeyDown(KeyCode.Escape) && end == false)
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(currentIndex);
        }
        if (Totorlvl == 5)
        {
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

                    pl.SetActive(false);
                    HPN.text = "[score]\r\n\r\n[People Talked]";
                    CmaxN.text = "[Best color]";
                    info.text = "[R for reload Level]\r\n\r\n[Space for next Level]\r\n\r\n[Esc to main menu]";
                    HP.text = scs.HP.ToString("") + " / " + HpT;

                    float[] myArray = { scs.HCg, scs.HCy, scs.HCo, scs.HCr };

                    switch (System.Array.IndexOf(myArray, Mathf.Max(myArray)))
                    {
                        case 0:
                            Cmax.text = "Green";
                            Cmax.color = Color.green;
                            break;
                        case 1:
                            Cmax.text = "Yellow";
                            Cmax.color = Color.yellow;
                            break;
                        case 2:
                            Cmax.text = "Orange";
                            Cmax.color = new Color(1f, 0.5f, 0f);
                            break;
                        case 3:
                            Cmax.text = "Red";
                            Cmax.color = Color.red;
                            break;
                    }
                }
                if (Input.GetKeyDown(KeyCode.Space) && end == true)
                {
                    animE.SetBool("ED", false);
                    animE.SetBool("EU", true);
                    Cmax.text = "";
                    HP.text = "";

                    if (animE.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f)
                    {
                        if(currentIndex == 1)
                        {
                            SceneManager.LoadScene(0);
                        }
                        else
                        {
                            int sceneCount = SceneManager.sceneCountInBuildSettings;
                            int randomIndex;
                            do
                            {
                                randomIndex = Random.Range(2, sceneCount);
                            }
                            while (randomIndex == currentIndex);

                            SceneManager.LoadScene(randomIndex);

                        }

                        LE.SetActive(false);
                    }
                }
                if (Input.GetKeyDown(KeyCode.Escape) && end == true)
                {
                    animE.SetBool("ED", false);
                    animE.SetBool("EU", true);
                    Cmax.text = "";
                    HP.text = "";
                    if (animE.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f)
                    {
                        SceneManager.LoadScene(1);
                        LE.SetActive(false);
                    }
                }
            }
        }
    }
}
