using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    private EnemyFactory enemyFactory;

    private void Start()
    {
        enemyFactory = new EnemyFactory();
        enemyFactory.AddNewEnemy(EnemyTypes.Fast);
        enemyFactory.AddNewEnemy(EnemyTypes.Slow);

    }
}
