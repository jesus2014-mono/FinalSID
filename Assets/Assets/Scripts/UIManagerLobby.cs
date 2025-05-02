using System;
using UnityEngine;
using TMPro;
using DG.Tweening;
using System.Threading.Tasks;
using System.Collections;

public class UIManagerLobby: MonoBehaviour
{
    [Header("Juego Panel")]
    [SerializeField] RectTransform JuegoRect;
    [SerializeField] float topPosY_Juego, middlePosY_Juego;
    [SerializeField] float tweenDurationJuego;

    [Header("Gestionar Boton")]
    [SerializeField] RectTransform GestionarBTN_Rect;
    [SerializeField] float leftPosX_GestionarBTN, middlePosX_GestionarBTN;
    [SerializeField] float tweenDurationGestionarBTN;

    [Header("Gestionar Panel")]
    [SerializeField] RectTransform GestionarRect;
    [SerializeField] float leftPosX_Gestionar, middlePosX_Gestionar;
    [SerializeField] float tweenDurationGestionar;

    [Header("Buscar Panel")]
    [SerializeField] RectTransform BuscarRect;
    [SerializeField] float leftPosX_Buscar, middlePosX_Buscar;
    [SerializeField] float tweenDurationBuscar;

    [Header("Borrar Panel")]
    [SerializeField] RectTransform BorrarRect;
    [SerializeField] float leftPosX_Borrar, middlePosX_Borrar;
    [SerializeField] float tweenDurationBorrar;

    [Header("AmigoConectado Panel")]
    [SerializeField] RectTransform AmigoConectadoRect;
    [SerializeField] float topPosY_AmigoConectado, middlePosY_AmigoConectado;
    [SerializeField] float tweenDurationAmigoConectado;



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(AvisoAmigoConectado());
        }
    }
    public void JuegoIntro()
    {
        JuegoRect.DOAnchorPosY(middlePosY_Juego, tweenDurationJuego).SetUpdate(true);
    }
    public void JuegoPanelOutro()
    {
        JuegoRect.DOAnchorPosY(topPosY_Juego, tweenDurationJuego).SetUpdate(true);
    }
    public void GestionarBTNIntro()
    {
        GestionarBTN_Rect.DOAnchorPosX(middlePosX_GestionarBTN, tweenDurationGestionarBTN).SetUpdate(true);
    }
    public void GestionarBTNOutro()
    {
        GestionarBTN_Rect.DOAnchorPosX(leftPosX_GestionarBTN, tweenDurationGestionarBTN).SetUpdate(true);
    }
    public void GestionarPanelIntro()
    {
        GestionarRect.DOAnchorPosX(middlePosX_Gestionar, tweenDurationGestionar).SetUpdate(true);
    }
    public void GestionarPanelOutro()
    {
        GestionarRect.DOAnchorPosX(leftPosX_Gestionar, tweenDurationGestionar).SetUpdate(true);
    }
    public void BuscarPanelIntro()
    {
        BuscarRect.DOAnchorPosX(middlePosX_Buscar, tweenDurationBuscar).SetUpdate(true);
    }
    public void BuscarPanelOutro()
    {
        BuscarRect.DOAnchorPosX(leftPosX_Buscar, tweenDurationBuscar).SetUpdate(true);
    }
    public void BorrarPanelIntro()
    {
        BorrarRect.DOAnchorPosX(middlePosX_Borrar, tweenDurationBorrar).SetUpdate(true);
    }
    public void BorrarPanelOutro()
    {
        BorrarRect.DOAnchorPosX(leftPosX_Borrar, tweenDurationBorrar).SetUpdate(true);
    }
    public void AmigoConectadoIntro()
    {
        AmigoConectadoRect.DOAnchorPosY(middlePosY_AmigoConectado, tweenDurationAmigoConectado).SetUpdate(true);
    }
    public void AmigoConectadoOutro()
    {
        AmigoConectadoRect.DOAnchorPosY(topPosY_AmigoConectado, tweenDurationAmigoConectado).SetUpdate(true);
    }
    IEnumerator AvisoAmigoConectado()
    {
        AmigoConectadoIntro();
        yield return new WaitForSeconds(2);
        AmigoConectadoOutro();
    }    
}