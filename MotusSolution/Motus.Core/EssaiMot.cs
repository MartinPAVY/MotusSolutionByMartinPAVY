namespace Motus.Core
{
    public class EssaiMot
    {
        public EssaiMot() 
        {
            this.Lettres = new List<Lettre>();
        }

        public List<Lettre> Lettres { get; set; }

        public bool IsOk()
        {
            foreach (Lettre lettre in Lettres) 
            { 
                if (lettre.Etat == EtatLettre.MauvaiseLettre || lettre?.Etat == EtatLettre.BonneLettreMalPlacee) 
                { 
                    return false;
                }
            } 
            return true;
            
        }
    }
}
