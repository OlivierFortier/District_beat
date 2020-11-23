// GENERATED AUTOMATICALLY FROM 'Assets/MenuControle.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MenuControle : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MenuControle()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MenuControle"",
    ""maps"": [
        {
            ""name"": ""menu"",
            ""id"": ""312d8c4a-f7f6-41af-9118-9f9f71e5b5d9"",
            ""actions"": [
                {
                    ""name"": ""select"",
                    ""type"": ""Button"",
                    ""id"": ""8c0129fe-2f3b-4ad9-89e8-0a8155d8a5fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""perso select"",
                    ""type"": ""Button"",
                    ""id"": ""7db6b540-7ca7-498f-909b-6393005efbf8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9502958b-ba7b-4a40-bf29-c2892f787a00"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""perso select"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ae05782a-0a48-4a82-bf8f-dea839897a9a"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""perso select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""aa97eba8-a622-4c82-973c-42c62fa7fb9a"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""perso select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e3e5dae4-0c77-4660-a03f-bbbdf485eb84"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""perso select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a233144a-713e-494a-b83c-132f0d0e7467"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""perso select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""151b0788-17db-4cf5-8c2a-958900c57d95"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""select"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""616ad1a7-f449-410e-8902-c34c07fe3c1f"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""18cb9597-7e6a-40d2-b228-c712ecc5a585"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""joindre"",
            ""id"": ""e3cfd9f3-af39-4a37-91e8-2aac6d5d7c04"",
            ""actions"": [
                {
                    ""name"": ""joindre"",
                    ""type"": ""Button"",
                    ""id"": ""c602511e-5d3c-438d-a1b0-83b62dbfe734"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26f99f9f-0eda-42d6-99c4-ad690bccdada"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""joindre"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1793994f-e050-43c2-b225-9d188ab15b1b"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""joindre"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // menu
        m_menu = asset.FindActionMap("menu", throwIfNotFound: true);
        m_menu_select = m_menu.FindAction("select", throwIfNotFound: true);
        m_menu_persoselect = m_menu.FindAction("perso select", throwIfNotFound: true);
        // joindre
        m_joindre = asset.FindActionMap("joindre", throwIfNotFound: true);
        m_joindre_joindre = m_joindre.FindAction("joindre", throwIfNotFound: true);
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

    // menu
    private readonly InputActionMap m_menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_menu_select;
    private readonly InputAction m_menu_persoselect;
    public struct MenuActions
    {
        private @MenuControle m_Wrapper;
        public MenuActions(@MenuControle wrapper) { m_Wrapper = wrapper; }
        public InputAction @select => m_Wrapper.m_menu_select;
        public InputAction @persoselect => m_Wrapper.m_menu_persoselect;
        public InputActionMap Get() { return m_Wrapper.m_menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @select.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @select.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @select.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @persoselect.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPersoselect;
                @persoselect.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPersoselect;
                @persoselect.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPersoselect;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @select.started += instance.OnSelect;
                @select.performed += instance.OnSelect;
                @select.canceled += instance.OnSelect;
                @persoselect.started += instance.OnPersoselect;
                @persoselect.performed += instance.OnPersoselect;
                @persoselect.canceled += instance.OnPersoselect;
            }
        }
    }
    public MenuActions @menu => new MenuActions(this);

    // joindre
    private readonly InputActionMap m_joindre;
    private IJoindreActions m_JoindreActionsCallbackInterface;
    private readonly InputAction m_joindre_joindre;
    public struct JoindreActions
    {
        private @MenuControle m_Wrapper;
        public JoindreActions(@MenuControle wrapper) { m_Wrapper = wrapper; }
        public InputAction @joindre => m_Wrapper.m_joindre_joindre;
        public InputActionMap Get() { return m_Wrapper.m_joindre; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JoindreActions set) { return set.Get(); }
        public void SetCallbacks(IJoindreActions instance)
        {
            if (m_Wrapper.m_JoindreActionsCallbackInterface != null)
            {
                @joindre.started -= m_Wrapper.m_JoindreActionsCallbackInterface.OnJoindre;
                @joindre.performed -= m_Wrapper.m_JoindreActionsCallbackInterface.OnJoindre;
                @joindre.canceled -= m_Wrapper.m_JoindreActionsCallbackInterface.OnJoindre;
            }
            m_Wrapper.m_JoindreActionsCallbackInterface = instance;
            if (instance != null)
            {
                @joindre.started += instance.OnJoindre;
                @joindre.performed += instance.OnJoindre;
                @joindre.canceled += instance.OnJoindre;
            }
        }
    }
    public JoindreActions @joindre => new JoindreActions(this);
    public interface IMenuActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnPersoselect(InputAction.CallbackContext context);
    }
    public interface IJoindreActions
    {
        void OnJoindre(InputAction.CallbackContext context);
    }
}
