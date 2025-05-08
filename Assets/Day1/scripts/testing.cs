using UnityEngine;

public class testing : MonoBehaviour
{

    [SerializeField] Mesh newMesh;
    [SerializeField] Material newMaterial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject newObject = new GameObject("NewObject");
        newObject.AddComponent<MeshFilter>().mesh = newMesh;
        newObject.AddComponent<MeshRenderer>().material = newMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
