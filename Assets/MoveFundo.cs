using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;   

public class MoveFundo : MonoBehaviour
{
    public float vel = 1000.0f;
    public float vel2 = 0.1f;
    public Renderer quad;

    public Vector2 mainOffsetAnterior = new Vector2(1.1f , 2.2f);

    public float[] testaimen = new float[2]{2,4};

    // public static void printfloat(Vector2 Testaimen){
    //     print(mainOffsetAnterior*5.0f);
    // }


    void Start(){
        
      
    }
        
    
    void Update()
    {
        //movimentar sozinho
        // Vector2 offset = new Vector2(vel * Time.deltaTime, 0); 
        // quad.material.mainTextureOffset += offset;

        Vector2 lateralOffset = new Vector2(vel * Time.deltaTime, 0);
        Vector2 lateralOffset2 = new Vector2(vel2 * Time.deltaTime, 0);
        Vector2 verticalOffset = new Vector2(0, Time.deltaTime * vel);
        

        if(Input.GetKey(KeyCode.LeftArrow)){
        quad.material.mainTextureOffset += lateralOffset;
        }

        if(Input.GetKey(KeyCode.RightArrow)){
        quad.material.mainTextureOffset += lateralOffset2;
        }

        if(Input.GetKey(KeyCode.DownArrow)){
        quad.material.mainTextureOffset += verticalOffset;
        }

        if(Input.GetKey(KeyCode.UpArrow)){
        quad.material.mainTextureOffset -= verticalOffset;
        }

        if(Input.GetKeyDown(KeyCode.Space)){
             PrintArray("lateralOffset", lateralOffset);
             PrintArray("mainoffset", quad.material.mainTextureOffset);
            PrintArray("offsetsomado", lateralOffset + quad.material.mainTextureOffset);
           
        }

        // if(Input.GetKeyDown(KeyCode.S)){    
        //     if(!CompareVector2(mainOffsetAnterior, quad.material.mainTextureOffset)){
        //         PrintArray("Anterior", mainOffsetAnterior);
        //         PrintArray("Atual", quad.material.mainTextureOffset);
        //         for(int i = 0; i<=1; i++){
        //             mainOffsetAnterior[i] = quad.material.mainTextureOffset[i];
        // }   }   }






        ///////////////////////custom methods////////////////////
        static bool CompareVector2(Vector2 receptor , Vector2 original){
            bool igualdade = true;
            for(int i = 0; i<=1; i++){   
                if(receptor[i] != original[i]){
                    igualdade = false;
                    break;
                }      
            }
            return igualdade;   
        }


        static float[] Vector2ToArray(Vector2 original){
            float[] tempstring = new float[2];
            for(int i = 0; i<=1; i++){
                tempstring[i] = original[i];
            }
            return tempstring;
        }



        static void PrintArray(string textoAuxiliar, Vector2 teste){

            for(int i = 0; i < 1; i++){
                print(textoAuxiliar + (i+1) + " " + teste[i]);
            }
        }
    }
    


}
