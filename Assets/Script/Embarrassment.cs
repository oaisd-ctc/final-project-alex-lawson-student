using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Embarrassment : MonoBehaviour
{
    [SerializeField] Player pr;
    [SerializeField] SkillCheck sc;
    public int EmLevel = 0;

    private void Update()
    {
        if(EmLevel == 0)
        {
            pr.moveSpeed = 5f;
            sc.speed = 4f;
        }
        else if (EmLevel == 1)
        {
            pr.moveSpeed = 3f;
            sc.speed = 5.5f;
        }
        else if (EmLevel == 2)
        {
            pr.moveSpeed = 2f;
            sc.speed = 6f;
        }
        else if (EmLevel == 3)
        {
            pr.moveSpeed = 1f;
            sc.speed = 7f;
        }
    }
}
