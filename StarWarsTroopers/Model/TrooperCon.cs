using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsTroopers.Model
{
	/// <summary>
	/// Information from trooper's homeworld
	/// </summary>
    public class TrooperCon
    {
		/// <summary>
		/// Total troopers connected
		/// </summary>
		public int count { get; set; }
		/// <summary>
		/// Next homeworld
		/// </summary>
		public string next { get; set; }
		/// <summary>
		/// Previous homeworld
		/// </summary>
		public string previous { get; set; }
		/// <summary>
		/// Trooper's connected names
		/// </summary>
		public List<String> results { get; set; }
	}
}
