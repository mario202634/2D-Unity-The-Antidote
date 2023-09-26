using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationController : MonoBehaviour
{
    public void GoToIntoScene()
    {
       Application.LoadLevel(0);
    }
    public void GoToGameOverScene()
    {
       Application.LoadLevel(1);
    }
    public void GoToVictoryScene()
    {
        Application.LoadLevel(2);
    }
    public void GoToLevelSelect()
    {
        Application.LoadLevel(3);
    }
    public void GoToNewGame()
    {
       Application.LoadLevel(4);
       //LoadLevelAsync ab2a agrbo
    }
    public void GoToLoneTwo()
    {
        Application.LoadLevel(5);
    }
    public void GoToLtwoOne()
    {
        Application.LoadLevel(6);
    }
    public void GoToLtwoTwo()
    {
        Application.LoadLevel(7);
    }
    public void GoToLthreeOne()
    {
        Application.LoadLevel(8);
    }
    public void GoToLthreeTwo()
    {
        Application.LoadLevel(9);
    }
    public void GoToSceneOne()
    {
        Application.LoadLevel(14);
    }
    public void GoToSceneTwo()
    {
        Application.LoadLevel(9);
    }
    public void GoToSceneThree()
    {
        Application.LoadLevel(11);
    }
    public void GoToSceneFour()
    {
        Application.LoadLevel(13);
    }
    public void SelectLevel1()
    {
        Application.LoadLevel(16);
    }
    public void SelectLevel2()
    {
        Application.LoadLevel(17);
    }
    public void SelectLevel3()
    {
        Application.LoadLevel(18);
    }
    public void QuestionTutorial()
    {
        Application.LoadLevel(19); 
    }
    public void TutorialLevel()
    {
        Application.LoadLevel(2); 
    }
    public void IntroCredit()
    {
        Application.LoadLevel(20);
    }
    public void EndCredit()
    {
        Application.LoadLevel(21);
    }

    public void Quit()
    {
        Application.Quit();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}