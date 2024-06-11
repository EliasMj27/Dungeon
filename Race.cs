using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Race
    {

        string size;
        int speed;
        string[] validSizes = { "big","medium","smal" };
        string[] language;
        string[] namesLayout;
        string[] names;
        string[] arayOfDamaeRes =
            {
                "fire",
                "damage",
                "spells",
                "acid",
                "cold",
                "force",
                "lightinig",
                "necronic",
                "poison",
                "radiant",
                "thunder",
                "nonmagical",
                "magicWeapons",
                "slashing",
                "spells",
                "bludgeoning"
            };
        Dictionary<string, bool> damageRes;


        public string Size
        {
            get {  return size; }
            set {
                
                if (!validSizes.Contains(value))
                {
                    throw new ArgumentException("Parameter is not in ",validSizes.ToString());
                }
                    size = value; 
                }        
        }
        
        
        
        public Race(string[] damageResIn)
        {
            createDamageRes();
        }
        private void createDamageRes()
        {
            
            foreach(string i in  arayOfDamaeRes)
            {
                damageRes.Add(i, false);
            }
            
        }
        private void SetDamageRes(string[] damageResIn)
        {
            foreach (string i in damageResIn)
            {
                if (!arayOfDamaeRes.Contains(i))
                {
                    throw new Exception("Input is not somthing that can be damage resistence against. Input:"+i);
                }
                damageRes[i] = true;
            }
        }

    }
}
