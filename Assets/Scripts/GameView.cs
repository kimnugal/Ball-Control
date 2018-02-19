using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    [SerializeField]
    Text winText;
    [SerializeField]
    Text loseText;
    [SerializeField]
    Text continueText;
    [SerializeField]
    GameController controller;

    void Start()
    {
        winText.text = "";
        loseText.text = "";
        continueText.text = "";
    }

    public void ShowWin()
    {
        Invoke("ShowContinue", 0.5f);//другой параметр это задержка
        winText.text = "Congratulations!";
    }
    public void ShowLose()
    {
        Invoke("ShowRestart", 0.5f);
        loseText.text = "Game Over";
    }
    void ShowRestart()
    {
        continueText.text = "Press 'Space' to restart";
    }
    void ShowContinue()
    {
        continueText.text = "Press 'Space' to continue";
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            controller.OnViewKey();
    }
}
