using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Field : MonoBehaviour
{
    public SpriteRenderer sr;
    public SpriteRenderer plant;
    public Transform PlantTransform;
    public Transform FlowerTransform;
    private int toolCurrent;


    public int growthStage = 0; // 0: empty, 1: seed, 2: sprout, 3: mature plant
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlantTransform.localScale = Vector3.zero; // Start with the plant scaled down to zero
            FlowerTransform.localScale = Vector3.zero; // Start with the flower scaled down to zero
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEClick()
    {
        StartCoroutine(OnGrow(toolCurrent));
        Debug.Log("tool received in field: " + toolCurrent);
    }

    public void OnGrowth(int tool)
    {
        toolCurrent = tool;
        
    }

    IEnumerator OnGrow(int toolID)
    {
        if (growthStage == 0 && toolID == 0)
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
        if (growthStage == 1 && toolID == 1)
        {
            // Animate the plant growing
            float t = 0;
            while (t < 1)
            {
                t += Time.deltaTime;
                // Scale the plant from 1 to 1.5 over time
                PlantTransform.localScale = Vector3.Lerp(Vector3.one, Vector3.one * 1.5f, t);
                yield return null;
            }
            growthStage = 2; // Update growth stage to sprout
        }
        if (growthStage == 2 && toolID == 2)
        {
            // Animate the plant growing
            float t = 0;
            while (t < 1)
            {
                t += Time.deltaTime;
                // Scale the plant from 1.5 to 2 over time
                PlantTransform.localScale = Vector3.Lerp(Vector3.one * 1.5f, Vector3.one * 2f, t);
                yield return null;
            }
            float t2 = 0;
            while (t2 < 1)
            {
                t2 += Time.deltaTime;
                // Scale the plant from 2 to 2.5 over time
                FlowerTransform.localScale = Vector3.Lerp(Vector3.one, Vector3.one * 1.5f, t2);
                yield return null;
            }
            growthStage = 3; // Update growth stage to mature plant
        }
    }
}
