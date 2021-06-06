using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
//[RequireComponent(typeof(Light))]
public class flashimg : MonoBehaviour
{
    Image _image = null;
    Light _light = null;
    Coroutine _currentFlash = null;
    // Start is called before the first frame update
    private void Awake()
    {
        _image = GetComponent<Image>();
        //_light = GetComponent<Light>();
    }
    public void StartFlashimg(float flashtime, float maxalpha, Color newColor)
    {
        _image.color = newColor;
        //_light.color = newColor;
        //ensure max alpha is not above 1
        maxalpha = Mathf.Clamp(maxalpha, 0, 1);

        if (_currentFlash != null)
            StopCoroutine(_currentFlash);
        _currentFlash = StartCoroutine(Flash(flashtime, maxalpha));
    }
  /*  public void StartFlashlight(float flashtime, float maxalpha, Color newColor)
    {
        //_image.color = newColor;
        _light.color = newColor;
        //ensure max alpha is not above 1
        maxalpha = Mathf.Clamp(maxalpha, 0, 1);

        if (_currentFlash != null)
            StopCoroutine(_currentFlash);
        _currentFlash = StartCoroutine(Flash(flashtime, maxalpha));
    }*/
    IEnumerator Flash(float flashtime, float maxalpha)
    {
        //animate flah in 
        float flashin = flashtime / 2;
        for (float t = 0; t <= flashin; t += Time.deltaTime)
        {
            //color change
            Color colorflash = _image.color;
           // Color colorlight = _light.color;
            //Light intensitylight = _light.intensity;
            colorflash.a = Mathf.Lerp(0, maxalpha, t/flashin);
          //  colorlight.a = Mathf.Lerp(0, maxalpha, t / flashin);
            _image.color = colorflash;
            //_light.color = colorlight;
            //wait 
            yield return null;
        }
        //animate flah out 
        float flashout = flashtime / 2;
        for (float t = 0; t <= flashout; t += Time.deltaTime)
        {
            //color change
            Color colorflash = _image.color;
            //Color colorlight = _light.color;
            colorflash.a = Mathf.Lerp(maxalpha, 0, t/flashout);
            //colorlight.a = Mathf.Lerp(0, maxalpha, t / flashin);
            _image.color = colorflash;
            //_light.color = colorlight;
            //wait 
            yield return null;
        }
        // Update is called once per frame
    }
    }
