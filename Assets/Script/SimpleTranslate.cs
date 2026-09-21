using UnityEngine;

public class SimpleTranslate : MonoBehaviour
{
    public float speed = 5.0f;
    
    void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(vec* speed*Time.deltaTime);
    }
}
