using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroes.Models
{
    public class SuperHero
    {
        [Key]
        public int MyProperty { get; set; }
        public string SuperHeroNAme { get; set; }
        public string AlterEgoName { get; set; }
        public string PrimarySuperHeroAbility { get; set; }
        public string SecondarySuperheroAbility { get; set; }
        public string CatchPhrase { get; set; }
    }
}