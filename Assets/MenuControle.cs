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
        },
        {
            ""name"": ""jeux"",
            ""id"": ""0770b177-609f-4cd5-b2ad-b048ac694aca"",
            ""actions"": [
                {
                    ""name"": ""deplace"",
                    ""type"": ""Button"",
                    ""id"": ""2b2dc154-79a8-449f-95df-509fbc1c0446"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""attaque mele"",
                    ""type"": ""Button"",
                    ""id"": ""07ad1914-15c6-47f0-917e-5ecc4741c0ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""attaque distance"",
                    ""type"": ""Button"",
                    ""id"": ""4dc4d037-a277-4c06-8e0c-ccb5e060acc0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""roulade"",
                    ""type"": ""Button"",
                    ""id"": ""3ed1b6db-d24b-48c9-bafe-f7682b07977f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d0f4c0a6-f171-46ca-abf4-c772f66b2a53"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deplace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fd8f0829-608d-4d27-a7b4-65e4cf01a66a"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deplace"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""261a0eca-ae5e-44be-9dde-67dd07334d53"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deplace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d87ce35b-6264-4a02-a202-ee680b04d82e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deplace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c7f1f9ff-0abf-4938-ab2d-952ebd920a05"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deplace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""647da641-ff79-4ff7-8e56-98ad0317d521"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deplace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4b450cc5-103a-4f36-a8f2-3f189b23d303"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deplace"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bd6de26f-07bf-4207-bc23-2871b58ba9ba"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deplace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f57964c8-8100-4d0c-92cf-980fa9986b1b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deplace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cc7f0bff-fae8-418e-806e-485f70a9c623"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deplace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ceab89f1-5b9b-4425-a677-53eda0df8fd7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deplace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4c64718c-ab68-46e0-a287-a7c8907b11e6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attaque mele"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f0ad634-3bc3-49d5-8922-84e308deef45"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attaque mele"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""613f14af-b182-4a95-86e9-93e4e3617205"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attaque distance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ec4f75d-9a6c-4d50-9055-947bf4043037"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attaque distance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52743a23-952e-4c35-a58e-a52f174e9356"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""roulade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd0ea4df-3778-4c44-a18c-37b472d4c8e8"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""roulade"",
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
        // jeux
        m_jeux = asset.FindActionMap("jeux", throwIfNotFound: true);
        m_jeux_deplace = m_jeux.FindAction("deplace", throwIfNotFound: true);
        m_jeux_attaquemele = m_jeux.FindAction("attaque mele", throwIfNotFound: true);
        m_jeux_attaquedistance = m_jeux.FindAction("attaque distance", throwIfNotFound: true);
        m_jeux_roulade = m_jeux.FindAction("roulade", throwIfNotFound: true);
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

    // jeux
    private readonly InputActionMap m_jeux;
    private IJeuxActions m_JeuxActionsCallbackInterface;
    private readonly InputAction m_jeux_deplace;
    private readonly InputAction m_jeux_attaquemele;
    private readonly InputAction m_jeux_attaquedistance;
    private readonly InputAction m_jeux_roulade;
    public struct JeuxActions
    {
        private @MenuControle m_Wrapper;
        public JeuxActions(@MenuControle wrapper) { m_Wrapper = wrapper; }
        public InputAction @deplace => m_Wrapper.m_jeux_deplace;
        public InputAction @attaquemele => m_Wrapper.m_jeux_attaquemele;
        public InputAction @attaquedistance => m_Wrapper.m_jeux_attaquedistance;
        public InputAction @roulade => m_Wrapper.m_jeux_roulade;
        public InputActionMap Get() { return m_Wrapper.m_jeux; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JeuxActions set) { return set.Get(); }
        public void SetCallbacks(IJeuxActions instance)
        {
            if (m_Wrapper.m_JeuxActionsCallbackInterface != null)
            {
                @deplace.started -= m_Wrapper.m_JeuxActionsCallbackInterface.OnDeplace;
                @deplace.performed -= m_Wrapper.m_JeuxActionsCallbackInterface.OnDeplace;
                @deplace.canceled -= m_Wrapper.m_JeuxActionsCallbackInterface.OnDeplace;
                @attaquemele.started -= m_Wrapper.m_JeuxActionsCallbackInterface.OnAttaquemele;
                @attaquemele.performed -= m_Wrapper.m_JeuxActionsCallbackInterface.OnAttaquemele;
                @attaquemele.canceled -= m_Wrapper.m_JeuxActionsCallbackInterface.OnAttaquemele;
                @attaquedistance.started -= m_Wrapper.m_JeuxActionsCallbackInterface.OnAttaquedistance;
                @attaquedistance.performed -= m_Wrapper.m_JeuxActionsCallbackInterface.OnAttaquedistance;
                @attaquedistance.canceled -= m_Wrapper.m_JeuxActionsCallbackInterface.OnAttaquedistance;
                @roulade.started -= m_Wrapper.m_JeuxActionsCallbackInterface.OnRoulade;
                @roulade.performed -= m_Wrapper.m_JeuxActionsCallbackInterface.OnRoulade;
                @roulade.canceled -= m_Wrapper.m_JeuxActionsCallbackInterface.OnRoulade;
            }
            m_Wrapper.m_JeuxActionsCallbackInterface = instance;
            if (instance != null)
            {
                @deplace.started += instance.OnDeplace;
                @deplace.performed += instance.OnDeplace;
                @deplace.canceled += instance.OnDeplace;
                @attaquemele.started += instance.OnAttaquemele;
                @attaquemele.performed += instance.OnAttaquemele;
                @attaquemele.canceled += instance.OnAttaquemele;
                @attaquedistance.started += instance.OnAttaquedistance;
                @attaquedistance.performed += instance.OnAttaquedistance;
                @attaquedistance.canceled += instance.OnAttaquedistance;
                @roulade.started += instance.OnRoulade;
                @roulade.performed += instance.OnRoulade;
                @roulade.canceled += instance.OnRoulade;
            }
        }
    }
    public JeuxActions @jeux => new JeuxActions(this);
    public interface IMenuActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnEntrer(InputAction.CallbackContext context);
    }
    public interface IJeuxActions
    {
        void OnDeplace(InputAction.CallbackContext context);
        void OnAttaquemele(InputAction.CallbackContext context);
        void OnAttaquedistance(InputAction.CallbackContext context);
        void OnRoulade(InputAction.CallbackContext context);
    }
}
