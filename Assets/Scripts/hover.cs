using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{

    public Sprite customSprite;
    public Sprite hoverSprite;
    public Sprite pressedSprite;

    private Image button;

    public void Start()
    {
        button = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        button.sprite = hoverSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        button.sprite = customSprite;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        button.sprite = pressedSprite;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        button.sprite = customSprite;
    }
}
