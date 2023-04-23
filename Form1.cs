using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uloha2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPocitej_Click(object sender, EventArgs e)
        {
            // deklarace proměnných
            float cislo1, cislo2, cislo3, cislo4, cislo5, cislo6;
            string[] zlomek1, zlomek2;
            string vysledek;

            // ošetření prázného vstupu
            if (tboxCisloPrvni.Text == "" || tboxCisloDruhe.Text == "")
            {
                Alert_Chyba("Vstupy musí obsahovat nějakou hodnotu!");
                return;
            }

            // pokud chce uživatel počítat se zlomky
            if(chboxZlomky.Checked)
            {
                // rozdělení tvaru zlomku
                zlomek1 = tboxCisloPrvni.Text.Split('|');
                zlomek2 = tboxCisloDruhe.Text.Split('|');

                if (zlomek1.Length != 2 && zlomek2.Length != 2)
                {
                    // zlomek nemá validní tvar
                    Alert_Chyba("Zlomky nejsou validní!");
                    return;
                }
                else
                {
                    if (zlomek1[0].Length <= 0 || zlomek1[1].Length <= 0 || zlomek2[0].Length <= 0 || zlomek2[1].Length <= 0)
                    {
                        // hodnoty zlomků nemají validní tvar
                        Alert_Chyba("Hodnoty zlomků nejsou validní!");
                        return;
                    }
                    else
                    {
                        if (zlomek1[1] == "0" || zlomek2[1] == "0")
                        {
                            // nelze dělit nulou
                            Alert_Chyba("Žádný ze jmenovatelů zadaných zlomků se nesmí rovnat nule!");
                            return;
                        }

                        // ošetření nečíselných a jinak neplatných vstupů pro první zlomek
                        if (!float.TryParse(zlomek1[0], out cislo3) || !float.TryParse(zlomek1[1], out cislo4))
                        {
                            Alert_Chyba("Hodnota vstupu prvního zlomku není validní!");
                            return;
                        }

                        // ošetření nečíselných a jinak neplatných vstupů pro první zlomek
                        if (!float.TryParse(zlomek2[0], out cislo5) || !float.TryParse(zlomek2[1], out cislo6))
                        {
                            Alert_Chyba("Hodnota vstupu druhého zlomku není validní!");
                            return;
                        }
                    }
                }

                // početní operace zlomků
                cislo1 = cislo3 / cislo4;
                cislo2 = cislo5 / cislo6;
            }
            else
            {
                // ošetření nečíselných a jinak neplatných vstupů
                if (!float.TryParse(tboxCisloPrvni.Text, out cislo1) || !float.TryParse(tboxCisloDruhe.Text, out cislo2))
                {
                    Alert_Chyba("Hodnota v obou vstupech musí být buďto celočíselná nebo desetinná oddělena čárkou!");
                    return;
                }
            }

            // zjištění znaménka, provedení početní operace
            switch (cboxZnamenko.SelectedItem)
            {
                case "+":
                    vysledek = $"{cislo1 + cislo2}";
                    break;
                case "-":
                    vysledek = $"{cislo1 - cislo2}";
                    break;
                case "*":
                    vysledek = $"{cislo1 * cislo2}";
                    break;
                case "/":
                    vysledek = $"{cislo1 / cislo2}";
                    break;
                default:
                    Alert_Chyba("Nezvolil jsi platnou operaci!");
                    return;
            }

            // zobrazení výsledku
            lblVysledek.Text = $"{vysledek}";
        }

        private void Alert_Chyba(string zprava)
        {
            MessageBox.Show($"{zprava}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
