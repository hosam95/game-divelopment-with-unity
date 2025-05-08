using Unity.VisualScripting;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    float scaleFactor = 1.3f; // The factor by which to scale the button

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    } 

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseEnter()
    {
        gameObject.GetComponent<Animator>().SetBool("isHovering", true);
    }

    public void OnMouseExit()
    {
        gameObject.GetComponent<Animator>().SetBool("isHovering", false);
    }
}
