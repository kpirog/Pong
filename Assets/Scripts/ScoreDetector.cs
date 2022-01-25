using UnityEngine;
using UnityEngine.Events;

public class ScoreDetector : MonoBehaviour
{
    public UnityEvent onScoreTrigger;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        onScoreTrigger?.Invoke();
    }
}
