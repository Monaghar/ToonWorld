using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ToonWorld
{
    [Table("Toonz")]
    public class ToonDBO
    {
        public ToonDBO(IToon tempToon)
        {

        }

        [Key]
        public int ToonID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Age { get; set; }
        public string Station { get; set; }
        public string Focus { get; set; }
        public string Lifestyle { get; set; }
        public string Background { get; set; }
        public string Zeal { get; set; }
        public string God { get; set; }
        public string Goal { get; set; }
        public string Alignment { get; set; }
        public int Stregnth { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charsima { get; set; }
        public string Languages { get; set; }
        public string Skills { get; set; }
        public string Tools { get; set; }
        public string Proficency { get; set; }
    }
}
