using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBarScript : MonoBehaviour
{
    public Slider barSlider;

    public void SetMaxHealth(float health)
    {
        barSlider.maxValue = health;
        barSlider.value = health;
    }

    public void SetHealth(float currentHealth)
    {
        barSlider.value = currentHealth;
    }

}
