using UnityEngine;
using TMPro;
public class GoalAreaScript : MonoBehaviour
{
    [SerializeField] private GameObject clearPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("ÉSÅ[Éã");

            if (clearPanel != null)
            {
                clearPanel.SetActive(true);
            }
        }
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
