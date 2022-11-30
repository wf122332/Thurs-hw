using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace S
{
    /// <summary>
    /// 結束管理
    /// </summary>
    
    public class FinalManager : MonoBehaviour
    {
        public static FinalManager instance;
        /// <summary>
        /// 結束畫布
        /// </summary>
        private CanvasGroup groupFinal;
        private TextMeshProUGUI textTitle;
        private Button btnReplay;

        private void Awake()
        {
            instance = this;

            groupFinal = GameObject.Find("結束畫布").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        public void GameOver(string title)
        {
            textTitle.text = title;
            StartCoroutine(FadeIn());
        }

        private IEnumerator FadeIn()
        {
            for(int i=0;i<10;i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;

        }

        private void Replay()
        {
            SceneManager.LoadScene("開始選單");
        }
    }

}
