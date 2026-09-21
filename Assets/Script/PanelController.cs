using UnityEngine;

public class PanelController : MonoBehaviour
{
    private bool[] isActive = { true , true , true };
    public GameObject[] _gameObject;
    

    public void ActivateInventory()
    {
        _gameObject[0].SetActive(isActive[0]);
        isActive[0] = !isActive[0];
    }

    public void ActivateSkill()
    {
        _gameObject[1].SetActive(isActive[1]);
        isActive[1] = !isActive[1];
    }

    public void ActivateRank()
    {
        _gameObject[2].SetActive(isActive[2]);
        isActive[2] = !isActive[2];
    }


}
