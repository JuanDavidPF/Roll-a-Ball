using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_controller : MonoBehaviour {

    //variables
    bool isPaused = false;
    public GameObject panelPause;

    // Start is called before the first frame update
    void Start () {
        isPaused = false;
    }

    // Update is called once per frame
    void Update () {

    }

    public void PausarJuego () {

        isPaused = !isPaused;

        if (isPaused) {
            Time.timeScale = 0;

        } else {
            Time.timeScale = 1;

        }

        panelPause.SetActive (isPaused);

    }

    public void Restart () {

        SceneManager.LoadScene (0);
        PausarJuego();
    }
}