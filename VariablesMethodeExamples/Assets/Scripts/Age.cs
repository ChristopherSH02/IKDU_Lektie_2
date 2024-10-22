using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Age : MonoBehaviour
{
    public int currentAge = 22;
    public int ageIncrease = 1;
    public int ageIncreaseMore = 4;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(currentAge + ageIncrease);
        Debug.Log(currentAge + ageIncreaseMore);
        Debug.Log(gettingOlder(currentAge, ageIncrease));
    }

    int gettingOlder(int a,int b)
    {
        a += b;
        return a;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
