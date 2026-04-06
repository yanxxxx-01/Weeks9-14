using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Field : MonoBehaviour
{
    public SpriteRenderer sr;
    public Transform PlantTransform;


    public int growthStage = 0; // 0: empty, 1: seed, 2: sprout, 3: mature plant
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlantTransform.localScale = Vector3.zero; // Start with the plant scaled down to zero
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnGrowth()
    {
        StartCoroutine(OnGrow());
    }

    IEnumerator OnGrow()
    {
        if (growthStage == 0)
        {
            // Animate the plant growing
            float t = 0;

            while (t < 1)
            {
                t += Time.deltaTime;
                // Scale the plant from 0 to 1 over time
                PlantTransform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, t);
                yield return null;
            }

            growthStage = 1; // Update growth stage to seed
        }


    }
}
