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
    public TextMeshProUGUI Tutortext, tmT;
    public GameObject tmG, emG;
    private float timetalk = 0;
    public bool goT = true, gow = true;
    public float targetTime = 0;
    public float targettTime = 5;
    


    private void Start()
    {
        tmG.SetActive(false);
        emG.SetActive(false);
        tmT.text = "";
    }
    private void Update()
    {
        gow = pr.moved;
        goT = it.talked;

        if (level.end == false)
        {
            tmT.text = "";
            if (goT == true && gow == true)
            {
                timetalk += Time.deltaTime;
            }
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

                gow = false;
                level.Totorlvl = 2.5f;
            }

            else if (level.Totorlvl == 2.5f && timetalk >= targetTime && gow == true)
            {
                Tutortext.text = "Now listen close. ()_()";
                targetTime += targettTime;

                level.Totorlvl = 3f;
            }
            else if (level.Totorlvl == 3f && timetalk >= targetTime)
            {
                Tutortext.text = "We need to find an NPC.";
                targetTime += targettTime;

                level.Totorlvl = 3.1f;
            }
            else if (level.Totorlvl == 3.1f && timetalk >= targetTime)
            {
                Tutortext.text = "There will be a SKILL CHECK!!!";
                targetTime += targettTime;

                level.Totorlvl = 3.2f;
            }
            else if (level.Totorlvl == 3.2f && timetalk >= targetTime)
            {
                Tutortext.text = "Press SPACE to stop the pin. Remember to Aim for the green bar.";
                targetTime += targettTime;

                goT = false;
                level.Totorlvl = 3.3f;
            }
            else if (level.Totorlvl == 3.3f && goT == true)
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
                Tutortext.text = "If embarrassed is high same for the opposite.";
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
            }
        }
        else
        {
            Tutortext.text = "";
            tmG.SetActive(true);
        }
    }
}
