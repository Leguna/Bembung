//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/PlayerController/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""119b5764-53b2-4e8e-81a8-cef5822df6db"",
            ""actions"": [
                {
                    ""name"": ""Controller 1"",
                    ""type"": ""Button"",
                    ""id"": ""80118f96-9285-4299-aab1-46902c02410c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Controller 2"",
                    ""type"": ""Button"",
                    ""id"": ""db620031-8ad4-4a5f-aeab-fd473f4b4390"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Controller 3 Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""eff678c3-db91-4053-815f-caac78881e68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Controller 4 Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""570960db-ec0e-45b9-83c1-dee282c30f41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Controller 5 Horizontal 2"",
                    ""type"": ""Button"",
                    ""id"": ""21eaf597-6c5e-4107-bac4-ac35584ba338"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Controller 6 Vertical 2"",
                    ""type"": ""Button"",
                    ""id"": ""7d09fb27-e89d-4a8d-9f5e-6aa1d5497814"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""384634b7-bee1-48e9-b800-fdf4a09ba39b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""bcb4b287-4e05-4859-9345-dc3e811c724d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""9acfbbc5-a6fe-4ba0-ae7b-f0bf16a77066"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""718df4cf-9981-49d6-9e08-e791676fde64"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2035bf97-0e73-40ec-94e3-d69bfe0e4188"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f16812f-3a92-4737-a16d-b673aedc9706"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd76d554-c6d7-4a0e-9731-ac7c714a139a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""24ac585a-655f-42db-89b4-d50e48a2a39d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller 3 Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""70c77c62-60fc-46cc-b0fc-cab265bf61a1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 3 Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""37d180bc-4434-42b8-b68a-84a1c008a035"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 3 Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""e150754d-eaf5-4708-ac0c-0cebbf2d4f4b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 3 Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dec94a14-125a-4357-b773-6fa4691b3b12"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 3 Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""72e6500f-f58b-465c-b9cb-fee4820329f5"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 3 Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ae19a06b-0898-42e9-a75e-38674f92420e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 5 Horizontal 2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""99595b41-c51e-44d8-9ef6-24ea9b622ead"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 5 Horizontal 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""554567e6-75b5-4473-83f6-78aeb95aa393"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 5 Horizontal 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""c47015ed-02f9-4171-9d68-ab7d9eed43fa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 5 Horizontal 2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c584d138-e381-4937-8541-bdcf7350ba6b"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 5 Horizontal 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9323cf78-b1c8-4551-a49e-d6291d21abbd"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 5 Horizontal 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""1b8d0cae-ebeb-4ed8-ba97-9a683faad5db"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 6 Vertical 2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""72d3e1ac-8bc0-4bc2-a958-d92dbc693f48"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 6 Vertical 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e1259d75-a2c2-41f4-82dd-7f341fbeb4ad"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 6 Vertical 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""2aad3bfa-9b37-4f9b-8147-b523576ad06c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 6 Vertical 2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""62f2e676-532e-4426-ac8d-a567b550eaaa"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 6 Vertical 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0ecee8ab-48bd-4f9e-88c3-0fcbd3158a84"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 6 Vertical 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""7cb0eb05-c5ef-4d6b-a5c8-a7869ffaa257"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 4 Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0a11476e-7cb9-4db0-b9bf-ca2383b5def6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 4 Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""14f823d8-bcd1-42dc-b2f9-98d56d7fbc91"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 4 Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""be9c7a30-3aef-4609-82dc-908cb1758d6a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 4 Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9fa31ae7-3b2e-4bfd-b2c5-ec7dd7d8b4fd"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 4 Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6fbcd92b-526d-4397-9692-eec1750cf7a6"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Controller 4 Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5696d13a-8c18-4a11-b3de-ff9c9e83ed30"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11ed61fb-0b0d-474b-a493-8d896c87b9f6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ce00dab-283a-483a-b00d-f95f4181fa03"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8a6d1e0-3607-49ae-a040-e348c76aa78e"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""937b36b9-74e9-45d7-ad13-2379b6a6881a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fd504bd-d03d-43b1-9621-f7b7f86eb9be"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66af72eb-f82c-46b9-b647-6df7a229b574"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31dd2c62-0dda-4e70-b66d-3b81eb984aca"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BembungGamePlay"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""BembungGamePlay"",
            ""bindingGroup"": ""BembungGamePlay"",
            ""devices"": []
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Controller1 = m_Gameplay.FindAction("Controller 1", throwIfNotFound: true);
        m_Gameplay_Controller2 = m_Gameplay.FindAction("Controller 2", throwIfNotFound: true);
        m_Gameplay_Controller3Horizontal = m_Gameplay.FindAction("Controller 3 Horizontal", throwIfNotFound: true);
        m_Gameplay_Controller4Vertical = m_Gameplay.FindAction("Controller 4 Vertical", throwIfNotFound: true);
        m_Gameplay_Controller5Horizontal2 = m_Gameplay.FindAction("Controller 5 Horizontal 2", throwIfNotFound: true);
        m_Gameplay_Controller6Vertical2 = m_Gameplay.FindAction("Controller 6 Vertical 2", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_Confirm = m_Gameplay.FindAction("Confirm", throwIfNotFound: true);
        m_Gameplay_Back = m_Gameplay.FindAction("Back", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Controller1;
    private readonly InputAction m_Gameplay_Controller2;
    private readonly InputAction m_Gameplay_Controller3Horizontal;
    private readonly InputAction m_Gameplay_Controller4Vertical;
    private readonly InputAction m_Gameplay_Controller5Horizontal2;
    private readonly InputAction m_Gameplay_Controller6Vertical2;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_Confirm;
    private readonly InputAction m_Gameplay_Back;
    public struct GameplayActions
    {
        private @PlayerInput m_Wrapper;
        public GameplayActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Controller1 => m_Wrapper.m_Gameplay_Controller1;
        public InputAction @Controller2 => m_Wrapper.m_Gameplay_Controller2;
        public InputAction @Controller3Horizontal => m_Wrapper.m_Gameplay_Controller3Horizontal;
        public InputAction @Controller4Vertical => m_Wrapper.m_Gameplay_Controller4Vertical;
        public InputAction @Controller5Horizontal2 => m_Wrapper.m_Gameplay_Controller5Horizontal2;
        public InputAction @Controller6Vertical2 => m_Wrapper.m_Gameplay_Controller6Vertical2;
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputAction @Confirm => m_Wrapper.m_Gameplay_Confirm;
        public InputAction @Back => m_Wrapper.m_Gameplay_Back;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Controller1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController1;
                @Controller1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController1;
                @Controller1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController1;
                @Controller2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController2;
                @Controller2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController2;
                @Controller2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController2;
                @Controller3Horizontal.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController3Horizontal;
                @Controller3Horizontal.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController3Horizontal;
                @Controller3Horizontal.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController3Horizontal;
                @Controller4Vertical.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController4Vertical;
                @Controller4Vertical.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController4Vertical;
                @Controller4Vertical.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController4Vertical;
                @Controller5Horizontal2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController5Horizontal2;
                @Controller5Horizontal2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController5Horizontal2;
                @Controller5Horizontal2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController5Horizontal2;
                @Controller6Vertical2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController6Vertical2;
                @Controller6Vertical2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController6Vertical2;
                @Controller6Vertical2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnController6Vertical2;
                @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Confirm.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnConfirm;
                @Back.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBack;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Controller1.started += instance.OnController1;
                @Controller1.performed += instance.OnController1;
                @Controller1.canceled += instance.OnController1;
                @Controller2.started += instance.OnController2;
                @Controller2.performed += instance.OnController2;
                @Controller2.canceled += instance.OnController2;
                @Controller3Horizontal.started += instance.OnController3Horizontal;
                @Controller3Horizontal.performed += instance.OnController3Horizontal;
                @Controller3Horizontal.canceled += instance.OnController3Horizontal;
                @Controller4Vertical.started += instance.OnController4Vertical;
                @Controller4Vertical.performed += instance.OnController4Vertical;
                @Controller4Vertical.canceled += instance.OnController4Vertical;
                @Controller5Horizontal2.started += instance.OnController5Horizontal2;
                @Controller5Horizontal2.performed += instance.OnController5Horizontal2;
                @Controller5Horizontal2.canceled += instance.OnController5Horizontal2;
                @Controller6Vertical2.started += instance.OnController6Vertical2;
                @Controller6Vertical2.performed += instance.OnController6Vertical2;
                @Controller6Vertical2.canceled += instance.OnController6Vertical2;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_BembungGamePlaySchemeIndex = -1;
    public InputControlScheme BembungGamePlayScheme
    {
        get
        {
            if (m_BembungGamePlaySchemeIndex == -1) m_BembungGamePlaySchemeIndex = asset.FindControlSchemeIndex("BembungGamePlay");
            return asset.controlSchemes[m_BembungGamePlaySchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnController1(InputAction.CallbackContext context);
        void OnController2(InputAction.CallbackContext context);
        void OnController3Horizontal(InputAction.CallbackContext context);
        void OnController4Vertical(InputAction.CallbackContext context);
        void OnController5Horizontal2(InputAction.CallbackContext context);
        void OnController6Vertical2(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
    }
}
