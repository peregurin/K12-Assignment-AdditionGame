using UnityEngine;

public class IceCreamSpawner : MonoBehaviour
{
    public Transform prefab;

    public void InstantiateIceCreamScoops(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Instantiate(prefab, new Vector3(0, i * 2.0f, 0), Quaternion.identity, transform);
        }
    }

    public void ClearScoopStack()
    {
        foreach(Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
