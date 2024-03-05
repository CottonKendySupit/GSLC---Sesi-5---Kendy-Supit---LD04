using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField emailInputField;
    public InputField passwordInputField;
    public Button loginButton;

    private string correctEmail = "binus@binus.edu";
    private string correctPassword = "12345";

    private void start()
    {
        loginButton.onClick.AddListener(OnLoginButtonClick);
    }

    private void OnLoginButtonClick()
    {
        string email = emailInputField.text;
        string password = passwordInputField.text;

        if (email == correctEmail && password == correctPassword)
        {
            Debug.Log("Login Successful!");
            Application.Quit();
        }
        else
        {
            Debug.Log("Email or Password Wrong!");
        }
    }

}
