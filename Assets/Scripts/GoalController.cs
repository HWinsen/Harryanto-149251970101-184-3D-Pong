using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    [SerializeField] private ScoreManager manager;
    [SerializeField] private ObjectPooler objectPooler;
    [SerializeField] private BallSpawnerController ballSpawnerController;
    [SerializeField] private bool isPlayerTwo;
    [SerializeField] private bool isPlayerThree;
    [SerializeField] private bool isPlayerFour;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<BallController>().spawned = true;

            if (isPlayerTwo)
            {
                //Debug.Log("Hit Tembok Player Two");
                manager.AddPlayerTwoScore(1);
            }
            else if (isPlayerThree)
            {
                //Debug.Log("Hit Tembok Player Three");
                manager.AddPlayerThreeScore(1);
            }
            else if (isPlayerFour)
            {
                //Debug.Log("Hit Tembok Player Four");
                manager.AddPlayerFourScore(1);
            }
            else
            {
                //Debug.Log("Hit Tembok Player One");
                manager.AddPlayerOneScore(1);
            }
        }
    }
}
