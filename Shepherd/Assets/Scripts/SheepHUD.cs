using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SheepHUD : MonoBehaviour
{

	public Slider slider;
	public Gradient gradient;
	public Image fill;

	public int maxHealth;
	public int currentHealth;


    private void Start()
    {
		currentHealth = maxHealth;
		this.SetMaxHealth(maxHealth);
    }

	public void TakeDamage(int damage)
    {
		if (currentHealth != 0)
        {
			currentHealth -= damage;
			this.SetHealth(currentHealth);
			Debug.Log("Sheep Took Damage");
		}
		if (currentHealth == 0)
        {
			this.gameObject.SetActive(false);
			Debug.Log("Coyote Killed Sheep");
        }
    }
    public void SetMaxHealth(int health)
	{
		slider.maxValue = health;
		slider.value = health;

		fill.color = gradient.Evaluate(1f);
	}

	public void SetHealth(int health)
	{
		slider.value = health;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}
	//https://www.youtube.com/watch?v=BLfNP4Sc_iA&ab_channel=Brackeys

}
