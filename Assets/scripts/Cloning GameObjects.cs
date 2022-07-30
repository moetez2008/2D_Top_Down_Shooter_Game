using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject original;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 position = Camera.main.ScreenPointToRay(Input.mousePosition).origin;

            GameObject clone = Instantiate(original, position, Quaternion.identity);

            Destroy(clone, 1f);
        }
    }
}
