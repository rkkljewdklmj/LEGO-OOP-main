using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject treed;
    private GameObject trees;
    public GameObject tree;
    private Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tree")
        {
            anim.SetTrigger("tree");
            Debug.Log("triggered" + other.gameObject.tag);
            trees = other.gameObject;
            trees.GetComponent<triggered>().playanimation();
            treed = other.gameObject;
            treed.GetComponent<triggered>().playanimation();
        }
    }
    private void Start()
    {
        anim = tree.GetComponent<Animator>();
    }

}
