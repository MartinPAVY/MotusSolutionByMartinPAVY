namespace Motus.Core
{
    public class CalculMotService : ICalculMotService
    {
        public EssaiMot CalculMot(string tentative, string motADeviner)
        {
            var letterYetUsed = new List<char>();
            EssaiMot essaiMot = new EssaiMot();
            

            for (int i = 0; i < motADeviner.Length; i++)
            {
                if (tentative[i] == motADeviner[i])
                {
                    essaiMot.Lettres.Add(new Lettre() { Caractere = tentative[i], Etat = EtatLettre.OK });
                }
                else if (motADeviner.Contains(tentative[i]) && !letterYetUsed.Contains(tentative[i]))
                {
                    essaiMot.Lettres.Add(new Lettre() { Caractere = tentative[i], Etat = EtatLettre.BonneLettreMalPlacee });
                    letterYetUsed.Add(tentative[i]);
                }
                else
                {
                    essaiMot.Lettres.Add(new Lettre() { Caractere = tentative[i], Etat = EtatLettre.MauvaiseLettre });
                }
            }

            return essaiMot;
        }
    }
}
