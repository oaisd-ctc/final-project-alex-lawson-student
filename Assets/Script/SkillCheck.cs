using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillCheck : MonoBehaviour
{
    public GameObject Bar;
    public GameObject Pin;
    [SerializeField] Interact it;
    public float speed = .1f;
    Vector3 pos;
    float direction = 1f;
    bool Check = false;
    public bool talkable = true;
    // Start is called before the first frame update
    void Start()
    {
        pos = Pin.transform.localPosition;
    }

    // Update is called once per frame
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
