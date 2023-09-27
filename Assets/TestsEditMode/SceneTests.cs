using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;

public class SceneTests
{


    [SetUp]
    public void Setup()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/GameScene.unity");
    }

    [Test]
    public void VerifyGroundLayout()
    {
        var gameObject = GameObject.Find("Ground");
        string layerName = LayerMask.LayerToName(gameObject.layer);

        Assert.AreEqual(layerName, "Ground");
    }

    [Test]
    public void VerifyPlayerTag()
    {
        var gameObject = GameObject.Find("Player");
        string tagName = gameObject.tag;

        Assert.That(gameObject, Is.Not.Null);

        Assert.AreEqual(tagName, "Player");
    }


    [Test]
    public void VerifyPlayerPosition()
    {
        var player = GameObject.Find("Player");

        Assert.AreEqual(new Vector3(0, 0, 0), player.transform.position);
    }



    [Test]
    public void VerifyFoods()
    {
        // Trouver tous les GameObjects ayant un script "FoodCollectible"
        FoodCollectible[] components = FoodCollectible.FindObjectsOfType<FoodCollectible>();

        Assert.IsNotEmpty(components);

    }
    

    [TearDown]
    public void Teardown()
    {
        EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);
    }


}
