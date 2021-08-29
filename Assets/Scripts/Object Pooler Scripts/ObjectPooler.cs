using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{

    public static ObjectPooler instance;
	private void Awake()
	{
        instance = this;
	}

	private List<GameObject> objectsPool;
    public GameObject objectToPool;
    
    [SerializeField]
    private int amountToPool = 3;
	[SerializeField]
	private bool canExpand = true;

    
    void Start()
    {
        // Initialize Pool ...
        objectsPool = new List<GameObject>();

		// Fill Pool with GameObjects ...
		for (int i = 0; i < amountToPool; i++)
		{
            // Instantiate new Object from the given Prefab
            GameObject obj = Instantiate(objectToPool);
			// Set the Active State to false
			obj.SetActive(false);
            // Add the non-Active object to the Pool
            objectsPool.Add(obj);
		}
    }

	public GameObject GetPooledObject()
	{
		// Loop All objects in Pool ...
		foreach (GameObject obj in objectsPool)
		{
			// If found Object non-Active
			if (!obj.activeInHierarchy)
			{
				// set it's active state to true
				obj.SetActive(true);
				// Return it
				return obj;
			}
		}

		// If Pool can Expand ...
		if(canExpand)
		{
			// Instantiate new Object from the given Prefab
			GameObject newObjectToPool = Instantiate(objectToPool);
			// Set the Active State to false
			newObjectToPool.SetActive(false);
			// Add the non-Active object to the Pool
			objectsPool.Add(newObjectToPool);
			// Return This new Object
			return newObjectToPool;
		}

		// No Object in Pool ...
		return null;
	}


}
