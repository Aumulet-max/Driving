using UnityEngine;

public class AutoDrive : MonoBehaviour
{
    public float aiSpeed = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * aiSpeed * Time.deltaTime);
    }
}
