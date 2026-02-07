using RTLTMPro;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public static class obj 
{
    private static Dictionary<string, GameObject> map = new();


    public static GameObject Get(string name) {

        return map[name];
    }
    public static Button GetB(string name)
    {

        return map[name].GetComponent<Button>();
    }
    public static Image GetI(string name)
    {

        return map[name].GetComponent<Image>();
    }
    public static RTLTextMeshPro GetRTL(string name)
    {

        return map[name].GetComponent<RTLTextMeshPro>();
    }
    public static TMP_InputField GetIN(string name)
    {

        return map[name].GetComponent<TMP_InputField>();
    }
    public static TMP_Text GetT(string name)
    {

        return map[name].GetComponent<TMP_Text>();
    }
    public static Slider GetS(string name)
    {

        return map[name].GetComponent<Slider>();
    }

    public static AudioSource GetAU(string name)
    {

        return map[name].GetComponent<AudioSource>();
    }









    public static void Set(GameObject ob) { 
    
       map[ob.name] = ob;
       
    }

}
