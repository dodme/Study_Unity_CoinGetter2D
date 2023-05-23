using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Score++;
            Debug.Log(GameManager.Score);
        }
        Destroy(this.gameObject);
        //Destroy(GameObject) : 매개변수 GameObject를 삭제시킵니다.
    }
}
