using UnityEngine;

public class EnemyGetter : Getter<Enemy>
{
    private Enemy _enemy;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _enemy = GetObject();
            _enemy.Attack();
        }
    }
}