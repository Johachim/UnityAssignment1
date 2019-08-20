using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnButton : MonoBehaviour
{
    public Transform prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onSpawnButtonClick()
    {
        //GameObject.CreatePrimitive(PrimitiveType.Cube).AddComponent(typeof(Rigidbody);
        
        Instantiate(prefab, new Vector3(2, 4, 2), Quaternion.identity);
        
    }
}
