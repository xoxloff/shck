using UnityEngine;

public class Mill : MonoBehaviour
{

    [SerializeField]
    private GameObject millBlades;

    void Update()
    {
        millBlades.transform.Rotate(new Vector3(-100*Time.deltaTime, 0, 0), Space.Self);
    }
}
