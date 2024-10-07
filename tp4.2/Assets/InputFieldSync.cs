using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputFieldSync : MonoBehaviour
{
    public TMP_InputField keyboardInputField;

    public TMP_InputField targetInputField;
    public GameObject keyboard;

    void Start()
    {
        if (keyboardInputField != null)
        {
            keyboardInputField.onValueChanged.AddListener(UpdateTargetInputField);
        }
    }

    void UpdateTargetInputField(string newValue)
    {
        if (targetInputField != null)
        {
            targetInputField.text = newValue;
        }
    }

    void OnEnable()
    {
        keyboardInputField.onEndEdit.AddListener(UpdateTargetInputFieldOnEndEdit);
    }

    void UpdateTargetInputFieldOnEndEdit(string finalValue)
    {
        if (targetInputField != null)
        {
            targetInputField.text = finalValue;
        }
    }
    public void ShowKeyboard()
    {
        keyboard.gameObject.SetActive(true);
    }

    public void HideKeyboard()
    {

        keyboard.gameObject.SetActive(false);
    }
}