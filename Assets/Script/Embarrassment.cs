using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Embarrassment : MonoBehaviour
{
    [SerializeField] Player pr;
    [SerializeField] SkillCheck sc;
    public SpriteRenderer UIEm;
    public Sprite Em0, Em1, Em2, Em3;
    public int EmLevel = 0;

    private void Update()
    {
        if(EmLevel == 0)
        {
            pr.moveSpeed = 5f;
            sc.speed = 4f;
            UIEm.sprite = Em0;
        }
        else if (EmLevel == 1)
        {
            pr.moveSpeed = 3f;
            sc.speed = 5.5f;
            UIEm.sprite = Em1;
        }
        else if (EmLevel == 2)
        {
            pr.moveSpeed = 2f;
            sc.speed = 6f;
            UIEm.sprite = Em2;
        }
        else if (EmLevel == 3)
        {
            pr.moveSpeed = 1f;
            sc.speed = 7f;
            UIEm.sprite = Em3;
        }
    }
}
