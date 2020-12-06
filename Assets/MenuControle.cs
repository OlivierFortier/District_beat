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
                    ""name"": ""entrer"",
                    ""type"": ""Button"",
                    ""id"": ""54bf0e7e-5336-428e-8919-178b7c68d717"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
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
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""4e81c95a-cf2b-49e7-8020-2bc770896dc9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""select"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""12e93d37-6fdb-413a-abc5-49ea2af294ce"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""778965bd-4a60-4379-9aa9-7e5f79cc459c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""00b47859-bbc6-4e35-aa92-8e2bef1c014d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""select"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4f163d76-3e22-4964-8f73-ca140b0592c0"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""21018d1d-a9c8-4bf1-941a-35b5f8567e23"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e4d41ab3-85b4-4da3-82cc-a1803f5a8d1c"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""entrer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0652da6-27e7-4da0-b65c-acc42388454b"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""entrer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d19f0956-4151-48f6-b7df-b5384cb1fd6d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""entrer"",
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
        m_menu_entrer = m_menu.FindAction("entrer", throwIfNotFound: true);
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
    private readonly InputAction m_menu_entrer;
    public struct MenuActions
    {
        private @MenuControle m_Wrapper;
        public MenuActions(@MenuControle wrapper) { m_Wrapper = wrapper; }
        public InputAction @select => m_Wrapper.m_menu_select;
        public InputAction @entrer => m_Wrapper.m_menu_entrer;
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
                @entrer.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnEntrer;
                @entrer.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnEntrer;
                @entrer.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnEntrer;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @select.started += instance.OnSelect;
                @select.performed += instance.OnSelect;
                @select.canceled += instance.OnSelect;
                @entrer.started += instance.OnEntrer;
                @entrer.performed += instance.OnEntrer;
                @entrer.canceled += instance.OnEntrer;
            }
        }
    }
    public MenuActions @menu => new MenuActions(this);
    public interface IMenuActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnEntrer(InputAction.CallbackContext context);
    }
}
