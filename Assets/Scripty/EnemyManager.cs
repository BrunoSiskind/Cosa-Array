using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Enemy[] enemies;
    // Start is called before the first frame update

    void Start()
    {
     enemies = FindObjectsOfType<Enemy>();
     SetAllEnemiesDamagePointsTo(5);
     Debug.Log(enemies[enemies.Length-1].damadegePoints);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetAllEnemiesDamagePointsTo(int value)
    {
        for(int i = 0; i < enemies.Length; i++)
        {
            enemies[i].damadegePoints = value;
        }
    }
}
