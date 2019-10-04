using System.Collections.Generic;


namespace RoleplayGame.Items
{
    /// <summary>
    /// Crocs. Permite atacar. Su poder aumenta con pines.
    /// </summary>
    public class Crocs : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        /// 
        public List<Pin> Pines { get; set; }
        public int AttackPower
        {
            get
            {
                return 0 + 10 * Pines.Count;
            }
        }

        public override string ToString()
        {
            return "Crocs";
        }
    }
}