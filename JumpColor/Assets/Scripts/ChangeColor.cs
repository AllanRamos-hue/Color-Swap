using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private enum Combinations
    {
        //Combinação de 2 cores
        c, c0,

        //Combinação de 3 cores
        c1, c2, c3, c4, c5, c6, 

        //Combinação de 4 cores
        c7, c8, c9, c10, c11, c12
    }

    private Combinations combination;

    public GameObject[] platforms;
    public PlayerController player;

    SpriteRenderer sr;

    void Start()
    {
        RandomCombination();
    }
    
    void Update()
    {
            switch (combination)
        {
            case Combinations.c:
               
                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 0)
                    {
                        sr.color = player.color1;
                    }

                    if (i == 1)
                    {
                        sr.color = player.color2;
                    }
                }

                break;

            case Combinations.c0:

                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 0)
                    {
                        sr.color = player.color2;
                    }

                    if (i == 1)
                    {
                        sr.color = player.color1;
                    }
                }

                break;

             
                //Combinação de 3 cores

            case Combinations.c1:
                
                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();
                   
                    if (i == 0)
                    {
                         sr.color = player.color1;
                    }

                    if (i == 1)
                    {
                        sr.color = player.color2;
                    }

                    if (i == 2)
                    {
                        sr.color = player.color3;
                    }
                }

                break;

            case Combinations.c2:

                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 0)
                    {
                        sr.color = player.color1;
                    }

                    if (i == 2)
                    {
                        sr.color = player.color2;
                    }

                    if (i == 1)
                    {
                        sr.color = player.color3;
                    }
                }

                break;

            case Combinations.c3:

                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 1)
                    {
                        sr.color = player.color1;
                    }

                    if (i == 0)
                    {
                        sr.color = player.color2;
                    }

                    if (i == 2)
                    {
                        sr.color = player.color3;
                    }
                }

                break;

            case Combinations.c4:

                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 1)
                    {
                        sr.color = player.color1;
                    }

                    if (i == 2)
                    {
                        sr.color = player.color2;
                    }

                    if (i == 0)
                    {
                        sr.color = player.color3;
                    }
                }

                break;

            case Combinations.c5:

                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 2)
                    {
                        sr.color = player.color1;
                    }

                    if (i == 0)
                    {
                        sr.color = player.color2;
                    }

                    if (i == 1)
                    {
                        sr.color = player.color3;
                    }
                }

                break;

            case Combinations.c6:

                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 2)
                    {
                        sr.color = player.color1;
                    }

                    if (i == 1)
                    {
                        sr.color = player.color2;
                    }

                    if (i == 0)
                    {
                        sr.color = player.color3;
                    }
                }

                break;
                
                //Começo das combinações com 4 cores
           
            case Combinations.c7:

                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 0)
                    {
                        sr.color = player.color1;
                    }

                    if (i == 1)
                    {
                        sr.color = player.color2;
                    }

                    if (i == 2)
                    {
                        sr.color = player.color3;
                    }

                    if(i == 3)
                    {
                        sr.color = player.color4;
                    }

                }

                break;

            case Combinations.c8:

                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 0)
                    {
                        sr.color = player.color1;
                    }

                    if (i == 1)
                    {
                        sr.color = player.color2;
                    }

                    if (i == 3)
                    {
                        sr.color = player.color4;
                    }

                    if (i == 2)
                    {
                        sr.color = player.color3;
                    }

                }

                break;

            case Combinations.c9:

                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 0)
                    {
                        sr.color = player.color1;
                    }

                    if (i == 2)
                    {
                        sr.color = player.color3;
                    }

                    if (i == 1)
                    {
                        sr.color = player.color2;
                    }

                    if (i == 3)
                    {
                        sr.color = player.color4;
                    }

                }

                break;

            case Combinations.c10:

                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 0)
                    {
                        sr.color = player.color1;
                    }

                    if (i == 2)
                    {
                        sr.color = player.color3;
                    }

                    if (i == 3)
                    {
                        sr.color = player.color4;
                    }

                    if (i == 1)
                    {
                        sr.color = player.color2;
                    }

                }

                break;


            case Combinations.c11:

                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 0)
                    {
                        sr.color = player.color1;
                    }

                    if (i == 3)
                    {
                        sr.color = player.color4;
                    }

                    if (i == 1)
                    {
                        sr.color = player.color2;
                    }

                    if (i == 2)
                    {
                        sr.color = player.color3;
                    }

                }

                break;

            case Combinations.c12:

                for (int i = 0; i < platforms.Length; i++)
                {
                    sr = platforms[i].GetComponent<SpriteRenderer>();

                    if (i == 0)
                    {
                        sr.color = player.color1;
                    }

                    if (i == 3)
                    {
                        sr.color = player.color4;
                    }

                    if (i == 2)
                    {
                        sr.color = player.color3;
                    }

                    if (i == 1)
                    {
                        sr.color = player.color2;
                    }

                }

                break;

        }
    }

    private void OnEnable()
    {
        RandomCombination();
    }

    void RandomCombination()
    {
        int randomNumber;

        randomNumber = Random.Range(0, 2);

        if (PlayerController.hasScored10)
        {
            randomNumber = Random.Range(2, 8);
        }
       
        if (PlayerController.hasScored25)
        {
            randomNumber = Random.Range(8, 14);
        }
       

        if (randomNumber == 0)
        {
            combination = Combinations.c;
        }

        if (randomNumber == 1)
        {
            combination = Combinations.c0;
        }

        if (randomNumber == 2)
        {
            combination = Combinations.c1;
        }

        if (randomNumber == 3)
        {
            combination = Combinations.c2;
        }

        if (randomNumber == 4)
        {
            combination = Combinations.c3;
        }

        if (randomNumber == 5)
        {
            combination = Combinations.c4;
        }

        if (randomNumber == 6)
        {
            combination = Combinations.c5;
        }

        if (randomNumber == 7)
        {
            combination = Combinations.c6;
        }

        if (randomNumber == 8)
        {
            combination = Combinations.c7;
        }

        if (randomNumber == 9)
        {
            combination = Combinations.c8;
        }

        if (randomNumber == 10)
        {
            combination = Combinations.c9;
        }

        if (randomNumber == 11)
        {
            combination = Combinations.c10;
        }

        if (randomNumber == 12)
        {
            combination = Combinations.c11;
        }

        if (randomNumber == 13)
        {
            combination = Combinations.c12;
        }
    }


}
