using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        App.gameManager = this;
        App.screenManager.Show<MenuScreen>();
    }
}