using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using TMPro;


public class TestScore
{


    [UnityTest]
    public IEnumerator add_and_display_value_into_score()
    {
        // Conf

        SceneManager.LoadScene("Assets/Scenes/GameScene.unity");
        yield return new WaitForSeconds(1f);

        FoodCollectible foodCollectible = FoodCollectible.FindObjectOfType<FoodCollectible>();
        FoodScoreEffect foodScoreEffectScipt = foodCollectible.GetComponent<FoodScoreEffect>();

        TextMeshProUGUI scoreText = TextMeshProUGUI.FindObjectOfType<TextMeshProUGUI>();
        scoreText.text = "0";


        // Act

        foodScoreEffectScipt.Execute(100);
        yield return new WaitForSeconds(0.2f);

        // Ass     :)

        Debug.Log("ScoreText : " + scoreText.text);
        Debug.Log("value : " + "100");

        Assert.AreEqual(scoreText.text, "Score : 100");

    }
}
