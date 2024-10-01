// Copyright 2021, Infima Games. All Rights Reserved.

using UnityEngine;

namespace InfimaGames.LowPolyShooterPack.Interface
{
    /// <summary>
    /// Component that changes a text to match the current time scale.
    /// </summary>
    public class TextTimescale : ElementText
    {
        #region METHODS
        
        protected override void Tick()
        {
            textMesh.text = "";
            //Change text to match the time scale!
            float current = equippedWeapon.GetAmmunitionCurrent();
            //Total Ammunition.
            float total = equippedWeapon.GetAmmunitionTotal();
            
            if (current == 0)
            {
                textMesh.text = "Has acabado las balas";
                Time.timeScale=0.0f;
            }
            
        }        

        #endregion
    }
}