// Generated by Creer at 10:40PM on July 21, 2015 UTC, git hash: '6ae07398e95534176c2e851c2d21269933edce81'
// An object in the game. The most basic class that all game classes should inherit from automatically.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <<-- Creer-Merge: usings -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
// you can add addtional using(s) here
// <<-- /Creer-Merge: usings -->>

namespace Joueur.cs.Games.Checkers
{
    /// <summary>
    /// An object in the game. The most basic class that all game classes should inherit from automatically.
    /// </summary>
    class GameObject : BaseGameObject
    {
        #region Properties
        /// <summary>
        /// Any strings logged will be stored here when this game object logs the strings. Intended for debugging.
        /// </summary>
        public IList<string> Logs { get; protected set; }


        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of {$obj_key}. Used during game initialization, do not call directly.
        /// </summary>
        public GameObject() : base()
        {
            this.Logs = new List<string>();
        }

        /// <summary>
        /// adds a message to this game object's log. Intended for debugging purposes.
        /// </summary>
        /// <param name="message">A string to add to this GameObject's log. Intended for debugging.</param>
        public void Log(string message)
        {
            this.RunOnServer<object>("log", new object[] { message });
        }

        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional method(s) here.
        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}
