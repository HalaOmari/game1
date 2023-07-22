// GENERATED AUTOMATICALLY FROM 'Assets/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e416557f-b807-4348-b0e5-5823119de5e6"",
            ""actions"": [
                {
                    ""name"": ""Camera Control"",
                    ""type"": ""Value"",
                    ""id"": ""2a2e391a-8852-46cf-8ae6-66b52bd7ac68"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1c232514-c7e3-4b6e-9cdd-4b278becbfcd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""bbc48cdc-db2a-4cfa-a002-576b40518941"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=2)""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d52b2d57-6c60-40fd-be43-bd2bb0e692cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=2)""
                },
                {
                    ""name"": ""Hit"",
                    ""type"": ""Button"",
                    ""id"": ""9487cf72-65df-4900-905b-b728e91313cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.1)""
                },
                {
                    ""name"": ""Eat"",
                    ""type"": ""Button"",
                    ""id"": ""16b0b4d5-e115-4d2e-b5bb-fcec4197ef44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.1)""
                },
                {
                    ""name"": ""Info"",
                    ""type"": ""Button"",
                    ""id"": ""c7d07d10-9cf3-4e0b-9320-b6c577274120"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""17c51c03-fde7-4a43-8966-c201b890d1aa"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Camera Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ff0ccd1-562b-4d22-9062-90248efedc85"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Camera Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""temp"",
                    ""id"": ""ffed52e7-4329-4f46-b437-a956b89a1ea9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Control"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""647d05e6-02bb-4548-a853-7ac78b9d75a7"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Camera Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8f820b3d-719e-4369-9312-82ef0db45451"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Camera Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8cdbc356-cd57-4bd6-8a5b-1859ae75be11"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Camera Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""495cb8e0-90ee-49ac-954c-08c70dfdcce8"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Camera Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2dc5dec5-6a6d-4a9c-8b5a-554535122b96"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Camera Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""2e115676-ebc7-4fd9-a89c-07d236b821a9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1cca33d3-8353-4808-86af-3ec644798435"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""148a73dc-e1bc-45e4-8876-8892651ade2e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""50cc711a-ff92-4b2e-9b3d-6391a0937e26"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9b0cb4da-3cc8-41f4-af37-e8c737a0023f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""35f7e0f4-2665-46c1-8ff2-04f9e53ef2de"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""15887cf3-c7d4-44fa-9dbc-990b863f77e0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""94bd86ea-64ea-43b4-ba52-4b0f0503d181"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dfde78fc-7869-4252-bddb-df663c1dbb8f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bdf6fd36-491f-433f-81c6-0a1832bedfe4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""25b9050a-504d-4c68-8e25-211e0fa8bf29"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fb2cd6b-1652-4c11-8702-ab922c1a31cd"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""299f1aa5-59a6-45cb-b0ce-0abae91c48f1"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ded46e61-d8ef-4d0f-b2d5-d79f58bea965"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e739529-0ca5-47ec-87a7-568ad31899a0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdfc3fed-990b-4e6d-b2a4-778bb2731ab6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82d31686-1796-44d6-8497-736d191ba32a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cef09342-f5af-430a-968e-38cf3d8aba12"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5af0c755-9b4c-421b-ace4-26ef325838b2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Eat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d31b037-3774-41d4-b9be-e9c97d49fe9b"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Eat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2154f7a-2ec9-4ab9-be85-82c7be519f67"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Info"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a887fdb-bf39-4faf-9d26-cbfea89c99ab"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Info"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Screens"",
            ""id"": ""06bbbdf7-d8ca-4573-bca4-03aec93cdc2d"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""2806a915-f1eb-437d-9a54-3dcf15c446c6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hover"",
                    ""type"": ""Value"",
                    ""id"": ""c4bcd336-7286-46f2-95d9-de1f4a2b61f5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""35280b92-30e8-43a6-b850-dc9f19790999"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastReset"",
                    ""type"": ""Button"",
                    ""id"": ""32c93ada-0089-4e11-bfa4-204557d8c5a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""17ad85ab-176d-43d5-9678-e9b826089345"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a087de0c-63e8-4b9f-b955-d9bc97dc2ba7"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3843b464-b5d2-414e-89a1-f0698439d945"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Hover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6333469-a2a4-469b-bdd1-2282353b785d"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05904ee5-67d0-4870-bc5c-04855b2ff06a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d240db9-4403-4755-90f3-44f28e511ac9"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0937d623-ed1b-4210-b6f5-df5bad53068d"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27485f64-314d-436f-a75a-83f5d42e6284"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""FastReset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Music"",
            ""id"": ""2b3ebe5d-6627-4c8f-8fa0-6a45d17f7988"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""352c17a4-dbe9-4fc0-9009-c92049e4256d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""ca6ad25d-612a-4b20-8bc2-60077938d024"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""C"",
                    ""type"": ""Button"",
                    ""id"": ""ddd22db1-640c-48a0-9b79-25bc7b2af808"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D"",
                    ""type"": ""Button"",
                    ""id"": ""c8dfd544-6aa4-4d15-8954-990326d51800"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""E"",
                    ""type"": ""Button"",
                    ""id"": ""3e718225-d04e-4570-9bcb-d27eb1f6226f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""F"",
                    ""type"": ""Button"",
                    ""id"": ""c0356ac8-d694-42ec-9472-15a1d26bf155"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""G"",
                    ""type"": ""Button"",
                    ""id"": ""735c00f8-d300-48b9-b10f-5345b61d19b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Play"",
                    ""type"": ""Button"",
                    ""id"": ""9f84e2f2-49d9-42b5-a267-3605b0e27b7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""47e08a28-0d3d-412a-9772-0ed69979e547"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99ede516-c803-400e-82f9-daebaf10885b"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7de8fc4-65bb-4fbf-b29f-aee6a8134b52"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85bafec9-4ab5-439f-ba9a-b9d6fd439c67"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53588884-b7f9-4a99-8dd6-928cbd4dd4ad"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""C"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef5436d6-587e-4b69-bfe1-8d6acec9a850"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""C"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffee2a9c-a636-41dd-b5d5-194b8f827ece"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f6714ce-e5f8-4b7e-b674-3875952487cb"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd995b48-79ea-4739-adc4-ac3fddf3c7eb"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""E"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fcb97f8-8848-4c81-9d6c-bb08326bde62"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""E"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af91edab-42b2-4f60-97d1-f8964f4ede50"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""F"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82e4ef95-e4ce-410d-b20b-887265496a5d"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""F"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fa336cd-be25-47c6-aefa-7651a464e2e4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""G"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2233061e-94fe-4956-8e91-7dad0d88c3e8"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""G"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ae0c993-85e4-4f1b-a866-456e03b88f77"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CastleRiddle"",
            ""id"": ""1596c14d-ea59-4527-9ef7-e114bfb76c83"",
            ""actions"": [
                {
                    ""name"": ""Change"",
                    ""type"": ""Button"",
                    ""id"": ""dede98b9-fec6-4d17-930c-e5375b5e5e3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d29a60ca-caed-4f25-b81a-2823f407abb1"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f3fedce-d024-4069-93d3-596cc757e868"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_CameraControl = m_Player.FindAction("Camera Control", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Hit = m_Player.FindAction("Hit", throwIfNotFound: true);
        m_Player_Eat = m_Player.FindAction("Eat", throwIfNotFound: true);
        m_Player_Info = m_Player.FindAction("Info", throwIfNotFound: true);
        // Screens
        m_Screens = asset.FindActionMap("Screens", throwIfNotFound: true);
        m_Screens_Select = m_Screens.FindAction("Select", throwIfNotFound: true);
        m_Screens_Hover = m_Screens.FindAction("Hover", throwIfNotFound: true);
        m_Screens_Pause = m_Screens.FindAction("Pause", throwIfNotFound: true);
        m_Screens_FastReset = m_Screens.FindAction("FastReset", throwIfNotFound: true);
        // Music
        m_Music = asset.FindActionMap("Music", throwIfNotFound: true);
        m_Music_A = m_Music.FindAction("A", throwIfNotFound: true);
        m_Music_B = m_Music.FindAction("B", throwIfNotFound: true);
        m_Music_C = m_Music.FindAction("C", throwIfNotFound: true);
        m_Music_D = m_Music.FindAction("D", throwIfNotFound: true);
        m_Music_E = m_Music.FindAction("E", throwIfNotFound: true);
        m_Music_F = m_Music.FindAction("F", throwIfNotFound: true);
        m_Music_G = m_Music.FindAction("G", throwIfNotFound: true);
        m_Music_Play = m_Music.FindAction("Play", throwIfNotFound: true);
        // CastleRiddle
        m_CastleRiddle = asset.FindActionMap("CastleRiddle", throwIfNotFound: true);
        m_CastleRiddle_Change = m_CastleRiddle.FindAction("Change", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_CameraControl;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Run;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Hit;
    private readonly InputAction m_Player_Eat;
    private readonly InputAction m_Player_Info;
    public struct PlayerActions
    {
        private @InputManager m_Wrapper;
        public PlayerActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraControl => m_Wrapper.m_Player_CameraControl;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Hit => m_Wrapper.m_Player_Hit;
        public InputAction @Eat => m_Wrapper.m_Player_Eat;
        public InputAction @Info => m_Wrapper.m_Player_Info;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @CameraControl.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraControl;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Run.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Hit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHit;
                @Hit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHit;
                @Hit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHit;
                @Eat.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEat;
                @Eat.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEat;
                @Eat.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEat;
                @Info.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInfo;
                @Info.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInfo;
                @Info.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInfo;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraControl.started += instance.OnCameraControl;
                @CameraControl.performed += instance.OnCameraControl;
                @CameraControl.canceled += instance.OnCameraControl;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Hit.started += instance.OnHit;
                @Hit.performed += instance.OnHit;
                @Hit.canceled += instance.OnHit;
                @Eat.started += instance.OnEat;
                @Eat.performed += instance.OnEat;
                @Eat.canceled += instance.OnEat;
                @Info.started += instance.OnInfo;
                @Info.performed += instance.OnInfo;
                @Info.canceled += instance.OnInfo;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Screens
    private readonly InputActionMap m_Screens;
    private IScreensActions m_ScreensActionsCallbackInterface;
    private readonly InputAction m_Screens_Select;
    private readonly InputAction m_Screens_Hover;
    private readonly InputAction m_Screens_Pause;
    private readonly InputAction m_Screens_FastReset;
    public struct ScreensActions
    {
        private @InputManager m_Wrapper;
        public ScreensActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_Screens_Select;
        public InputAction @Hover => m_Wrapper.m_Screens_Hover;
        public InputAction @Pause => m_Wrapper.m_Screens_Pause;
        public InputAction @FastReset => m_Wrapper.m_Screens_FastReset;
        public InputActionMap Get() { return m_Wrapper.m_Screens; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ScreensActions set) { return set.Get(); }
        public void SetCallbacks(IScreensActions instance)
        {
            if (m_Wrapper.m_ScreensActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_ScreensActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_ScreensActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_ScreensActionsCallbackInterface.OnSelect;
                @Hover.started -= m_Wrapper.m_ScreensActionsCallbackInterface.OnHover;
                @Hover.performed -= m_Wrapper.m_ScreensActionsCallbackInterface.OnHover;
                @Hover.canceled -= m_Wrapper.m_ScreensActionsCallbackInterface.OnHover;
                @Pause.started -= m_Wrapper.m_ScreensActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_ScreensActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_ScreensActionsCallbackInterface.OnPause;
                @FastReset.started -= m_Wrapper.m_ScreensActionsCallbackInterface.OnFastReset;
                @FastReset.performed -= m_Wrapper.m_ScreensActionsCallbackInterface.OnFastReset;
                @FastReset.canceled -= m_Wrapper.m_ScreensActionsCallbackInterface.OnFastReset;
            }
            m_Wrapper.m_ScreensActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Hover.started += instance.OnHover;
                @Hover.performed += instance.OnHover;
                @Hover.canceled += instance.OnHover;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @FastReset.started += instance.OnFastReset;
                @FastReset.performed += instance.OnFastReset;
                @FastReset.canceled += instance.OnFastReset;
            }
        }
    }
    public ScreensActions @Screens => new ScreensActions(this);

    // Music
    private readonly InputActionMap m_Music;
    private IMusicActions m_MusicActionsCallbackInterface;
    private readonly InputAction m_Music_A;
    private readonly InputAction m_Music_B;
    private readonly InputAction m_Music_C;
    private readonly InputAction m_Music_D;
    private readonly InputAction m_Music_E;
    private readonly InputAction m_Music_F;
    private readonly InputAction m_Music_G;
    private readonly InputAction m_Music_Play;
    public struct MusicActions
    {
        private @InputManager m_Wrapper;
        public MusicActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_Music_A;
        public InputAction @B => m_Wrapper.m_Music_B;
        public InputAction @C => m_Wrapper.m_Music_C;
        public InputAction @D => m_Wrapper.m_Music_D;
        public InputAction @E => m_Wrapper.m_Music_E;
        public InputAction @F => m_Wrapper.m_Music_F;
        public InputAction @G => m_Wrapper.m_Music_G;
        public InputAction @Play => m_Wrapper.m_Music_Play;
        public InputActionMap Get() { return m_Wrapper.m_Music; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MusicActions set) { return set.Get(); }
        public void SetCallbacks(IMusicActions instance)
        {
            if (m_Wrapper.m_MusicActionsCallbackInterface != null)
            {
                @A.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnB;
                @C.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnC;
                @C.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnC;
                @C.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnC;
                @D.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnD;
                @D.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnD;
                @D.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnD;
                @E.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnE;
                @E.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnE;
                @E.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnE;
                @F.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnF;
                @F.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnF;
                @F.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnF;
                @G.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnG;
                @G.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnG;
                @G.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnG;
                @Play.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnPlay;
                @Play.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnPlay;
                @Play.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnPlay;
            }
            m_Wrapper.m_MusicActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @C.started += instance.OnC;
                @C.performed += instance.OnC;
                @C.canceled += instance.OnC;
                @D.started += instance.OnD;
                @D.performed += instance.OnD;
                @D.canceled += instance.OnD;
                @E.started += instance.OnE;
                @E.performed += instance.OnE;
                @E.canceled += instance.OnE;
                @F.started += instance.OnF;
                @F.performed += instance.OnF;
                @F.canceled += instance.OnF;
                @G.started += instance.OnG;
                @G.performed += instance.OnG;
                @G.canceled += instance.OnG;
                @Play.started += instance.OnPlay;
                @Play.performed += instance.OnPlay;
                @Play.canceled += instance.OnPlay;
            }
        }
    }
    public MusicActions @Music => new MusicActions(this);

    // CastleRiddle
    private readonly InputActionMap m_CastleRiddle;
    private ICastleRiddleActions m_CastleRiddleActionsCallbackInterface;
    private readonly InputAction m_CastleRiddle_Change;
    public struct CastleRiddleActions
    {
        private @InputManager m_Wrapper;
        public CastleRiddleActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Change => m_Wrapper.m_CastleRiddle_Change;
        public InputActionMap Get() { return m_Wrapper.m_CastleRiddle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CastleRiddleActions set) { return set.Get(); }
        public void SetCallbacks(ICastleRiddleActions instance)
        {
            if (m_Wrapper.m_CastleRiddleActionsCallbackInterface != null)
            {
                @Change.started -= m_Wrapper.m_CastleRiddleActionsCallbackInterface.OnChange;
                @Change.performed -= m_Wrapper.m_CastleRiddleActionsCallbackInterface.OnChange;
                @Change.canceled -= m_Wrapper.m_CastleRiddleActionsCallbackInterface.OnChange;
            }
            m_Wrapper.m_CastleRiddleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Change.started += instance.OnChange;
                @Change.performed += instance.OnChange;
                @Change.canceled += instance.OnChange;
            }
        }
    }
    public CastleRiddleActions @CastleRiddle => new CastleRiddleActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnCameraControl(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnHit(InputAction.CallbackContext context);
        void OnEat(InputAction.CallbackContext context);
        void OnInfo(InputAction.CallbackContext context);
    }
    public interface IScreensActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnHover(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnFastReset(InputAction.CallbackContext context);
    }
    public interface IMusicActions
    {
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnC(InputAction.CallbackContext context);
        void OnD(InputAction.CallbackContext context);
        void OnE(InputAction.CallbackContext context);
        void OnF(InputAction.CallbackContext context);
        void OnG(InputAction.CallbackContext context);
        void OnPlay(InputAction.CallbackContext context);
    }
    public interface ICastleRiddleActions
    {
        void OnChange(InputAction.CallbackContext context);
    }
}
