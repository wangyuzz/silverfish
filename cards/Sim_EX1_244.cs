﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_EX1_244.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ e x 1_244.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    using System.Collections.Generic;

    /// <summary>
    ///     The sim_ e x 1_244.
    /// </summary>
    internal class Sim_EX1_244 : SimTemplate
    {
        // totemic might
        #region Public Methods and Operators

        /// <summary>
        /// The on card play.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="ownplay">
        /// The ownplay.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <param name="choice">
        /// The choice.
        /// </param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = ownplay ? p.ownMinions : p.enemyMinions;
            foreach (Minion t in temp)
            {
                if (t.handcard.card.race == 21)
                {
                    // if minion is a totem, buff it
                    p.minionGetBuffed(t, 0, 2);
                }
            }
        }

        #endregion
    }
}