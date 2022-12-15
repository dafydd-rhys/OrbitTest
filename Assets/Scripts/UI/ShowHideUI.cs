using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideUI : MonoBehaviour
{

    private static ShowHideUI mInstance = null;

    private static ShowHideUI instance
    {
        get
        {
            if (mInstance == null)
            {
                mInstance = GameObject.FindObjectOfType(typeof(ShowHideUI)) as ShowHideUI;

                if (mInstance == null)
                {
                    mInstance = new GameObject("StaticCoroutine").AddComponent<ShowHideUI>();
                }
            }
            return mInstance;
        }
    }

    public static void ShowUI(GameObject ui, float delay)
    {
        ui.SetActive(true);
        DoCoroutine(FadeCanvas(ui.GetComponent<CanvasGroup>(), 0, 1, delay));
    }

    public static void HideUI(GameObject ui, float delay)
    {
        DoCoroutine(FadeCanvas(ui.GetComponent<CanvasGroup>(), 1, 0, delay));
        DoCoroutine(DisableUI(ui, delay));
    }

    static IEnumerator DisableUI(GameObject ui, float delay)
    {
        yield return new WaitForSeconds(delay);

        ui.SetActive(false);
    }

    public static void DoCoroutine(IEnumerator coroutine)
    {
        instance.StartCoroutine(instance.Perform(coroutine));
    }

    IEnumerator Perform(IEnumerator coroutine)
    {
        yield return StartCoroutine(coroutine);
        //Die();
    }

    void Die()
    {
        mInstance = null;
        Destroy(gameObject);
    }


    public static IEnumerator FadeCanvas(CanvasGroup canvas, float startAlpha, float endAlpha, float duration)
    {
        // keep track of when the fading started, when it should finish, and how long it has been running&lt;/p&gt; &lt;p&gt;&a
        var startTime = Time.time;
        var endTime = Time.time + duration;
        var elapsedTime = 0f;

        // set the canvas to the start alpha – this ensures that the canvas is ‘reset’ if you fade it multiple times
        canvas.alpha = startAlpha;
        // loop repeatedly until the previously calculated end time
        while (Time.time <= endTime)
        {
            elapsedTime = Time.time - startTime; // update the elapsed time
            var percentage = 1 / (duration / elapsedTime); // calculate how far along the timeline we are
            if (startAlpha > endAlpha) // if we are fading out/down 
            {
                canvas.alpha = startAlpha - percentage; // calculate the new alpha
            }
            else // if we are fading in/up
            {
                canvas.alpha = startAlpha + percentage; // calculate the new alpha
            }

            yield return new WaitForEndOfFrame(); // wait for the next frame before continuing the loop
        }
        canvas.alpha = endAlpha; // force the alpha to the end alpha before finishing – this is here to mitigate any rounding errors, e.g. leaving the alpha at 0.01 instead of 0
    }
}