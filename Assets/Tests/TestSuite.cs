using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.TestTools;
using NUnit.Framework;
public class TestSuite 
{
    public GameObject Project;
    private SnowManManager snowmanManager;
    private SpawnManager spawnManager;
    private GameObject snowballDestroyer;
        [SetUp]
        public void SetUp()
    {
        GameObject prefab = Resources.Load<GameObject>("Prefabs/SnowmanAI");
        Project = Object.Instantiate(prefab);

        snowmanManager = Project.GetComponent<SnowManManager>();
        spawnManager = Project.GetComponent<SpawnManager>();
        snowballDestroyer = GameObject.Find("BallDestroyer");
    }

    public IEnumerator GamePrefabLoaded()
    {
        yield return new WaitForEndOfFrame();

        Assert.NotNull(Project, "Make sure game prefab is working");
    }
    //[UnityTest]
    //public IEnumerator SnowBallDestroy()
    //{
       
    //    GameObject snowballPrefab = Resources.Load<GameObject>("Prefabs/Entities/Snowball-Large");
    //    GameObject snowball = Object.Instantiate(snowballPrefab, snowballDestroyer.transform.position, Quaternion.identity);

    //    yield return new WaitForSeconds(.1f);

    //    Assert.IsTrue(snowball == null);
    //}
    [UnityTest]
    public IEnumerator SnowBallSpawn()
    {
        yield return new WaitForEndOfFrame();
    }
    [UnityTest]
    public IEnumerator SnowMenMove()
    {
        yield return new WaitForEndOfFrame();
    }


    [TearDown]
    public void Teardown()
    {
        Object.Destroy(Project);
    }

}
