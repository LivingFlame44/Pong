using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Breakables : MonoBehaviour
{
    public GameManager gameManager;

    public Text txtMessage;

    public static int noOfBricks = 0; //variable that counts how many bricks are in the scene

    public int brickHP;
    public SpriteRenderer brickSprite;
    public Sprite sDamaged;

    // Start is called before the first frame update
    void Start()
    {
        noOfBricks++; //counts how many game objects are present in the scene
        brickSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Die()
    {
        noOfBricks--;
        if (noOfBricks <= 0)
        {
            GameManager.isThereAnyBricks = true;
        }
        Destroy(this.gameObject); //destroys the brick object
    }

    public void OnCollisionEnter2D(Collision2D actor)
    {
        brickHP -= 1; //decreases the bricks hp
        brickSprite.sprite = sDamaged; //changes the sprite of the brick if damaged
        if (brickHP <= 0)
        {
            Die();
        }
    }
}