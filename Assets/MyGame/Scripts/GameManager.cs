using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    float minRange;
    [SerializeField]
    float maxRange;
    [SerializeField]
    GameObject item;

    void Start()
    {
        //Spawn bei Start
         SpawnItem();
    }

    public void SpawnItem()
    {
        //durch random range wird Item random gespawnt
        Instantiate(item, new Vector3(Random.Range(minRange, maxRange), Random.Range(minRange, maxRange), 0), Quaternion.identity);
    }
}
