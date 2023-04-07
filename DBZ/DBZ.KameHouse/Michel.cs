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
    private int _attack = 0;
    private int _round = 0;

    public ActionDeCombat ChoixProchaineAction(ActionDeCombat dernierActionAdversaire)
    {
        /*if (_round >=1000)
        {
            return ("Combat infini")
        }*/
        if (dernierActionAdversaire == ActionDeCombat.ChargeKameHameHa )
        {
            this._adversaireCharge = true;
            return ActionDeCombat.Parade;
            this._round += 1;
        } else if (dernierActionAdversaire == ActionDeCombat.KameHameHa && this._jeSuisCharge)
        {
            this._adversaireCharge = false;
            this._jeSuisCharge = false;
            this._round += 1;
            this._attack += 1;
            return ActionDeCombat.KameHameHa;
        }
        else if (dernierActionAdversaire == ActionDeCombat.KameHameHa && !this._jeSuisCharge)
        {
            this._adversaireCharge = false;
            this._jeSuisCharge = true;
            this._round += 1;
            return ActionDeCombat.ChargeKameHameHa;
        }
        else if (dernierActionAdversaire == ActionDeCombat.Parade && !this._jeSuisCharge)
        {
            this._adversaireCharge = false;
            this._jeSuisCharge = true;
            this._round += 1;
            return ActionDeCombat.ChargeKameHameHa;
        }
        else
        {
            this._jeSuisCharge = true;
            this._round += 1;
            return ActionDeCombat.ChargeKameHameHa;
        }
    }
}