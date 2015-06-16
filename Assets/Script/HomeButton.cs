using UnityEngine;
using System.Collections;

public class HomeButton : MonoBehaviour
{

    public void Home()
    {
        Application.LoadLevel("Mainmenu");
    }
}
