using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    public float x;
    public float zombie;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectsWithTag("zombie");
       
    }

    // Update is called once per frame
    void Update()
    {
        int[] numbers = { 1, 4, 3, 8, 7 };

        foreach (int n in numbers)
        {
            x *= 2;
        }
        // numbers : [2, 8, 6, 16, 14]

    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
}
