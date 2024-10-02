using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button leftButton;
    public Button rightButton;
    public Slider cableSlider;
    public Slider trolleySlider;

    public CraneRotation crane;
    public CableController cable;
    public TrolleyController trolley;

    void Start()
    {
        leftButton.onClick.AddListener(() => crane.RotateCraneLeft());
        rightButton.onClick.AddListener(() => crane.RotateCraneRight());
        cableSlider.onValueChanged.AddListener((value) => cable.SetCableLength(value));
        trolleySlider.onValueChanged.AddListener((value) => trolley.SetTrolleyPosition(value));
    }

    void Update()
    {

    }
}
