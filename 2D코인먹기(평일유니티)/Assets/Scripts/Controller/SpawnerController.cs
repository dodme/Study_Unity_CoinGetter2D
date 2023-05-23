using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    GameObject player = null;
    GameObject coin = null;
    float _time = 0;
    float _randPosX = 0;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        coin = Resources.Load<GameObject>("Prefabs/Coin");
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if(_time >= 1)
        {
            // @@TODO
            _randPosX = Random.Range(-25, 55);
            _time = 0;
            Instantiate(coin,new Vector3(_randPosX,28,0),Quaternion.identity);
            //Instantiate(GameObject) : 오브젝트 복사생성 함수
            //Instantiate(GameObject,Vector3,Quaternion)
        }
    }
}
