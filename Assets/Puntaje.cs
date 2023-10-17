using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Puntaje : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int puntaje=0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text= puntaje.ToString()+" puntos";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectable"){
            puntaje = puntaje + 1;
            scoreText.text = puntaje.ToString()+ " puntos";
            Destroy(other.gameObject);
        }
    }
}
