using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    CharacterControllerEx _characterControllerEx = null;

    private void Start()
    {
        _characterControllerEx = transform.parent.gameObject.GetComponent<CharacterControllerEx>();
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _characterControllerEx.IsGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _characterControllerEx.IsGround = false;
        }
    }
}
