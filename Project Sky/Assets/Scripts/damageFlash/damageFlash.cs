using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageFlash : MonoBehaviour
{
   [SerializeField] private Color flashColor = Color.white; 

   [SerializeField] private float flashTime = 0.25f; 

   private SpriteRenderer spriteRen; 

   private Material mat; 

   private Coroutine damageFlashCoroutine;
 



    private void Awake() {
        spriteRen = GetComponent<SpriteRenderer>(); 
        mat =  spriteRen.material; 
    }

    public void CallDamageFlash(){

        damageFlashCoroutine = StartCoroutine(DamageFlash());  
    }


    private IEnumerator DamageFlash(){

        setFlashColor(); 

        float currentFlashAmount = 0f; 
        float elapsedTime = 0f; 

        while (elapsedTime < flashTime) {
            elapsedTime += Time.deltaTime; 

            currentFlashAmount = Mathf.Lerp(1f, 0f, elapsedTime/flashTime); 

            setFlashAmount(currentFlashAmount);
            yield return null; 
        }
    }

    private void setFlashColor() {

        mat.SetColor("_FlashColor", flashColor); 
    }

    private void setFlashAmount(float amount) {

        mat.SetFloat("_FlashAmount", amount); 

    }











}
