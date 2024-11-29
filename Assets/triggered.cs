using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggered : MonoBehaviour
{
    public GameObject objectanimate;
    private Animator anim;
    public GameObject objectanimated;
    void Start()
    {
        anim = objectanimate.GetComponent<Animator>();
        anim = objectanimated.GetComponent<Animator>();
    }
    public void playanimation()
    {
        anim.SetTrigger("tree");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
