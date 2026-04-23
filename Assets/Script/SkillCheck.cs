using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillCheck : MonoBehaviour
{
    [SerializeField] Interact it;
    public GameObject Bar;
    public GameObject Pin;
    float direction = 1f;
    public float speed = .1f;
    public bool talkable = true;
    bool Check = false;
    Vector3 pos;

    void Start()
    {
        pos = Pin.transform.localPosition;
    }

    void Update()
    {
        if (it.talk)
        {
            Bar.SetActive(true);
        }
        else
        {
            Bar.SetActive(false);
        }


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
        }
    }
}
