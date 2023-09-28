using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class FoodDisabledAfterCollect
{
    [Test]
    public void test_if_food_disabled_after_collect()
    {
        // Config
        GameObject gameObject = new GameObject();
        FoodCollectible foodCollectible = gameObject.AddComponent<FoodCollectible>();

        // Act
        foodCollectible.HideGameObject();

        // Assert
        Assert.IsFalse(gameObject.activeSelf);
    }

}
