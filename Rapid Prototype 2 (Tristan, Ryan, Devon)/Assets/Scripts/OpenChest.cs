using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    private Animator chestAnim;
    public bool isChestOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        chestAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        chestAnim.SetBool("chestOpen", isChestOpen);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.GetComponent<PlayerInputs>())
        {
            isChestOpen=true;
        }
    }
}
