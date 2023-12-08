using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class RebindButton : MonoBehaviour
{
    [SerializeField]
    private PlayerInput _playerInput;
    public TMPro.TextMeshPro textButton;

    [SerializeField]
    private string m_BindingId;

    void StartRebind(string str)
    {
        _playerInput.actions["MoveRight"].PerformInteractiveRebinding()
            .WithTargetBinding(0)
            .OnComplete(_ => AfterRebind(_playerInput.actions[str]))
            .Start();
    }


    public void AfterRebind(InputAction _inputAction)
    {
        textButton.text = InputControlPath.ToHumanReadableString(_inputAction.bindings[0].effectivePath, InputControlPath.HumanReadableStringOptions.OmitDevice);
    }

  

}
