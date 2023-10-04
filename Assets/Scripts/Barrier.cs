using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private BoxCollider2D secondBoxCollider;
    [SerializeField]private bool active;
    public bool Active
    {
        get { return active; }
        set { active = value; renderer.enabled = active; boxCollider.enabled = active; secondBoxCollider.enabled = active; }
    }
    // Start is called before the first frame update
    void Start()
    {
        Active = active;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {
       Active = !Active;
    }
}
