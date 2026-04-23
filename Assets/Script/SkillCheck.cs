using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillCheck : MonoBehaviour
{
    [SerializeField] Interact it;
    public GameObject Bar;
    public GameObject Pin;
    public Transform Pin_T;
    public Transform Green;
    public Transform RedUp;
    public Transform RedDown;
    float direction = 1f;
    public float greenT;
    public float RedLow;
    public float RedHigh;
    public float speed = 3.5f;
    public bool talkable = true;
    public bool Check = false;
    Vector3 pos;

    void Start()
    {
        pos = Pin.transform.localPosition;
    }

    void Update()
    {
        if (it.talk == true)
        {
            Bar.SetActive(true);

            //Position & movement
            pos = Pin.transform.localPosition;
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

            Pin.transform.localPosition = pos;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Check = true;
                talkable = false;

                greenT = Vector3.Distance(Pin_T.position, Green.position);
                RedLow = Vector3.Distance(Pin_T.position, RedDown.position);
                RedHigh = Vector3.Distance(Pin_T.position, RedUp.position);

                if(RedLow > RedHigh)
                {
                    print("1");
                    if (RedLow > greenT)
                    {
                        print("2");
                    }
                }
                else if (RedLow < RedHigh)
                {
                    print("1");
                    if (RedHigh > greenT)
                    {
                        print("2");
                    }
                }
            }
        }
        else
        {
            Bar.SetActive(false);
        }
    }
}
