using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscena : MonoBehaviour
{
    public GameObject CanvasPerdiste;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Perdiste()
    {
        CanvasPerdiste.SetActive(true);
        Time.timeScale = 0;
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }
}
