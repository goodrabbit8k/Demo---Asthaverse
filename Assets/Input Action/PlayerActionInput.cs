//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input Action/PlayerActionInput.inputactions
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

public partial class @PlayerActionInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActionInput"",
    ""maps"": [
        {
            ""name"": ""InputPlayerAction"",
            ""id"": ""d4ee359b-2cd3-4473-87c1-4692c2c35148"",
            ""actions"": [
                {
                    ""name"": ""Shooting"",
                    ""type"": ""Button"",
                    ""id"": ""a1a66122-41d9-44eb-bcb9-373f4612dc40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SilentKill"",
                    ""type"": ""Button"",
                    ""id"": ""7bdecdc9-0fd9-456e-8d18-b74c23c791e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangingWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""00348e2f-2196-4c42-a40d-c98ec9b89632"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""48981095-f568-4301-981c-8525f9220f63"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce50390c-ee25-4867-8064-458229c96c72"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SilentKill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1c05c04-dee4-44f3-9329-624685e571ec"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangingWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InputPlayerAction
        m_InputPlayerAction = asset.FindActionMap("InputPlayerAction", throwIfNotFound: true);
        m_InputPlayerAction_Shooting = m_InputPlayerAction.FindAction("Shooting", throwIfNotFound: true);
        m_InputPlayerAction_SilentKill = m_InputPlayerAction.FindAction("SilentKill", throwIfNotFound: true);
        m_InputPlayerAction_ChangingWeapon = m_InputPlayerAction.FindAction("ChangingWeapon", throwIfNotFound: true);
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

    // InputPlayerAction
    private readonly InputActionMap m_InputPlayerAction;
    private List<IInputPlayerActionActions> m_InputPlayerActionActionsCallbackInterfaces = new List<IInputPlayerActionActions>();
    private readonly InputAction m_InputPlayerAction_Shooting;
    private readonly InputAction m_InputPlayerAction_SilentKill;
    private readonly InputAction m_InputPlayerAction_ChangingWeapon;
    public struct InputPlayerActionActions
    {
        private @PlayerActionInput m_Wrapper;
        public InputPlayerActionActions(@PlayerActionInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shooting => m_Wrapper.m_InputPlayerAction_Shooting;
        public InputAction @SilentKill => m_Wrapper.m_InputPlayerAction_SilentKill;
        public InputAction @ChangingWeapon => m_Wrapper.m_InputPlayerAction_ChangingWeapon;
        public InputActionMap Get() { return m_Wrapper.m_InputPlayerAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputPlayerActionActions set) { return set.Get(); }
        public void AddCallbacks(IInputPlayerActionActions instance)
        {
            if (instance == null || m_Wrapper.m_InputPlayerActionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InputPlayerActionActionsCallbackInterfaces.Add(instance);
            @Shooting.started += instance.OnShooting;
            @Shooting.performed += instance.OnShooting;
            @Shooting.canceled += instance.OnShooting;
            @SilentKill.started += instance.OnSilentKill;
            @SilentKill.performed += instance.OnSilentKill;
            @SilentKill.canceled += instance.OnSilentKill;
            @ChangingWeapon.started += instance.OnChangingWeapon;
            @ChangingWeapon.performed += instance.OnChangingWeapon;
            @ChangingWeapon.canceled += instance.OnChangingWeapon;
        }

        private void UnregisterCallbacks(IInputPlayerActionActions instance)
        {
            @Shooting.started -= instance.OnShooting;
            @Shooting.performed -= instance.OnShooting;
            @Shooting.canceled -= instance.OnShooting;
            @SilentKill.started -= instance.OnSilentKill;
            @SilentKill.performed -= instance.OnSilentKill;
            @SilentKill.canceled -= instance.OnSilentKill;
            @ChangingWeapon.started -= instance.OnChangingWeapon;
            @ChangingWeapon.performed -= instance.OnChangingWeapon;
            @ChangingWeapon.canceled -= instance.OnChangingWeapon;
        }

        public void RemoveCallbacks(IInputPlayerActionActions instance)
        {
            if (m_Wrapper.m_InputPlayerActionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInputPlayerActionActions instance)
        {
            foreach (var item in m_Wrapper.m_InputPlayerActionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InputPlayerActionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InputPlayerActionActions @InputPlayerAction => new InputPlayerActionActions(this);
    public interface IInputPlayerActionActions
    {
        void OnShooting(InputAction.CallbackContext context);
        void OnSilentKill(InputAction.CallbackContext context);
        void OnChangingWeapon(InputAction.CallbackContext context);
    }
}
