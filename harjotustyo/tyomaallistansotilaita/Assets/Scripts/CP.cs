using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CP : MonoBehaviour
{
        public float laptime;
        private bool startTimer = false;

        private bool cp2 = false;

        public UnityEngine.UI.Text Ltime;

        void Update()
        {
                if(startTimer == true){
                    laptime = laptime + Time.deltaTime; 
                      

                       Ltime.text = "Time : " + laptime.ToString("F3");
                }      

        }
 private void OnTriggerEnter(Collider other)
 {
       
               if (other.gameObject.name == "Start")  
             {
                   startTimer = true;  
             } 
              if (other.gameObject.name == "Finish")  
             {
                   startTimer = false;  
             }
              
            


                
        
 }
}
