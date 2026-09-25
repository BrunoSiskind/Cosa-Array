using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public int[] edades = new int[4];
    // Start is called before the first frame update
    void Start()
    {
        edades[3] = 16;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Keycode.C))
        {
        ClearArray(edades);
        }
    }

    void ClearArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 0;
        }
    }

    void SquareOfIndex(int[] array)
    {
        array[i] = i * i;
    }

    void RandomNumbers(int[] array)
    {
        edades[0]= Random.Range(0, 11); 
        edades [2] = 16;
    }
}
