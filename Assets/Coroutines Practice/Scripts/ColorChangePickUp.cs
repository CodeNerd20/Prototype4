using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangePickUp : MonoBehaviour
{
    [Header("Materials")]
    public Material defaultMaterial;
    public Material newMaterial;

    [Header("Duration")]
    public float duration;

    //Components

    private MeshRenderer myMr;
    private MeshRenderer playerMr;
    private Collider myCollider;


    // Start is called before the first frame update
    void Start()
    {
        myMr = GetComponent<MeshRenderer>();
        myCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Get the player MR
            playerMr = other.gameObject.GetComponent<MeshRenderer>();

            //Activate the Coroutine!
            StartCoroutine(ChangeColor());

        }
    }

    IEnumerator ChangeColor()
    {
        //Chane to the new color
        playerMr.material = newMaterial;

        //Wait
        yield return new WaitForSeconds(duration);


        //Change back
        playerMr.material = defaultMaterial;
    }
}
