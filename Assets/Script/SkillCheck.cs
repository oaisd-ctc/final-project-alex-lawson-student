using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class SkillCheck : MonoBehaviour
{
    [SerializeField] Interact it;
    [SerializeField] Embarrassment em;
    public GameObject Bar, Pin;
    public Transform Pin_T, Green;
    public const float bar1 = 0.1f, bar2 = 0.42f, bar3 = 0.82f;
    float direction = 1f;
    public float greenT;
    public float speed = 0f, HP = 0f, HCg = 0f, HCy = 0f, HCo = 0f, HCr = 0f;
    public bool Check = false, talkable = true, talking = true;
    Vector3 pos;

    void Start()
    {
        pos = Pin.transform.localPosition;
    }

    void Update()
    {
        SpriteRenderer sr = Pin.GetComponent<SpriteRenderer>();
        if (it.talk == true && talking == false)
        {
            Bar.SetActive(true);
            Pin.transform.localPosition = pos;
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                talking = true;
                HP++;
                float greenT = math.abs(pos.x);
                Check = true;
                talkable = false;

                if (greenT <= bar1)
                {
                    em.EmLevel = 0;
                    HCg++;
                }
                else if(greenT <= bar2)
                {
                    em.EmLevel = 1;
                    HCy++;
                    
                }
                else if(greenT <= bar3)
                {
                    em.EmLevel = 2;
                    HCo++;
                }
                else
                {
                    em.EmLevel = 3;
                    HCr++;

                }
                print(HP + "pep");
                print(HCg + "Green");
                print(HCy + "Yellow");
                print(HCo + "Orange");
                print(HCr + "Red");

            }

            //Position & movement
            if (Check == false)
            {
                pos.x += direction * speed * Time.deltaTime;
            }
            if (pos.x >= 1.2f)
            {
                pos.x = 1.2f;
                direction = -1f;
            }
            else if (pos.x <= -1.2f)
            {
                pos.x = -1.2f;
                direction = 1f;
            }
        }
        else
        {
            Bar.SetActive(false);
        }
    }
}
