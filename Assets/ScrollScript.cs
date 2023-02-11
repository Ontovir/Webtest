using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{[SerializeField] float scrollSpeed = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    private void Scroll()
    {

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 scroll = new Vector2(transform.position.x, transform.position.y + scrollSpeed * Time.deltaTime);
            transform.position = scroll;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 scroll = new Vector2(transform.position.x, transform.position.y - scrollSpeed * Time.deltaTime);
            transform.position = scroll;
        }
    }
}
