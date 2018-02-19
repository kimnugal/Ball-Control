using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    [SerializeField]
    GameController gameController;

    void OnTriggerEnter(Collider col)
    {
        gameController.Lose();
    }
}
