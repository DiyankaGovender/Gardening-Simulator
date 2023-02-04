using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant_Test : MonoBehaviour
{
    private SpriteRenderer spriteRend;

    //PLANT SPRITES 
    public Sprite empty;
    public Sprite shrub;
    

    //GROUND SPRITES
    public Sprite grass;
    public Sprite dirt;
    public Sprite emptyTile;
    public Sprite soil;
    public Sprite waterSoil;
    public Sprite growSoil;

    //BEAN SPRITES
    public Sprite happpyBean;
    public Sprite tulipBean;
    public Sprite sunflowerBean;
    public Sprite roseBean;
    public Sprite heartBean;

    public bool ishapppyBean;
    public bool istulipBean;
    public bool issunflowerBean;
    public bool isroseBean;
    public bool isheartBean;


    //SPROUT SPRITES
    public Sprite sprout;

    public bool isHappysprout;
    public bool isTulipSprout;
    public bool isSunflowerSprout;
    public bool isRoseSprout;
    public bool isHeartSprout;


    //FLOWER SPRITES 
    public Sprite happpyFlower;
    public Sprite tulipFlower;
    public Sprite sunflowerFlower;
    public Sprite roseFlower;
    public Sprite heartFlower;

    public bool isHappyFlower;
    public bool isTulipFlower;
    public bool isSunflower;
    public bool isRoseFlower;
    public bool isHeartFlower;








    public bool isChoppedCanPlant;
    public bool isWatercanGrow;
    public bool isGrow;
    public bool isGrownCanCut;



    public bool isDirtcanSoil;
    public bool isSoilcanWater;



    public Transform groundTiles;





    //TIMING STUFF
    public float seedtoSprout = 10f;
    public float sprouttoFlower = 15f;
    public float flowertoReset = 0.5f;

    void Start()
    {
     

        spriteRend = gameObject.GetComponent<SpriteRenderer>();

        isChoppedCanPlant = false;
        isDirtcanSoil = false;
        isSoilcanWater = false;
        isWatercanGrow = false;


        ishapppyBean = false;
        istulipBean = false;
        issunflowerBean = false;
        isroseBean = false;
        isheartBean = false;

        isHappysprout = false;
        isTulipSprout = false;
        isSunflowerSprout = false;
        isRoseSprout = false;
        isHeartSprout = false;

        isGrownCanCut = false;


        isHappyFlower = false;
        isTulipFlower = false;
        isSunflower = false;
        isRoseFlower = false;
        isHeartFlower = false;

        groundTiles.GetComponent<SpriteRenderer>();
    }

    


    void Update()
    {

        { 
           

           

        }


    }

  
  

    public void OnMouseDown()
    {

        //CANCEL
        if (Tool_Manager.currentTool == "Cancel")
        {
            GetComponent<SpriteRenderer>().sprite = shrub;
            groundTiles.GetComponent<SpriteRenderer>().sprite = grass;

            isSunflower = false;
            isChoppedCanPlant = false;
            isWatercanGrow = false;
            isGrownCanCut = false;
            isDirtcanSoil = false;
            isSoilcanWater = false;
        }

        //SHRUB TO EMPTY
        if (Tool_Manager.currentTool == "Axe" && (GetComponent<SpriteRenderer>().sprite == shrub))

        {
            GetComponent<SpriteRenderer>().sprite = empty;
            isChoppedCanPlant = true;
           
        }



        //GRASS TO DIRT 
        if (Tool_Manager.currentTool == "Shovel"
             && groundTiles.GetComponent<SpriteRenderer>().sprite == grass)
        {
            groundTiles.GetComponent<SpriteRenderer>().sprite = dirt;
            isDirtcanSoil = true;

        }

        //DIRT TO SOIL 
        if (Tool_Manager.currentTool == "Soil"
            && groundTiles.GetComponent<SpriteRenderer>().sprite == dirt
            && isDirtcanSoil == true
            && Coin_Shop.coin >= 5)
        {
            groundTiles.GetComponent<SpriteRenderer>().sprite = soil;
            isSoilcanWater = true;


            Coin_Shop.coin -= 5;
            Debug.Log("Yer");
           

        }

      

        //SOIL TO WATER
        if (Tool_Manager.currentTool == "Watering Can"
         && groundTiles.GetComponent<SpriteRenderer>().sprite == soil
         && isSoilcanWater == true)
        {
            groundTiles.GetComponent<SpriteRenderer>().sprite = waterSoil;
            isWatercanGrow = true;
        
        }

        //WATER TO GROW
        if (Tool_Manager.currentTool == "Grow"
         && groundTiles.GetComponent<SpriteRenderer>().sprite == waterSoil
         && isSoilcanWater == true
         && Coin_Shop.coin >= 5)
        {
            groundTiles.GetComponent<SpriteRenderer>().sprite = growSoil;
            isWatercanGrow = true;

            Coin_Shop.coin -= 5;

        }















        //EMPTY TO SEEDS

        //EMPTY TO  HAPPY SEED (NEED SOIL)
        if (Tool_Manager.currentTool == "Happy Seeds"
            && (GetComponent<SpriteRenderer>().sprite == empty)
            && isChoppedCanPlant
            && isSoilcanWater ==true
            && Coin_Shop.coin >= 5)
        {
            GetComponent<SpriteRenderer>().sprite = happpyBean;
            ishapppyBean = true;

            Coin_Shop.coin -= 5;

        }

        //EMPTY TO TULIP SEED
        if (Tool_Manager.currentTool == "Tulip Seeds"
            && (GetComponent<SpriteRenderer>().sprite == empty)
            && isChoppedCanPlant
            && isSoilcanWater == true
            && Coin_Shop.coin >=10)
        {
            GetComponent<SpriteRenderer>().sprite = tulipBean;
            istulipBean = true;


            Coin_Shop.coin -= 10;
        }

        //EMPTY TO SUNFLOWER SEED
        if (Tool_Manager.currentTool == "Sunflower Seeds"
           && (GetComponent<SpriteRenderer>().sprite == empty)
           && isChoppedCanPlant == true
            && isSoilcanWater == true
             && Coin_Shop.coin >= 15)
        {
            GetComponent<SpriteRenderer>().sprite = sunflowerBean;
            issunflowerBean = true;


            Coin_Shop.coin -= 15;
        }

        //EMPTY TO ROSE SEED
        if (Tool_Manager.currentTool == "Rose Seeds"
           && (GetComponent<SpriteRenderer>().sprite == empty)
           && isChoppedCanPlant == true
            && isSoilcanWater == true
             && Coin_Shop.coin >= 20)
        {
            GetComponent<SpriteRenderer>().sprite = roseBean;
            isroseBean = true;


            Coin_Shop.coin -= 20;
        }

        //EMPTY TO HEART SEED
        if (Tool_Manager.currentTool == "Heart Seeds"
           && (GetComponent<SpriteRenderer>().sprite == empty)
           && isChoppedCanPlant== true
            && isSoilcanWater == true
             && Coin_Shop.coin >= 25)
        {
            GetComponent<SpriteRenderer>().sprite = heartBean;
            isheartBean = true;



            Coin_Shop.coin -= 25;
        }












        //SEED TO SPORUT
        //HAPPY SEED TO SPROUT
        if (Tool_Manager.currentTool =="Watering Can" 
            && isSoilcanWater ==true
            && ishapppyBean == true)
        {
            StartCoroutine(HappySeedtoSprout());
        }

        //TULIP SEED TO SPROUT
        if (Tool_Manager.currentTool == "Watering Can"
          && isSoilcanWater == true
          && istulipBean == true)
        {
            StartCoroutine(TulipSeedtoSprout());
        }

        //SUNFLOWER SEED TO SPROUT
        if (Tool_Manager.currentTool == "Watering Can"
         && isSoilcanWater == true
         && issunflowerBean == true)
        {
            StartCoroutine(SunflowerSeedtoSprout());
        }

        //ROSE SEED TO SPROUT
        if (Tool_Manager.currentTool == "Watering Can"
         && isSoilcanWater == true
         && isroseBean == true)
        {
            StartCoroutine(RoseSeedtoSprout());
        }

        //HEART SEED TO SPORUT 
        if (Tool_Manager.currentTool == "Watering Can"
         && isSoilcanWater == true
         && isheartBean == true)
        {
            StartCoroutine(RoseSeedtoSprout());
        }















        //SPROUT TO FLOWER
        //HAPPY SPROUT TO FLOWER 
        if (Tool_Manager.currentTool == "Grow"
         && isWatercanGrow == true
         && isHappysprout == true)
        {
            StartCoroutine(HappySprouttoFlower());
        
        }

        //TULIP SPROUT TO FLOWER
        if (Tool_Manager.currentTool == "Grow"
         && isWatercanGrow == true
         && isTulipSprout == true)
        {
            StartCoroutine(TulipSprouttoFlower());

        }

        //SUNFLOWER SPROUT TO FLOWER 
        if (Tool_Manager.currentTool == "Grow"
         && isWatercanGrow == true
         && isSunflowerSprout == true)
        {
            StartCoroutine(SunflowerSprouttoFlower());


        }

        //ROSE SPROUT TO FLOWER
        if (Tool_Manager.currentTool == "Grow"
         && isWatercanGrow == true
         && isRoseSprout == true)
        {
            StartCoroutine(RoseSprouttoFlower());
        }


        //HEART SPROUT TO FLOWER
        if (Tool_Manager.currentTool == "Grow"
         && isWatercanGrow == true
         && isHeartSprout == true)
        {
            StartCoroutine(HeartSprouttoFlower());
        }













        //FLOWER TO RESET
        //HAPPY FLOWER TO RESET
        if (Tool_Manager.currentTool == "Hoe" && isGrownCanCut == true && isHappyFlower==true)
        {
            StartCoroutine(HappytoReset());
            Coin_Shop.coin += 30;
        }


        //TULIP FLOWER TO RESET
        if (Tool_Manager.currentTool == "Hoe" && isGrownCanCut == true && isTulipFlower == true)
        {

            StartCoroutine(TuliptoReset());
            Coin_Shop.coin += 40;
        }


        //SUNFLOWER TO RESET
        if (Tool_Manager.currentTool == "Hoe" && isGrownCanCut == true && isSunflower == true)
        {
            StartCoroutine(SunflowertoReset());
            Coin_Shop.coin += 50;
        }



        //ROSE TO RESET
        if (Tool_Manager.currentTool == "Hoe" && isGrownCanCut == true && isRoseFlower == true)
        {
            StartCoroutine(RosetoReset());
            Coin_Shop.coin += 60;
        }


        //HEART TO RESET
        if (Tool_Manager.currentTool == "Hoe" && isGrownCanCut == true && isHeartFlower == true)
        {
            StartCoroutine(HearttoReset());
            Coin_Shop.coin += 70;

        }












    }













    //SEED TO SPROUT TIMING

    //HAPPY SEED TO SPROUT 
    public IEnumerator HappySeedtoSprout()
    {
        yield return new WaitForSeconds(seedtoSprout);
        GetComponent<SpriteRenderer>().sprite = sprout;
        isHappysprout = true;
    }

    //TULIP SEED TO SPROUT
    public IEnumerator TulipSeedtoSprout()
    {
        yield return new WaitForSeconds(seedtoSprout);
        GetComponent<SpriteRenderer>().sprite = sprout;
        isTulipSprout = true;

    }


    //SUNFLOWER SEED TO SPROUT 
    public IEnumerator SunflowerSeedtoSprout()
    {
        yield return new WaitForSeconds(seedtoSprout);
        GetComponent<SpriteRenderer>().sprite = sprout;
        isSunflowerSprout = true;
    }

    //ROSE SEED TO SPROUT
    public IEnumerator RoseSeedtoSprout()
    {
        yield return new WaitForSeconds(seedtoSprout);
        GetComponent<SpriteRenderer>().sprite = sprout;
        isRoseSprout = true;

    }

    //HEART SEED TO SPROUT
    public IEnumerator HeartSeedtoSprout()
    {
        yield return new WaitForSeconds(seedtoSprout);
        GetComponent<SpriteRenderer>().sprite = sprout;
        isHeartSprout = true;

    }












    //TIMING FOR SPROUT TO FLOWER
    //HAPPY SPROUT TO FLOWER
    public IEnumerator HappySprouttoFlower()
    {
        yield return new WaitForSeconds(sprouttoFlower);
        GetComponent<SpriteRenderer>().sprite = happpyFlower;
        isGrownCanCut = true;
        isHappyFlower = true;
    }

    //TULIP SPROUT TO FLOWER 
    public IEnumerator TulipSprouttoFlower()
    {
        yield return new WaitForSeconds(sprouttoFlower);
        GetComponent<SpriteRenderer>().sprite = tulipFlower;
        isGrownCanCut = true;
        isTulipFlower = true;

    }

    //SUNFLOWER SPROUT TO FLOWER
    public IEnumerator SunflowerSprouttoFlower()
    {
        yield return new WaitForSeconds(sprouttoFlower);
        GetComponent<SpriteRenderer>().sprite = sunflowerFlower;
        isGrownCanCut = true;
        isSunflower = true;

    }

    //ROSE SPROUT TO FLOWER 
    public IEnumerator RoseSprouttoFlower()
    {
        yield return new WaitForSeconds(sprouttoFlower);
        GetComponent<SpriteRenderer>().sprite = roseFlower;
        isGrownCanCut = true;
        isRoseFlower = true;

    }

    //HEART SPROUT TO FLOWER 
    public IEnumerator HeartSprouttoFlower()
    {
        yield return new WaitForSeconds(sprouttoFlower);

        GetComponent<SpriteRenderer>().sprite = heartFlower;
        isGrownCanCut = true;
        isHeartFlower = true;


    }












    //RESET TIMIMING
    //HAPPY TO RESET
    public IEnumerator HappytoReset()
    {
        yield return new WaitForSeconds(flowertoReset);

        GetComponent<SpriteRenderer>().sprite = shrub;
        groundTiles.GetComponent<SpriteRenderer>().sprite = grass;

        isHappyFlower = false;
        isChoppedCanPlant = false;
        isWatercanGrow = false;
        isGrownCanCut = false;
        isDirtcanSoil = false;
        isSoilcanWater = false;

    }

    //TULIP TO RESET
    public IEnumerator TuliptoReset()
    {
        yield return new WaitForSeconds(flowertoReset);

        GetComponent<SpriteRenderer>().sprite = shrub;
        groundTiles.GetComponent<SpriteRenderer>().sprite = grass;

        isTulipFlower = false;
        isChoppedCanPlant = false;
        isWatercanGrow = false;
        isGrownCanCut = false;
        isDirtcanSoil = false;
        isSoilcanWater = false;
    }


    //SUNFLOWER TO RESET
    public IEnumerator SunflowertoReset()
    {
        yield return new WaitForSeconds(flowertoReset);

        GetComponent<SpriteRenderer>().sprite = shrub;
        groundTiles.GetComponent<SpriteRenderer>().sprite = grass;

        isSunflower = false;
        isChoppedCanPlant = false;
        isWatercanGrow = false;
        isGrownCanCut = false;
        isDirtcanSoil = false;
        isSoilcanWater = false;

    }


    //ROSE TO RESET
    public IEnumerator RosetoReset()
    {
        yield return new WaitForSeconds(flowertoReset);

        GetComponent<SpriteRenderer>().sprite = shrub;
        groundTiles.GetComponent<SpriteRenderer>().sprite = grass;

        isRoseFlower = false;
        isChoppedCanPlant = false;
        isWatercanGrow = false;
        isGrownCanCut = false;
        isDirtcanSoil = false;
        isSoilcanWater = false;
    }


    //HEART TO RESET
    public IEnumerator HearttoReset()
    {
        yield return new WaitForSeconds(flowertoReset);

        GetComponent<SpriteRenderer>().sprite = shrub;
        groundTiles.GetComponent<SpriteRenderer>().sprite = grass;

        isHeartFlower = false;
        isChoppedCanPlant = false;
        isWatercanGrow = false;
        isGrownCanCut = false;
        isDirtcanSoil = false;
        isSoilcanWater = false;
    }
}
