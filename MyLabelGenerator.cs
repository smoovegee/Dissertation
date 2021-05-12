using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLabelGenerator : MonoBehaviour
{

    public Font mfont;
    public List<MeshFilter> mPlaneFilters;
    private int mDrinkCount = 60;
    void Awake() {

        //use the cureent material, just update the main texture
        foreach (MeshFilter meshFilter in mPlaneFilters)
            meshFilter.GetComponent<MeshRenderer>().material.mainTexture = mfont.material.mainTexture;
    }
    private void CreateFont(string output)
    {
        //Get the texture based on the font, and characters needed
        mfont.RequestCharactersInTexture(output);

        //For each character in the string
        for (int i = 0; i < output.Length; i++)
        {
            //Get character data
            CharacterInfo character;
            mfont.GetCharacterInfo(output[i], out character);

            //Set UVs
            Vector2[] uvs = new Vector2[4];
            uvs[0] = character.uvBottomLeft;
            uvs[1] = character.uvTopRight;
            uvs[2] = character.uvBottomRight;
            uvs[3] = character.uvTopLeft;

            //Apply UVS
            mPlaneFilters[i].mesh.uv = uvs;

            //Get Basic Scale
            Vector3 newScale = mPlaneFilters[i].transform.localScale;
            newScale.x = character.glyphWidth * 0.02f;

            //Set
            mPlaneFilters[i].transform.localScale = newScale;

        }


    }
    private void DrinkName(string output)
    {

    }
  
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DrinkCountDown());
    }

    private IEnumerator DrinkCountDown()
    {

        while (mDrinkCount > 0)
        {
            DisplayDrinkName(mDrinkCount);
            mDrinkCount--;

            yield return new WaitForSeconds(1.0f);
        }
    }

    private void DisplayDrinkName(int drinkCount)
    {
        string output = drinkCount.ToString();
        if (drinkCount < 10)
            output = "0" + output;
        CreateFont(output);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
