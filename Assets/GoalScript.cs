using TMPro;
using UnityEngine;

public class GoalScript : MonoBehaviour
{

    public GameObject confetti;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        confetti.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ball"))
        {
            //Win logic
            Debug.Log("You won!");
            confetti.SetActive(true);
        }
    }
}
