using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] Level level;
    [SerializeField] Player pr;
    [SerializeField] Interact it;
    public TextMeshProUGUI Tutortext;
    public GameObject tmG, emG, tmT;
    private float timetalk = 0;
    public bool goT = true, gow = true, tfyl = true;
    public float targetTime = 0;
    public float targettTime = 5;
    


    private void Start()
    {
        tmG.SetActive(false);
        emG.SetActive(false);
        tmT.SetActive(false);
    }
    private void Update()
    {
        
        

        if (level.end == false)
        {
            if (level.Totorlvl == 0f)
            {
                Tutortext.text = "Welcome to Yappa and We need to Yap. B)";
                targetTime += targettTime;
                level.Totorlvl = 1.5f;
            }

            if (level.Totorlvl == 1.5f && timetalk >= targetTime)
            {
                Tutortext.text = "But first, we need to move. 0_0";
                targetTime += targettTime;
                level.Totorlvl = 2f;
            }

            else if (level.Totorlvl == 2f && timetalk >= targetTime)
            {
                Tutortext.text = "Use WASD to move.";
                targetTime += targettTime;

                gow = pr.moved;
                gow = false;
                level.Totorlvl = 2.5f;
            }
            else if(gow == false)
            {
                gow = pr.moved;
            }

            else if (level.Totorlvl == 2.5f && timetalk >= targetTime && gow == true)
            {
                Tutortext.text = "Now listen close. ()_()";
                targetTime += targettTime;

                level.Totorlvl = 3f;
            }
            else if (level.Totorlvl == 3f && timetalk >= targetTime)
            {
                Tutortext.text = "We need to find an NPC. and go YAPPA to him B)";
                targetTime += targettTime;

                level.Totorlvl = 3.1f;
                goT = it.talked;
                goT = false;
            }
            else if (goT == false)
            {
                goT = it.talked;
            }
            else if (level.Totorlvl == 3.1f && timetalk >= targetTime && goT == true)
            {
                Tutortext.text = "There will be a SKILL CHECK!!!";
                targetTime += targettTime;

                level.Totorlvl = 3.2f;
            }
            else if (level.Totorlvl == 3.2f && timetalk >= targetTime)
            {
                Tutortext.text = "Press SPACE to stop the pin. Remember to Aim for the green bar.";
                targetTime += targettTime;

                level.Totorlvl = 3.3f;
            }
            
            else if (level.Totorlvl == 3.3f && timetalk >= targetTime)
            {
                Tutortext.text = "Or else...";
                targetTime += targettTime;

                level.Totorlvl = 4f;
            }
            else if (level.Totorlvl == 4f && timetalk >= targetTime)
            {
                Tutortext.text = "You’ll get embarrassed";
                targetTime += targettTime;

                emG.SetActive(true);
                level.Totorlvl = 4.1f;
            }
            else if (level.Totorlvl == 4.1f && timetalk >= targetTime)
            {
                Tutortext.text = "If embarrassed is high.";
                targetTime += targettTime;

                level.Totorlvl = 4.2f;
            }
            else if (level.Totorlvl == 4.2f && timetalk >= targetTime)
            {
                Tutortext.text = "You’ll move slower";
                targetTime += targettTime;

                level.Totorlvl = 4.3f;
            }
            else if (level.Totorlvl == 4.3f && timetalk >= targetTime)
            {
                Tutortext.text = "And the pin moves faster";
                targetTime += targettTime;

                level.Totorlvl = 4.4f;
            }
            else if (level.Totorlvl == 4.4f && timetalk >= targetTime)
            {
                Tutortext.text = "And remember...";

                targetTime += targettTime;
                level.Totorlvl = 4.5f;
            }
            else if (level.Totorlvl == 4.5f && timetalk >= targetTime)
            {
                Tutortext.text = "You’re on a timer";

                targetTime += targettTime;
                level.Totorlvl = 4.6f;
            }
            else if (level.Totorlvl == 4.6f && timetalk >= targetTime)
            {
                Tutortext.text = "Now, go get ‘em Steve";

                targetTime += targettTime;
                level.Totorlvl = 5f;
            }
            else if (level.Totorlvl == 5f && timetalk >= targetTime)
            {
                Tutortext.text = "";

                targetTime += targettTime;
                level.Totorlvl = 5f;
                tmG.SetActive(true);
                tmT.SetActive(true);
            }
            if (goT == true && gow == true || tfyl == true)
            {
                timetalk += Time.deltaTime;
            }
        }
        else
        {
            Tutortext.text = "";
            tmG.SetActive(true);
            tmT.SetActive(true);
        }
    }
}
