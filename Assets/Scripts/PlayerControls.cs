// GENERATED AUTOMATICALLY FROM 'Assets/Misc/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""5531244c-c8f3-470c-ac97-1ee0c6eb794d"",
            ""actions"": [
                {
                    ""name"": ""HoldAction"",
                    ""type"": ""Button"",
                    ""id"": ""66e3b947-9c0e-4bbf-804e-ec43924dd342"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CursorPosition"",
                    ""type"": ""Value"",
                    ""id"": ""71c1c15c-fd56-413d-82f4-96cfc054acfa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ClickAction"",
                    ""type"": ""Button"",
                    ""id"": ""51f1f7a6-f5d0-4252-a6df-3640a4d3f2cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveToAction"",
                    ""type"": ""Button"",
                    ""id"": ""0483aab8-67e2-4f08-91ff-0ef1032a8e01"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveCameraAction"",
                    ""type"": ""Value"",
                    ""id"": ""ddd9a834-9bf2-4e55-a615-e489996aad34"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MultiSelectAction"",
                    ""type"": ""Button"",
                    ""id"": ""7aaf8c15-29f2-46ea-bd01-ad7250831970"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""58edf562-5e46-438f-bc5e-b425b897e104"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold(duration=0.2)"",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""HoldAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cb2b303-86c7-45b0-9308-21bda520e9ee"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""CursorPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b6d2548-d005-475e-add1-7baa4db2a2d4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""ClickAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef9aee85-4ab7-4de2-b30f-fae46b4c9ac9"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""MoveToAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1cd964f0-436d-4f71-bcc2-9335fdc796ee"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCameraAction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b6a92fe3-6acf-4e71-a17b-71a9486daf4d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""MoveCameraAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""da87192b-6f4b-4bbe-9402-c15e4ff8c6ad"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCameraAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d3d6ed18-22cc-4aad-b658-833b47c7090b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""MoveCameraAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0345eb9c-096a-492f-945d-0fe938b683df"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""MoveCameraAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6356007e-c4c7-41b8-93e5-e5646ded05f7"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""MultiSelectAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MouseAndKeyboard"",
            ""bindingGroup"": ""MouseAndKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_HoldAction = m_UI.FindAction("HoldAction", throwIfNotFound: true);
        m_UI_CursorPosition = m_UI.FindAction("CursorPosition", throwIfNotFound: true);
        m_UI_ClickAction = m_UI.FindAction("ClickAction", throwIfNotFound: true);
        m_UI_MoveToAction = m_UI.FindAction("MoveToAction", throwIfNotFound: true);
        m_UI_MoveCameraAction = m_UI.FindAction("MoveCameraAction", throwIfNotFound: true);
        m_UI_MultiSelectAction = m_UI.FindAction("MultiSelectAction", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_HoldAction;
    private readonly InputAction m_UI_CursorPosition;
    private readonly InputAction m_UI_ClickAction;
    private readonly InputAction m_UI_MoveToAction;
    private readonly InputAction m_UI_MoveCameraAction;
    private readonly InputAction m_UI_MultiSelectAction;
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HoldAction => m_Wrapper.m_UI_HoldAction;
        public InputAction @CursorPosition => m_Wrapper.m_UI_CursorPosition;
        public InputAction @ClickAction => m_Wrapper.m_UI_ClickAction;
        public InputAction @MoveToAction => m_Wrapper.m_UI_MoveToAction;
        public InputAction @MoveCameraAction => m_Wrapper.m_UI_MoveCameraAction;
        public InputAction @MultiSelectAction => m_Wrapper.m_UI_MultiSelectAction;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @HoldAction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnHoldAction;
                @HoldAction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnHoldAction;
                @HoldAction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnHoldAction;
                @CursorPosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCursorPosition;
                @CursorPosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCursorPosition;
                @CursorPosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCursorPosition;
                @ClickAction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClickAction;
                @ClickAction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClickAction;
                @ClickAction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClickAction;
                @MoveToAction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveToAction;
                @MoveToAction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveToAction;
                @MoveToAction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveToAction;
                @MoveCameraAction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveCameraAction;
                @MoveCameraAction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveCameraAction;
                @MoveCameraAction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveCameraAction;
                @MultiSelectAction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMultiSelectAction;
                @MultiSelectAction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMultiSelectAction;
                @MultiSelectAction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMultiSelectAction;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HoldAction.started += instance.OnHoldAction;
                @HoldAction.performed += instance.OnHoldAction;
                @HoldAction.canceled += instance.OnHoldAction;
                @CursorPosition.started += instance.OnCursorPosition;
                @CursorPosition.performed += instance.OnCursorPosition;
                @CursorPosition.canceled += instance.OnCursorPosition;
                @ClickAction.started += instance.OnClickAction;
                @ClickAction.performed += instance.OnClickAction;
                @ClickAction.canceled += instance.OnClickAction;
                @MoveToAction.started += instance.OnMoveToAction;
                @MoveToAction.performed += instance.OnMoveToAction;
                @MoveToAction.canceled += instance.OnMoveToAction;
                @MoveCameraAction.started += instance.OnMoveCameraAction;
                @MoveCameraAction.performed += instance.OnMoveCameraAction;
                @MoveCameraAction.canceled += instance.OnMoveCameraAction;
                @MultiSelectAction.started += instance.OnMultiSelectAction;
                @MultiSelectAction.performed += instance.OnMultiSelectAction;
                @MultiSelectAction.canceled += instance.OnMultiSelectAction;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_MouseAndKeyboardSchemeIndex = -1;
    public InputControlScheme MouseAndKeyboardScheme
    {
        get
        {
            if (m_MouseAndKeyboardSchemeIndex == -1) m_MouseAndKeyboardSchemeIndex = asset.FindControlSchemeIndex("MouseAndKeyboard");
            return asset.controlSchemes[m_MouseAndKeyboardSchemeIndex];
        }
    }
    public interface IUIActions
    {
        void OnHoldAction(InputAction.CallbackContext context);
        void OnCursorPosition(InputAction.CallbackContext context);
        void OnClickAction(InputAction.CallbackContext context);
        void OnMoveToAction(InputAction.CallbackContext context);
        void OnMoveCameraAction(InputAction.CallbackContext context);
        void OnMultiSelectAction(InputAction.CallbackContext context);
    }
}
