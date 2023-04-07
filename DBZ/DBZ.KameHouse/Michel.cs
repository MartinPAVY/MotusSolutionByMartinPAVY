using DBZ.Dojo.Vestiaires;

namespace DBZ.KameHouse;

public class Michel : IGuerrier
{
    public string Nom
    {
        get
        {
            return "Michel";
        }
    }

    private bool _jeSuisCharge;
    private bool _adversaireCharge;

    public ActionDeCombat ChoixProchaineAction(ActionDeCombat dernierActionAdversaire)
    {
        if (dernierActionAdversaire == ActionDeCombat.ChargeKameHameHa)
        {
            this._adversaireCharge = true;
            return ActionDeCombat.Parade;
        } else if (dernierActionAdversaire == ActionDeCombat.KameHameHa && this._jeSuisCharge)
        {
            this._adversaireCharge = false;
            this._jeSuisCharge = false;
            return ActionDeCombat.KameHameHa;
        }
        else if (dernierActionAdversaire == ActionDeCombat.KameHameHa && !this._jeSuisCharge)
        {
            this._adversaireCharge = false;
            this._jeSuisCharge = true;
            return ActionDeCombat.ChargeKameHameHa;
        }
        else
        {
            this._jeSuisCharge = true;
            return ActionDeCombat.ChargeKameHameHa;
        }
    }
}