using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class VectorLerp : MonoBehaviour
{
    public GameObject target;

    Vector3 _origin = Vector3.zero;
    Vector3 value = Vector3.zero;
    bool targetCheckButton = false;
    bool resetCheckButton = false;
    private void Awake()
    {
        _origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (targetCheckButton)
            transform.position = Vector3.Lerp(transform.position, target.transform.position, 0.5f);
        if (resetCheckButton)
            transform.position = _origin;
    }


    public void CheckButtonChange()
    {
        resetCheckButtons();
        targetCheckButton = true;
    }

    public void resetTransform()
    {
        resetCheckButtons();
        resetCheckButton = true;
    }

    void resetCheckButtons()
    {
        Debug.Log("All Check Buttons reset");
        targetCheckButton = resetCheckButton = false;
    }
}
