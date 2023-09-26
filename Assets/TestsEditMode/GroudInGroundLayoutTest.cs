using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;

public class GroudInGroundLayoutTest
{
    [SetUp]
    public void Setup()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/GameScene.unity");
    }

    [Test]
    public void VerifyLayout()
    {
        var gameObject = GameObject.Find("Ground");
        string layerName = LayerMask.LayerToName(gameObject.layer);

        //Assert.That(gameObject, Is.Not.Null);
        Assert.AreEqual(layerName, "Ground");
    }

    [TearDown]
    public void Teardown()
    {
        EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);
    }


}
