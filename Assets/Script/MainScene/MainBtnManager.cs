using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainBtnManager : MonoBehaviour
{
    /// <summary>
    /// 메인씬의 게임 시작 버튼
    /// </summary>
    public void StartBtn()
    {
        SceneManager.LoadScene("InGame");
    }
    public Image SettingIMG;
    public bool isSetting;
    /// <summary>
    /// 메인씬의 설정 창 버튼
    /// </summary>
    public void SettingBtn()
    {
        if(!isSetting)
        {
            isSetting = true;
            SettingIMG.gameObject.SetActive(true);
        }
        else if(isSetting)
        {
            isSetting = false;
            SettingIMG.gameObject.SetActive(false);
        }
    }
    /// <summary>
    /// 메인씬의 게임 종료 버튼
    /// </summary>
    public void ExitBtn()
    {
        Application.Quit();
    }
}
