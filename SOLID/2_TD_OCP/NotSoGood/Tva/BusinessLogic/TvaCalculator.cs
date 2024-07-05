using System;

namespace Tva.BusinessLogic
{
    public class TvaCalculator
    {
        public double MontantHorsTaxe { get; set; }
        /// <summary>
        /// Calcule la TVA pour un type de Company
        /// </summary>
        /// <param name="companyType"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double Calculate(CompanyType companyType){
            if(companyType.Name == "réduit"){
                return (MontantHorsTaxe / 100) * 5.5;
            }
            else if(companyType.Name == "intermédiaire")
                return (MontantHorsTaxe / 100) * 10;

            else if(companyType.Name=="normal")
                return (MontantHorsTaxe / 100) * 20;

            throw new Exception("TVA inconnu");
        }

        
    }
}
