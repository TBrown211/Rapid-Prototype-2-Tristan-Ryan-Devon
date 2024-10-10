using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenChest : MonoBehaviour
{
    private Animator chestAnim;
    public bool isChestOpen = false;
    public float animTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        chestAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        chestAnim.SetBool("chestOpen", isChestOpen);
        AnimationTimer();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.GetComponent<PlayerInputs>())
        {
            isChestOpen=true;
        }        
    }

    void AnimationTimer()
    {
        if (isChestOpen)
        {
            animTimer += Time.deltaTime;
        }
        else
        {
            animTimer = 0;
        }

        if(animTimer > 5)
        {
            SceneManager.LoadScene("Menu Screen");
        }
    }
}
