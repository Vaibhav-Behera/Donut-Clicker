using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text clickstotaltext;
    public float o2;
    public float multiplier;
    public void start()
    {
        o2 = 0;
        multiplier = 1;
    }

    public void OnMouseDown()
    {
        o2 += multiplier;
        clickstotaltext.text = "Score :" + o2.ToString("0");
    }


    public void Buy(int num)
    {
        if(num == 1 && o2 >=25)
        {
            multiplier += 1;
            o2 -= 25;
        }
        if(num == 2 &&o2 >= 125)
        {
            multiplier += 10;
            o2 -= 125;
        }
        if(num == 3 && o2 >= 1500)
        {
            multiplier += 100;
           o2 -= 1500;
        }

    }

    public void QuitGame()
    {
        Application.Quit();
    }



}
