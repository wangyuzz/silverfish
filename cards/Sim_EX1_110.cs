﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_EX1_110.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ e x 1_110.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    ///     The sim_ e x 1_110.
    /// </summary>
    internal class Sim_EX1_110 : SimTemplate
    {
        // cairnebloodhoof

        // todesröcheln:/ ruft baine bluthuf (4/5) herbei.
        #region Fields

        /// <summary>
        ///     The blaine.
        /// </summary>
        private CardDB.Card blaine = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_110t);

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The on deathrattle.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="m">
        /// The m.
        /// </param>
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(this.blaine, m.zonepos - 1, m.own);
        }

        #endregion
    }
}