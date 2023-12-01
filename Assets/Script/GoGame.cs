using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GoGame : MonoBehaviour
{
    [SerializeField] List<Transform> spawn;
    [SerializeField] private GameObject enemy;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("aaaaaaaaaaa");
            Instantiate(enemy, transform.position, Quaternion.identity);

        }
    }
    public void ChoseSpawn(InputAction.CallbackContext ctx)
    {
    }


}
