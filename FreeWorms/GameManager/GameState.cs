using FreeWorms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeWorms.GameManager
{
    public class GameState
    {

        public Player[] Players;
        public int PlayerIndex, WormIndex;
        public bool NextTurn, IsStarted;
        public WormState WormState;

        public GameState()
        {

            PlayerIndex = 0;
            NextTurn = false;
            IsStarted = false;
            WormIndex = 0;

        }

        public void Init(Player[] players)
        {

            Players = players;
            IsStarted = true;
            WormState = new WormState(Players);

        }

        public void Update() {

            Worm worm = Players[PlayerIndex].Team.Worms[WormIndex];
            if (WormState.isDead(worm))
                Players[PlayerIndex].Team.Worms[WormIndex] = null;
        }
    }
}
