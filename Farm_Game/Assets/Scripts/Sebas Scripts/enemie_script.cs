using UnityEngine;
using System.Collections;

public class enemie_script : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent _navMeshAgent;
    private GameObject _playerObj;
    public GameObject target;
    public float PlayerHealth = 100f;
    void Start()
    {
        _navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        GameObject[] possibleTargets = GameObject.FindGameObjectsWithTag("Player");
        target = possibleTargets[Random.Range(0, possibleTargets.Length - 1)];
    }

    void Update()
    {
      //  if ()   //als je de player bereikt hebt, stop dan met lopen.
        {
        }
        //Debug.Log(target.transform.position);
        _navMeshAgent.SetDestination(target.transform.position);
        transform.LookAt(target.transform.position);
    }

   
        void OnCollisionEnter(Collision coll)
    {
        Debug.Log(coll.gameObject.tag);



        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("ello");

            

            Destroy(gameObject);

        }

    }
}