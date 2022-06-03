using UnityEngine;

public class GameManager : MonoBehaviour
{

    public AudioSource Fart;

    public void GameEnd() {
        Fart.Play();
    }
}