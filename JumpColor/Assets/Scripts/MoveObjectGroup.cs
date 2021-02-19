using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectGroup : MonoBehaviour
{
    public Vector3 speed;
   
    [SerializeField] private List<Transform> objectsTransform;

    [SerializeField] private float width;



    private void Start()
    {
        StartCoroutine(IncreaseSpeed());

        int count;

        count = 0;

        while (count < 10)
        {
            count++;
            Debug.Log(count);
        }
    }

    void Update()
    {
        foreach (Transform obj in objectsTransform)
        {
            obj.Translate(speed * Time.deltaTime);

            if(obj.transform.position.y >= width * 2)
            { 
                obj.Translate(new Vector3(0, width * -4, 0));

                obj.gameObject.SetActive(true);
               
            }      
        }
    }

    IEnumerator IncreaseSpeed()
    {
        int randomIndex;
        
        while(true)
        {
            yield return new WaitForSeconds(12);
            
            randomIndex = Random.Range(1, 11);

            if(randomIndex >= 4)
            {
                speed.y = 4f;
            }

            speed.y = 3.5f;

            yield return new WaitForSeconds(8);

            if(randomIndex >= 4 )
            {
                speed.y = 2.75f;
            }
            else
                speed.y = 3f;
        }
       
    }


         
}