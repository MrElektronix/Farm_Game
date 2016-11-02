using UnityEngine;
using System.Collections;

public class enemie_script : MonoBehaviour
{

    private NavMeshAgent _navMeshAgent;
    private GameObject _playerObj;
    public GameObject target;
  

    
    void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _playerObj = GameObject.FindGameObjectWithTag("Player");


    }

    void Update()
    {
      //  if ()   //als je de player bereikt hebt, stop dan met lopen.
        {

        }


        if (!_playerObj)
            return;

        _navMeshAgent.SetDestination(_playerObj.transform.position);
        transform.LookAt(_playerObj.transform.position);

    }
}