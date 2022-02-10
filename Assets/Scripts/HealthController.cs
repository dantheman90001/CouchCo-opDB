using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public GameObject healthBar;
    public GameObject player;

    private float currentLife;

    public float CurrentLife
    {
        get { return currentLife; }
        set
        {
            currentLife = value;
            RectTransform healthBarRectTransform = (RectTransform)healthBar.transform;
            healthBarRectTransform.sizeDelta = new Vector2(currentLife, healthBarRectTransform.sizeDelta.y);

            if(currentLife <=0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    private void Start()
    {
        CurrentLife = 100f;
    }

    public void ReduceLifeByTag(string tag)
    {
        switch (tag)
        {
            case "enemy":
                CurrentLife -= 25f;
                break;
            default:
                break;

        }
    }

    public void FloorReducesLifeByTag(string tag)
    {
        switch (tag)
        {
            case "DeathFloor":
                CurrentLife -= 80f;
                break;
            default:
                break;
        }
    }
}
