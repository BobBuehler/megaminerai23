// Generated by Creer at 12:13AM on November 01, 2015 UTC, git hash: '1b69e788060071d644dd7b8745dca107577844e1'
// Can put out fires completely.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <<-- Creer-Merge: usings -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
// you can add addtional using(s) here
// <<-- /Creer-Merge: usings -->>

namespace Joueur.cs.Games.Anarchy
{
    /// <summary>
    /// Can put out fires completely.
    /// </summary>
    class FireDepartment : Anarchy.Building
    {
        #region Properties
        /// <summary>
        /// The amount of fire removed from a building when bribed to extinguish a building.
        /// </summary>
        public int FireExtinguished { get; protected set; }


        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of {$obj_key}. Used during game initialization, do not call directly.
        /// </summary>
        protected FireDepartment() : base()
        {
        }

        /// <summary>
        /// Bribes this FireDepartment to extinguish the some of the fire in a building.
        /// </summary>
        /// <param name="building">The Building you want to extinguish.</param>
        /// <returns>true if the bribe worked, false otherwise</returns>
        public bool Extinguish(Anarchy.Building building)
        {
            return this.RunOnServer<bool>("extinguish", new Dictionary<string, object> {
                {"building", building}
            });
        }

        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional method(s) here.
        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}