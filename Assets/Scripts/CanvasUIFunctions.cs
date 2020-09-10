using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CanvasUIFunctions : MonoBehaviour
{
    [Header("Title Scene Properties", order = 0)]
    [Space(2f)]
    [Header("Intro Scene Properties", order = 1)]
    public Sprite[] spriteArray;
    public Image panelImage;
    public Color backgroundColor;
    public TMP_Text introText;
    [Header("Tutorial Scene Properties", order = 2)]
    [Space(2f)]
    [Header("Level01 Scene Properties", order = 3)]

    int introSequence;
    Scene currentScene;

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
        switch (currentScene.name)
        {
            case "00TitleScene":
                break;
            case "01IntroScene":
                panelImage.sprite = spriteArray[0];
                introText.text = "A whole unseen world exists right outside your very door...";
                break;
            case "02TutorialScene":
                break;
            case "03Level01Scene":
                break;
        }
    }

    public void SetIntroSequence()
    {
        introSequence++;
        switch (introSequence)
        {
            case 1:
                panelImage.sprite = spriteArray[1];
                introText.text = "Come see and...";
                break;
            case 2:
                introText.text = "Learn about the animals living around you\n\n" +
                    "Contribute to real research about biodiversity and ecology\n\n" +
                    "Become an ally to the creatures living in your backyard, school, and neighborhood\n\n" +
                    "Watch your animals grow\n\n" +
                    "Connect with other ally's and real wildlife researchers!";
                panelImage.sprite = null;
                panelImage.color = backgroundColor;
                break;
            case 3:
                introText.text = "OVERVIEW\n\n" +
                    "Title: Where's Rudy\n" +
                    "Platform: WebGL build\n" +
                    "Subject: Biology\n" +
                    "Sub Subject: Ecology\n" +
                    "Main Focus: Wildlife conservation\n" +
                    "Learning Level: Grades 6-12";
                panelImage.sprite = null;
                panelImage.color = backgroundColor;
                break;
            case 4:
                introText.text = "PROPOSED EDTECH SOLUTION\n\n" +
                    "Students in urban environments may find it difficult to relate to the course material\n" +
                    "when learning about wildlife conservation and ecology. To provide a connection\n" +
                    "between urban students and wildlife, I propose to develop an interactive simulation\n" +
                    "where students interact with a simulation of their local environments and watch\n" +
                    "how their actions affect animal populations and overall health of local ecosystems\n" +
                    "(using rodent poisons, littering, ect).";
                panelImage.sprite = null;
                panelImage.color = backgroundColor;
                break;
            case 5:
                introText.text = "COMPETING SOFTWARE REVIEW\n\n" +
                    "Zooniverse - Crowd sourced research initiative that involves volunteers sorting,\n" +
                    "identifying, and organizing data, uploaded by field researchers. Users can be\n" +
                    "anyone who creates an account on their website. Users can create classifications\n" +
                    "on data, be a beta tester on developing projects, or be a moderator for a project.\n\n" +

                    "eMammal - A web application available for citizen science, field research,\n" +
                    "and education. The core of activity within the entire application is identifying\n" +
                    "animals from camera trap footage. Teachers incorporate trail cameras into their\n" +
                    "class activities to encourage student engagement and participation\n" +
                    "for science, humanities, and ESL.\n\n" +

                    "The Pack - PC game, designed to teach computational thinking and environmental\n" +
                    "awareness. It is an open-world game where users create algorithms to restore\n" +
                    "a barren wasteland to a thriving ecosystem.";
                panelImage.sprite = null;
                panelImage.color = backgroundColor;
                break;
            case 6:
                introText.text = "COMPETING SOFTWARE SUGGESTED IMPROVEMENTS\n\n" +
                    "Gameplay and immersion - AR/VR interactives that allow the user to feel that\n" +
                    "he/she can experience wildlife on a more personal level.\n\n" +
                    "Engagement factors - More interactive ways to engage with the data,\n" +
                    "other participating users, and wildlife.\n\n" +
                    "Better accessibility - Users can implement the application from multiple devices,\n" +
                    "rather than at a desktop computer. Users should be able to use the application\n" +
                    "wherever they are so that they can get the most use out of the information offered\n" +
                    "within the application. The gameplay should also have portability so that users can\n" +
                    "remain engaged in their simulations whether or not they are in front of their computers.";
                panelImage.sprite = null;
                panelImage.color = backgroundColor;
                break;
            default:
                panelImage.sprite = null;
                panelImage.color = backgroundColor;
                break;
        }
    }
}
