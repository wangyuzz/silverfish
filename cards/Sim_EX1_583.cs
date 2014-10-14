// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_EX1_583.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ e x 1_583.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    ///     The sim_ e x 1_583.
    /// </summary>
    internal class Sim_EX1_583 : SimTemplate
    {
        // priestessofelune

        // kampfschrei:/ stellt bei eurem helden 4 leben wieder her.
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
            int heal = own.own ? p.getMinionHeal(4) : p.getEnemyMinionHeal(4);
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -heal);
        }

        #endregion
    }
}