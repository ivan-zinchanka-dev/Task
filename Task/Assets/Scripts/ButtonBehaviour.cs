﻿using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    void Start()
    {
        this.gameObject.SetActive(false);

        GUIManager.LevelUp += delegate (){

            this.gameObject.SetActive(true);
        };

        GUIManager.GetRewardPressed += delegate ()
        {
            this.gameObject.SetActive(false);
        };

        GUIManager.RewardChoosed += delegate ()
        {
            this.gameObject.SetActive(false);
        };

    }

}
