using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.PlayerOrdner
{
    public class AbstractOpponent
    {
		private double Menschen;
		private double Zwerge;
		private double Elfen;
		private double Riesen;
		private double _wizards;
		private double Narren;
		private double bid;
		private int round;
		private Card trump;
		private string name;
		private int id;
		private bool hasMenschen = true;
		private bool hasElfen = true;
		private bool hasZwerge = true;
		private bool hasRiesen = true;
		private bool hasWizards = true;
		private bool hasNarren = true;

		public virtual void setRound(int round)
		{
			this.round = round;
			hasMenschen = true;
			hasElfen = true;
			hasZwerge = true;
			hasRiesen = true;
			hasWizards = true;
			hasNarren = true;
		}

	
		public double getMenschen()
		{
			return Menschen;
		}
		/**
		 * @param diamonds the diamonds to set
		 */
		public void setMenschen(double menschen)
		{
			Menschen = menschen;
		}
		public double getZwerge()
		{
			return Zwerge;
		}
		/**
		 * @param diamonds the diamonds to set
		 */
		public void setZwerge(double zwerge)
		{
			Zwerge = zwerge;
		}
		public double getElfen()
		{
			return Elfen;
		}
		/**
		 * @param diamonds the diamonds to set
		 */
		public void setElfen(double elfen)
		{
			Elfen = elfen;
		}
		public double getRiesen()
		{
			return Riesen;
		}
		/**
		 * @param diamonds the diamonds to set
		 */
		public void setRiesen(double riesen)
		{
			Riesen = riesen;
		}
		public double getWizards()
		{
			return _wizards;
		}
		/**
		 * @param diamonds the diamonds to set
		 */
		public void setWizards(double wizards)
		{
			_wizards = wizards;
		}
		public double getNarren()
		{
			return Narren;
		}
		/**
		 * @param diamonds the diamonds to set
		 */
		public void setNarren(double narren)
		{
			Narren = narren;
		}

		public Card getTrump()
		{
			return trump;
		}

		/**
		 * @param trump the trump to set
		 */
		public void setTrump(Card trump)
		{
			this.trump = trump;
		}
		public int getRound()
		{
			return round;
		}

		/**
		 * @return the bid
		 */
		public double getBid()
		{
			return bid;
		}

		/**
	 * @param bid the bid to set
	 */
		public virtual void setBid(double bid)
		{
			this.bid = bid;
		}

		/**
		 * @return the name
		 */
		public string getName()
		{
			return name;
		}
		/**
	 * @param name the name to set
	 */
		public void setName(String name)
		{
			this.name = name;
		}

		/**
		 * @return the id
		 */
		public int getId()
		{
			return id;
		}
		/**
	 * @param id the id to set
	 */
		public void setId(int id)
		{
			this.id = id;
		}

		/**
		 * @return the hasClubs
		 */
		public bool isHasZwerge()
		{
			return hasZwerge;
		}
		public bool isHasRiesen()
		{
			return hasRiesen;
		}

		/**
		 * @return the hasHearts
		 */
		public bool isHasMenschen()
		{
			return hasMenschen;
		}

		/**
		 * @return the hasSpades
		 */
		public bool isHasElfen()
		{
			return hasElfen;
		}

		/**
		 * @return the hasJesters
		 */
		public bool isHasNarren()
		{
			return hasNarren;
		}
		public bool isHasWizards()
		{
			return hasWizards;
		}
		public void setHasMenschen(bool hasMenschen)
		{
			this.hasMenschen = hasMenschen;
		}

		/**
		 * @param hasDiamonds the hasDiamonds to set
		 */
		public void setHasZwerge(bool hasZwerge)
		{
			this.hasZwerge = hasZwerge;
		}

		/**
		 * @param hasHearts the hasHearts to set
		 */
		public void setHasElfen(bool hasElfen)
		{
			this.hasElfen = hasElfen;
		}

		/**
		 * @param hasJesters the hasJesters to set
		 */
		public void setHasRiesen(bool hasRiesen)
		{
			this.hasRiesen = hasRiesen;
		}

		/**
		 * @param hasSpades the hasSpades to set
		 */
		public void setHasNarren(bool hasNarren)
		{
			this.hasNarren = hasNarren;
		}

		/**
		 * @param hasWizards the hasWizards to set
		 */
		public void setHasWizards(bool hasWizards)
		{
			this.hasWizards = hasWizards;
		}
	}
}
