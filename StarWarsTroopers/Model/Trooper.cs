using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace StarWarsTroopers.Model
{
	/// <summary>
	/// Trooper data record
	/// </summary>
    public class Trooper
    {
		/// <summary>
		/// Unique ID
		/// </summary>
		[Key]
		public int id { get; set; }
		/// <summary>
		/// Trooper's name
		/// </summary>
		[Required]
		public string name { get; set; }
		/// <summary>
		/// Trooper's height
		/// </summary>
		public float height { get; set; }
		/// <summary>
		/// Trooper's homeworld
		/// </summary>
		[Required]
		public string homeworld { get; set; }
		/// <summary>
		/// Trooper's gender, if has. 
		/// </summary>
		public string gender { get; set; }
		/// <summary>
		/// Trooper's specie
		/// </summary>
		public string specie { get; set; }
		/// <summary>
		/// Trooper's creation date
		/// </summary>
		public DateTime created { get; set; }
		/// <summary>
		/// Trooper's edited date
		/// </summary>
		public DateTime? edited { get; set; }
	}
}
