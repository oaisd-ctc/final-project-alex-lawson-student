using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Level : MonoBehaviour
{
    public Animator anim;
    public float LvlTime = 25;
    public float MaxSpeed = 5;
    public float mag = 5;
    float LvlTimeP;
    
    public TextMeshProUGUI TextT;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        print(anim.speed);
        TextT.text = (LvlTime-LvlTimeP).ToString("F2");


        if (LvlTimeP < LvlTime)
        {
            LvlTimeP += Time.deltaTime;

            anim.speed = (MaxSpeed * math.pow(LvlTimeP, mag)) / math.pow(LvlTime, mag) + 0.2f;
        }
    }
}
