using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyWeek : MonoBehaviour
{
    public string today;

    void Start()
    {
        if (today == week[0])
        {
            Debug.Log("Monday:Play Canoepolo");
        }
        else if (today == week[1])
        {
            Debug.Log("Tuesday:Practice Unity");
        }
        else if (today == week[2])
        {
            Debug.Log("Wednesday: Do Homework");
        }
        else if (today == week[3])
        {
            Debug.Log("Thursday: Fly to Spain");
        }
        else if (today == week[4])
        {
            Debug.Log("Friday: Fly Home");
        }
        else if (today == week[5])
        {
            Debug.Log("Saturday: Rest");
        }
        else if (today == week[6])
        {
            Debug.Log("Sunday: Prepare for next week");
        }

        foreach(string i in week2)
        {
            Debug.Log(i);
        }


        switch(today)
        {
            case"Monday":
                Debug.Log("Monday:Play Canoepolo");
                    break;
            
            case "Tuesday":
                Debug.Log("Tuesday:Practice Unity");
                    break;

            case "Wednesday":
                Debug.Log("Wednesday:Play with puppy");
                break;

            case "Thursday":
                Debug.Log("Thursday:Jump very much");
                break;

            case "Friday":
                Debug.Log("Friday: Drink water");
                break;

            case "Saturday":
                Debug.Log("Saturday: Work");
                break;

            case "Sunday":
                Debug.Log("Sunday:Rest a lot");
                break;
        }
    }

    string[] week = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    string[] week2 = new string[7] { "Monday: Have fun", "Tuesday: Have even more fun", "Wednesday: Play", "Thursday: play more", "Friday: play at night", "Saturday: play with friends", "Sunday: Its fun play day" };
}
