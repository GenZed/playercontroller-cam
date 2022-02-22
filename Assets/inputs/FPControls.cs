// GENERATED AUTOMATICALLY FROM 'Assets/inputs/FPControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @FPControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @FPControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FPControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay Controller"",
            ""id"": ""8caa6118-9d34-4cfb-a30f-2eb235157e4c"",
            ""actions"": [
                {
                    ""name"": ""Camera Look"",
                    ""type"": ""Value"",
                    ""id"": ""875a52e5-c62d-44a7-bf54-f0bdf21673c2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Player Move"",
                    ""type"": ""Value"",
                    ""id"": ""c20a3232-341c-4c55-a8fa-e53532da382a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""67a9a260-cc6f-4f77-b021-2c66bc44db0d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Camera Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""b9ed8dc3-08bd-488c-b3f9-d2d21c2ed4d4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""054fe7df-ae2d-42eb-ad11-1d8852533022"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9ba171de-66f1-4eb3-838e-eb25a7959494"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""23f72db6-6c91-467e-bc66-3709401ba718"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""51b37e92-fb1c-4b68-923e-f894dc6e86f7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""6bfe27a5-6f9b-49ac-b7e1-9d7b7db18652"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""33653317-0a25-468f-9acd-addfe28e24d5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""063a86ef-0fb9-4f3c-a90e-4677bc256e48"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""322c74af-6b14-4185-9e25-50867292b97d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bde28201-01f1-4e48-925b-5e8573b7e5ef"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay Controller
        m_GameplayController = asset.FindActionMap("Gameplay Controller", throwIfNotFound: true);
        m_GameplayController_CameraLook = m_GameplayController.FindAction("Camera Look", throwIfNotFound: true);
        m_GameplayController_PlayerMove = m_GameplayController.FindAction("Player Move", throwIfNotFound: true);
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

    // Gameplay Controller
    private readonly InputActionMap m_GameplayController;
    private IGameplayControllerActions m_GameplayControllerActionsCallbackInterface;
    private readonly InputAction m_GameplayController_CameraLook;
    private readonly InputAction m_GameplayController_PlayerMove;
    public struct GameplayControllerActions
    {
        private @FPControls m_Wrapper;
        public GameplayControllerActions(@FPControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraLook => m_Wrapper.m_GameplayController_CameraLook;
        public InputAction @PlayerMove => m_Wrapper.m_GameplayController_PlayerMove;
        public InputActionMap Get() { return m_Wrapper.m_GameplayController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayControllerActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayControllerActions instance)
        {
            if (m_Wrapper.m_GameplayControllerActionsCallbackInterface != null)
            {
                @CameraLook.started -= m_Wrapper.m_GameplayControllerActionsCallbackInterface.OnCameraLook;
                @CameraLook.performed -= m_Wrapper.m_GameplayControllerActionsCallbackInterface.OnCameraLook;
                @CameraLook.canceled -= m_Wrapper.m_GameplayControllerActionsCallbackInterface.OnCameraLook;
                @PlayerMove.started -= m_Wrapper.m_GameplayControllerActionsCallbackInterface.OnPlayerMove;
                @PlayerMove.performed -= m_Wrapper.m_GameplayControllerActionsCallbackInterface.OnPlayerMove;
                @PlayerMove.canceled -= m_Wrapper.m_GameplayControllerActionsCallbackInterface.OnPlayerMove;
            }
            m_Wrapper.m_GameplayControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraLook.started += instance.OnCameraLook;
                @CameraLook.performed += instance.OnCameraLook;
                @CameraLook.canceled += instance.OnCameraLook;
                @PlayerMove.started += instance.OnPlayerMove;
                @PlayerMove.performed += instance.OnPlayerMove;
                @PlayerMove.canceled += instance.OnPlayerMove;
            }
        }
    }
    public GameplayControllerActions @GameplayController => new GameplayControllerActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IGameplayControllerActions
    {
        void OnCameraLook(InputAction.CallbackContext context);
        void OnPlayerMove(InputAction.CallbackContext context);
    }
}
