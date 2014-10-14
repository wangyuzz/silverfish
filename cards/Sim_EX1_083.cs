﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_EX1_083.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ e x 1_083.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    using System.Collections.Generic;

    /// <summary>
    ///     The sim_ e x 1_083.
    /// </summary>
    internal class Sim_EX1_083 : SimTemplate
    {
        // tinkmasteroverspark
        #region Fields

        /// <summary>
        ///     The card 1.
        /// </summary>
        private CardDB.Card card1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_tk29); // rex

        /// <summary>
        ///     The card 2.
        /// </summary>
        private CardDB.Card card2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_tk28); // squirrel

        #endregion

        // todo better
        // kampfschrei:/ verwandelt einen anderen zufälligen diener in einen teufelssaurier (5/5) oder ein eichhörnchen (1/1).
        #region Public Methods and Operators

        /// <summary>
        /// The get battlecry effect.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="own">
        /// The own.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <param name="choice">
        /// The choice.
        /// </param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int oc = p.ownMinions.Count;
            int ec = p.enemyMinions.Count;
            if (oc == 0 && ec == 0)
            {
                return;
            }

            if (oc > ec)
            {
                List<Minion> temp = new List<Minion>(p.ownMinions);
                temp.AddRange(p.enemyMinions);
                temp.Sort((a, b) => a.Hp.CompareTo(b.Hp)); // transform the weakest
                foreach (Minion m in temp)
                {
                    p.minionTransform(m, this.card1);
                    break;
                }
            }
            else
            {
                List<Minion> temp = new List<Minion>(p.ownMinions);
                temp.AddRange(p.enemyMinions);
                temp.Sort((a, b) => -a.Hp.CompareTo(b.Hp)); // transform the strongest
                foreach (Minion m in temp)
                {
                    p.minionTransform(m, this.card2);
                    break;
                }
            }
        }

        #endregion
    }
}