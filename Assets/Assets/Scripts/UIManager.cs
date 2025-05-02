using System;
using UnityEngine;
using TMPro;
using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
public class UIManager: MonoBehaviour
{
    public string sceneName;

    [Header("Main Panel")]
    [SerializeField] RectTransform MainRect;
    [SerializeField] float topPosY_Main, middlePosY_Main;
    [SerializeField] float tweenDurationMain;


    [Header("InicioSesion Panel")]
    [SerializeField] RectTransform InicioSesionRect;
    [SerializeField] float rightPosX_InicioSesion, middlePosX_InicioSesion;
    [SerializeField] float tweenDurationInicioSesion;

    [Header("RegistroSesion Panel")]
    [SerializeField] RectTransform RegistroRect;
    [SerializeField] float leftPosX_Registro, middlePosX_Registro;
    [SerializeField] float tweenDurationRegistro;


    public void MainPanelIntro()
    {
        MainRect.DOAnchorPosY(middlePosY_Main, tweenDurationMain).SetUpdate(true);
    }
    public void MainPanelOutro()
    {
        MainRect.DOAnchorPosY(topPosY_Main, tweenDurationMain).SetUpdate(true);
    }
    public void InicioSesionPanelIntro()
    {
        InicioSesionRect.DOAnchorPosX(middlePosX_InicioSesion, tweenDurationInicioSesion).SetUpdate(true);
    }

    public void InicioSesionPanelOutro()
    {
        InicioSesionRect.DOAnchorPosX(rightPosX_InicioSesion, tweenDurationInicioSesion).SetUpdate(true);
    }
    public void RegistroPanelIntro()
    {
        RegistroRect.DOAnchorPosX(middlePosX_Registro, tweenDurationRegistro).SetUpdate(true);
    }

    public void RegistroPanelOutro()
    {
        RegistroRect.DOAnchorPosX(leftPosX_Registro, tweenDurationRegistro).SetUpdate(true);
    }
    public void LoadTargetScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}