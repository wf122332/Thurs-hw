using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace S
{

    public class menuManager : MonoBehaviour
    {
        private Button btnPlay;

        private void Awake()
        {
            btnPlay = GameObject.Find("�}�l�C��").GetComponent<Button>();
            btnPlay.onClick.AddListener(StarGame);
        }

        private void StarGame()
        {
            SceneManager.LoadScene("�C������");
        }
    }
}
