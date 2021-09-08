using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour
{
   
   
      public int indice = 1;
      public float vectorX = 0.1f;
      public int variacao = 1;

       void alternate(){
            indice += variacao;
            if (indice == 100){vectorX *= -1; variacao *= -1;};
            if (indice == 0){vectorX *= -1; variacao *= -1;};

            transform.Translate(new Vector3(vectorX,0,0));
            // transform.Rotate(new Vector3(0,0,vectorX));
            // transform.localScale += new Vector3(vectorX, vectorX, 0);

            // print(indice);
		// print(vectorX);
          }
    

    void Start(){
    }

   
    void Update()
    {
        alternate();
     }
}
