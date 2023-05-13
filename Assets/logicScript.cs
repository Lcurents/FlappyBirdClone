using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int skorplayer;
    public Text teksskor;
    public GameObject tampilangameover;
    public void tambahskor(int tambahan)
    {
        skorplayer+=tambahan;
        teksskor.text = skorplayer.ToString();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        tampilangameover.SetActive(true);
    }
}
