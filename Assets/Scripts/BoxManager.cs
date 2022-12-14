using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


/// <summary>
/// After Sphere is droped into any boxes this script shows the UI for it and prepares for furthur changes
/// every Box has child gameobject that contains visual effects and for box C it has additional script regarding to reset to Sphere Level
/// if box A || B >>> just resets the scene after 5 secs
/// if box C >>> invokes the BoxCFunc() method 
/// </summary>

public class BoxManager : MonoBehaviour
{
    [SerializeField] private GameObject boxAChild, boxBChild, boxCChild, boxCanvas;
    [SerializeField] private TextMeshProUGUI txtUI;
    private int boxNumber = 0;
    private bool flag = true;
    private void Update()
    {
        boxNumber = StaticVariables.isSphereHitBox;
        if (boxNumber > 0 && flag)
        {
            boxCanvas.SetActive(true);
            switch (boxNumber)
            {
                case 1: //Box A
                    boxAChild.SetActive(true);
                    txtUI.SetText("You Have Dropped In\nBox A");
                    Invoke(nameof(ResetLevel), 5);
                    flag = false;
                    break;
                case 2: //Box B
                    boxBChild.SetActive(true);
                    txtUI.SetText("You Have Dropped In\nBox B");
                    Invoke(nameof(ResetLevel), 5);
                    flag = false;
                    break;
                case 3: //Box C
                    boxCChild.SetActive(true);
                    txtUI.SetText("You Have Dropped In\nBox C");
                    Invoke(nameof(BoxCFunc), 3);
                    flag = false;
                    break;
            }
        }
    }

    private void ResetLevel() //Reset the level
    {
        StaticVariables.isSphereHitBox = 0;
        SceneManager.LoadScene(0);
    }
    private void BoxCFunc() //resets values that are needed afterwards
    {
        StaticVariables.isSphereHitBox = 0;
        flag = true;
    }
}
