using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player = null;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //GameObject go = new GameObject() { name = "응애" };
        //go.AddComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.position = new Vector3(
        Mathf.Lerp(transform.position.x, player.transform.position.x, 1f * Time.deltaTime),
        player.transform.position.y + 10, -10);
        //Vector3.Lerp(transform.position, player.transform.position, 1f * Time.deltaTime);
        //transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        //Vector3.Lerp(transform.position, player.transform.position, 1f * Time.deltaTime);
        //player.transform.position + new Vector3(0, 10,-10);
        // 문제!
    }


}
