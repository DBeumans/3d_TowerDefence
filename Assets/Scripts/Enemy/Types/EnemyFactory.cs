using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyTypes
{
    Slow,
    Fast
}

public class EnemyFactory : MonoBehaviour {

    public void AddNewEnemy(EnemyTypes type)
    {
        Enemy enemy = createEnemy(type);

        enemy.Enter();

    }
    
    private Enemy createEnemy(EnemyTypes type)
    {   
        switch(type)
        {
            case EnemyTypes.Slow:
                return new SlowEnemy();
                break;

            case EnemyTypes.Fast:
                return new FastEnemy();
                break;

            default:
                return null;
        }
    }



}
