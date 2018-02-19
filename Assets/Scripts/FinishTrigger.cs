using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField]
    GameController gameController;

    void OnTriggerEnter(Collider col)
    {
        gameController.Win();
    }
}
