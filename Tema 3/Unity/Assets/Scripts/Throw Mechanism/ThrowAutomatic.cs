using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAutomatic : MonoBehaviour
{
    public float maxThrowForce = 50f;
    private float currentThrowForce = 0f;
    public GameObject dartPrefab;

    private Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        rotation = Quaternion.Euler(90, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentThrowForce = 0f;
        }

        if (Input.GetMouseButton(0))
        {
            currentThrowForce = Mathf.Min(currentThrowForce + Time.deltaTime * maxThrowForce, maxThrowForce);
        }

        if (Input.GetMouseButtonUp(0))
        {
            ThrowDart(currentThrowForce);
        }
    }

    void ThrowDart(float throwForce)
    {
        GameObject dart = Instantiate(dartPrefab, transform.position, rotation);
        AssignRandomColor(dart);
        dart.GetComponent<Dart>().SetThrowPosition(transform.position);
        Rigidbody dartRigidbody = dart.GetComponent<Rigidbody>();
        dartRigidbody.AddForce(transform.forward * throwForce, ForceMode.Impulse);
    }

    void AssignRandomColor(GameObject dart)
    {
        Renderer dartRenderer = dart.GetComponent<Renderer>();
        Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        dartRenderer.material.color = randomColor;
    }

}
