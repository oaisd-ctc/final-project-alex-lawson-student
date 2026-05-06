using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] Level level;
    public TextMeshProUGUI Tutortext;
    private float timetalk = 0;
    public bool goT = true;
    public float targetTime = 0;
    public float targettTime = 5;
    private void Update()
    {
        if(level.end == false)
        {
            goT = true;
            if (goT == true)
            {
                timetalk += Time.deltaTime;
            }
            print(timetalk);
            if (level.Totorlvl == 0)
            {
                Tutortext.text = "Welcome to Yappa and We need to Yap. B)";
                targetTime += targettTime;
                level.Totorlvl = 1.5f;
            }

            if (level.Totorlvl == 1.5 && timetalk >= targetTime)
            {
                Tutortext.text = "But first, we need to move. 0_0";
                targetTime += targettTime;
                level.Totorlvl = 2;
            }

            else if (level.Totorlvl == 2 && timetalk >= targetTime)
            {
                Tutortext.text = "Use WASD to move.";
                targetTime += targettTime;

                //goT = false;
                level.Totorlvl = 2.5f;
            }

            else if (level.Totorlvl == 2.5 && timetalk >= targetTime)
            {
                Tutortext.text = "Now listen close. ()_()";
                targetTime += targettTime;

                level.Totorlvl = 3;
            }
            else if (level.Totorlvl == 3 && timetalk >= targetTime)
            {
                Tutortext.text = "We need to find an NPC.";
                targetTime += targettTime;

                //goT = false;
                level.Totorlvl = 3.1f;
            }
            else if (level.Totorlvl == 3.1 && timetalk >= targetTime)
            {
                Tutortext.text = "There will be a SKILL CHECK!!!";
                targetTime += targettTime;

                level.Totorlvl = 3.2f;
            }
            else if (level.Totorlvl == 3.2 && timetalk >= targetTime)
            {
                Tutortext.text = "Press SPACE to stop the pin. Remember to Aim for the green bar.";
                targetTime += targettTime;

                level.Totorlvl = 3.3f;
            }
            else if (level.Totorlvl == 3.3 && timetalk >= targetTime)
            {
                Tutortext.text = "Or else...";
                targetTime += targettTime;

                level.Totorlvl = 4f;
            }
            else if (level.Totorlvl == 4 && timetalk >= targetTime)
            {
                Tutortext.text = "You’ll get embarrassed";
                targetTime += targettTime;

                level.Totorlvl = 4.1f;
            }
            else if (level.Totorlvl == 4.1 && timetalk >= targetTime)
            {
                Tutortext.text = "If embarrassed";
                targetTime += targettTime;

                level.Totorlvl = 4.2f;
            }
            else if (level.Totorlvl == 4.2 && timetalk >= targetTime)
            {
                Tutortext.text = "You’ll move slower";
                targetTime += targettTime;

                level.Totorlvl = 4.3f;
            }
            else if (level.Totorlvl == 4.3 && timetalk >= targetTime)
            {
                Tutortext.text = "And the pin moves faster";
                targetTime += targettTime;

                level.Totorlvl = 4.4f;
            }
            else if (level.Totorlvl == 4.4 && timetalk >= targetTime)
            {
                Tutortext.text = "And remember...";

                targetTime += targettTime;
                level.Totorlvl = 4.5f;
            }
            else if (level.Totorlvl == 4.5 && timetalk >= targetTime)
            {
                Tutortext.text = "You’re on a timer";

                targetTime += targettTime;
                level.Totorlvl = 4.6f;
            }
            else if (level.Totorlvl == 4.6 && timetalk >= targetTime)
            {
                Tutortext.text = "Now, go get ‘em Steve";

                targetTime += targettTime;
                level.Totorlvl = 5f;
            }
            else if (level.Totorlvl == 5 && timetalk >= targetTime)
            {
                Tutortext.text = "";

                targetTime += targettTime;
                level.Totorlvl = 5f;
            }
        }
        else
        {
            Tutortext.text = "";
        }
    }
}
