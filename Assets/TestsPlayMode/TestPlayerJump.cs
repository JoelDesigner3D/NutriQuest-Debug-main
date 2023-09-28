using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class TestPlayerJump
{
    

    [UnityTest]
    public IEnumerator test_if_jump_modify_Yposition()
    {
        // Configuration

        SceneManager.LoadScene("Assets/Scenes/GameScene.unity");
        yield return new WaitForSeconds(1f);

        GameObject player = GameObject.Find("Player");
        float initialPosY = player.transform.position.y;

        PlayerJump playerJumpScript = player.GetComponentInChildren<PlayerJump>();

        // Act

        playerJumpScript.Jump();
        yield return new WaitForSeconds(0.2f);

        // Assert
        float newPosY = player.transform.position.y;
        Assert.Greater(newPosY, initialPosY);

    }

}
