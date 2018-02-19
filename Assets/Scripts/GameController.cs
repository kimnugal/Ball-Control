using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField]
    BallController player;

    [SerializeField]
    GameView view;

    GameState state = GameState.PLAYING;

    public void Lose()
    {
        state = GameState.LOSE;
        player.DisableControl();
        view.ShowLose();
    }
    public void Win()
    {
        state = GameState.WIN;
        player.DisableControl();
        view.ShowWin();
    }
public void OnViewKey()
{
    if (state == GameState.PLAYING)
        return; //игнор

    //индекс текущего уровня
    int currentBuildInd = SceneManager.GetActiveScene().buildIndex;

    if(state == GameState.LOSE)//если проиграл
    {
        SceneManager.LoadSceneAsync(currentBuildInd);
        return;
    }

    int indToLoad = currentBuildInd;

    if (currentBuildInd + 1 < SceneManager.sceneCountInBuildSettings)//есть ли следующий уровень?
        ++indToLoad;

    SceneManager.LoadSceneAsync(indToLoad);
}
}
