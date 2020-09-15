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
    public GameObject introImage;
    public GameObject backButton;
    public GameObject nextButton;
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
                introText.text = "Welcome to Bubble Sort in 3D!\n\n" +
                    "Learn computer science principles by interacting with 3D objects!";
                introImage.SetActive(true);
                backButton.SetActive(false);
                break;
            case "02TutorialScene":
                break;
            case "03Level01Scene":
                break;
        }
    }

    public void IntroSequenceBack()
    {
        introSequence = introSequence - 2;
        IntroSequenceNext();
    }

    public void IntroSequenceNext()
    {
        introSequence++;
        switch (introSequence)
        {
            case 0:
                introText.horizontalAlignment = HorizontalAlignmentOptions.Center;
                introText.text = "Welcome to Bubble Sort in 3D!\n\n" +
                    "Learn computer science principles by interacting with 3D objects!";
                introImage.SetActive(true);
                backButton.SetActive(false);
                break;
            case 1:
                introImage.SetActive(false);
                backButton.SetActive(true);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "OVERVIEW\n\n" +
                    "Title: Bubble Sort in 3D\n" +
                    "Platform: WebGL build\n" +
                    "Subject: Computer Science\n" +
                    "Sub Subject: Sorting Algorithms\n" +
                    "Main Focus: Bubble Sort\n" +
                    "Learning Level: Grades 6-12";
                break;
            case 2:
                introText.text = "PROPOSED EDTECH SOLUTION\n\n" +
                    "Students may find it difficult to relate to the course material when learning about abstract concepts such as sorting algorithms in computer science.To provide a connection between students and introductory computer science topics, I propose to develop an interactive simulation where students move through a 3D representation of a list and watch how their actions affect the order of the list visually as they learn a new sorting algorithm called bubble sort.";
                break;
            case 3:
                introText.text = "COMPETING SOFTWARE REVIEW\n\n" +
                    "Gidget - Gidget is a game designed to teach computer programming concepts through debugging puzzles. Gidget the robot was damaged on its way to clean up a chemical spill and save the animals, so it is the players' job to fix Gidget's problematic code to complete all the missions. As the levels become more challenging, players can combine newly introduced concepts with previously used commands to succeed solving the puzzles and progress through the game.\n\n" +
                    "Scratch - With Scratch, you can program your own interactive stories, games, animations, and share your creations with others in the online community.  Scratch helps young people learn to think creatively, reason systematically, and work collaboratively, which are essential skills for life in the 21st century.\n\n" +
                    "The Pack - PC game, designed to teach computational thinking and environmental awareness. It is an open-world game where users create algorithms to restore a barren wasteland to a thriving ecosystem.";
                break;
            case 4:
                introText.text = "COMPETING SOFTWARE SUGGESTED IMPROVEMENTS\n\n" +
                    "Gameplay and immersion - AR/VR interactives that allow the user to feel that he/she can experience wildlife on a more personal level.\n\n" +
                    "Engagement factors - More interactive ways to engage with the data, other participating users, and wildlife.\n\n" +
                    "Better accessibility - Users can implement the application from multiple devices, rather than at a desktop computer. Users should be able to use the application wherever they are so that they can get the most use out of the information offered within the application. The gameplay should also have portability so that users can remain engaged in their simulations whether or not they are in front of their computers.";
                break;
            case 5:
                introText.text = "STAKEHOLDERS\n\n" +
                    "Teachers\n" +
                    "Parents\n" +
                    "Students\n\n" +
                    "USERS\n\n" +
                    "6-12th grade middle school students";
                break;
            case 6:
                introText.text = "PERSONA\n\n" +
                    "Name: Connor\n" +
                    "Age: 13 years old\n" +
                    "Gender: Male\n" +
                    "Location: Suburbia USA\n" +
                    "Personal Notes:\n" +
                    "     Plays sports\n" +
                    "     Enjoys being outside and being active\n" +
                    "Students Notes:\n" +
                    "     Struggles with relating to the material in his science classes\n" +
                    "     Doesn't learn well from lecture and memorization\n" +
                    "     Prefers a visual/kinesthetic way of learning\n" +
                    "     Retains information best when presented as a hands-on or visual concept";
                break;
            case 7:
                introText.text = "PERSONA JUSTIFICATION\n\n" +
                    "After meeting with stakeholders and gathering information during the initial research phase, we settled on a persona named Connor. He represents the users of this educational application; a middle school student who needs more creative ways to learn concepts that are not familiar to him. I chose this persona because middle and high school is when students begin to learn complex concepts of math and sciences.\n\n";
                break;
            case 8:
                introText.text = "PROBLEM SCENARIO\n\n" +
                    "Connor is overwhelmed with his 8th grade computer science class. Connor has always been very active and social. He learns best by doing a task, rather than listening to directions. During the school year, the ability to actively participate in class lessons has been limited since the curriculum has become more abstract and complicated than he is used to. He is assigned some word and math problems through his lab computer, but cannot concentrate so he decides to slip out of class and play with another group of students during their recess at school.\n\n" +
                    "After a while, the teacher notices he is not at his computer. The teacher sees him through the window playing outside of his recess time. Connor gets sent to detention with extra homework to do on the computer. He is still not able to concentrate on the static images and text to read on the computer screen teaching introductory topics about computer science. He ends up getting frustrated and does not consider a future career in computer science.";
                break;
            case 9:
                introText.text = "ACTIVITY SCENARIO\n\n" +
                    "The next day, Connor’s computer science teacher tells the class that they will be starting to learn the first set of algorithms that a computer scientist learns, sorting algorithms. As he begins to feel overwhelmed, the teacher tells them that they are going to be using the new module via an interactive simulation. She shares a link to a website and instructs the class to begin filling out their profiles. Connor clicks on the link and after going through the intro, realizes that this module of his computer science class will be different from the others. He is relieved that he will be learning about the subject matter in an interactive way, similar to the games he plays at home.";
                break;
            case 10:
                nextButton.SetActive(true);
                introText.text = "ACTIVITY SCENARIO CONTINUED\n\n" +
                    "After Connor has been playing the simulation for about a week, he learns that sorting algorithms are very similar to things he does in real life.The simulation helped ground the abstract topic in physical reality and helped the student understand the material through interaction 3D visualizations that recreate aspects of real life in space and time.Connor is able to relate to the material in this module as he constructs a simulation of his environment and watches as each choice he makes changes something in the list and moves the list from chaos to order.He learns that the more sorted a list becomes, the easier it is to find a particular element or to understand the nature of the data in the list. He becomes interested in learning more about computer science and how it can help people make better sense of the world around them.";
                break;
            case 11:
                nextButton.SetActive(false);
                introText.text = "PROBLEM STATEMENT\n\n" +
                    "Connor is frustrated with the abstract nature of the math and sciences. He is an active person, and prefers to learn with visual and physical aids. He needs a way to relate to the material in his computer science class, where they are learning about math, logic, algorithms, and software engineering. To understand the importance of computer science to today’s knowledge based society, to educate himself about the academic and industrial applications of programming that computer science can open up for him. He learns the importance of computer science as he organizes lists that are represented as 3D visualizations to help ground the abstract principles in real life activities unfold according to his own input and actions.";
                break;
        }
    }
}
