using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    float minRange;
    [SerializeField]
    float maxRange;
    [SerializeField]
    GameObject item;

    public static int itemCount;

    void Start()
    {
        //Spawn bei Start
         SpawnItem();
    }

    public void SpawnItem()
    {
        //durch random range wird bei spawnen von Item die Item-Position random 
        Instantiate(item, new Vector3(Random.Range(minRange, maxRange), Random.Range(minRange, maxRange), 0), Quaternion.identity);
    }
}
