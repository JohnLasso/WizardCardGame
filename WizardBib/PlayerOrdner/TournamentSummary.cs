using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.PlayerOrdner
{
    public class TournamentSummary
    {

        private Dictionary<string, List<int>> playerSummary = 
            new Dictionary<string, List<int>>();

        private bool isFirst = true;
        private int count = 0;

        public void newGame()
        {
            isFirst = true;
            count = 0;
        }

        public void addScore(String playerName, int score)
        {
            if (isFirst)
            {
                count++;
                if (count == 4)
                {
                    isFirst = false;
                }
                List<int> games = playerSummary[playerName];
                if (games == null)
                {
                    games = new List<int>();
                    playerSummary.Add(playerName, games);
                }
                games.Add(score);
            }
        }

		public void print()
		{

			foreach (string name in playerSummary.Keys)
			{
				StringBuilder sb = new StringBuilder();
				sb.Append(name + " = [");
				int sum = 0;
				int count2 = 0;
				int max = Int32.MinValue;
				int min = Int32.MaxValue;
				int belowZero = 0;
				int rock = 0;
				bool isFirst2 = true;
				
				foreach (int score in playerSummary[name])
				{
					if (isFirst2)
					{
						isFirst2 = false;
					}
					else
					{
						//sb.append(",\t");
					}
					count2++;
					sum += score;
					max = Math.Max(max, score);
					min = Math.Min(min, score);
					if (score < 0)
					{
						belowZero++;
					}
					else if (score == 0)
					{
						rock++;
					}
					//sb.append(score);
				}
				sb.Append("] average=");
				sb.Append(sum / count2);
				sb.Append(", max=");
				sb.Append(max);
				sb.Append(", min = ");
				sb.Append(min);
				sb.Append(", worse than rock = ");
				sb.Append(belowZero);
				sb.Append(", same as rock = ");
				sb.Append(rock);
				
			}

		}



	}
}
