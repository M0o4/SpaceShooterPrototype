using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestSiute
{
    [UnityTest]
    public IEnumerator LaserMovesUp()
    {
        var laser = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/LaserBolt"));
        var originalPosition = laser.transform.position.y;
        
        yield return new WaitForSeconds(0.1f);

        Assert.Greater(laser.transform.position.y, originalPosition);
    }
    
    [UnityTest]
    public IEnumerator LaserHitEnemy()
    {
        var enemy = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/EnemySmall"));
        enemy.transform.position = Vector3.zero;
        var laser = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/LaserBolt"));
        laser.transform.position = Vector3.zero;
        
        yield return new WaitForSeconds(0.1f);

        Assert.False(laser.activeSelf);
    }
}
