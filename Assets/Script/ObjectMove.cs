using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public Transform objectA;
    public Transform objectB;

    public Transform targetC;
    public Transform targetD;

    private Vector3 originalPositionA;
    private Vector3 originalPositionB;

    void Start()
    {
        originalPositionA = objectA.position;
        originalPositionB = objectB.position;
    }

    public void MoveToTarget()
    {
        objectA.position = targetC.position;
        objectB.position = targetD.position;
    }

    public void ReturnToOriginal()
    {
        objectA.position = originalPositionA;
        objectB.position = originalPositionB;
    }
}
