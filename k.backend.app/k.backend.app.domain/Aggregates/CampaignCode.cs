using k.backend.app.domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k.backend.app.domain.Aggregates
{
    public class CampaignCode
    {
        public long Id { get; set; }
        public string Code { get; private set; }

        public CampaignCode()
        {
            GenerateCode();
        }

        public void GenerateCode()
        {
            Random random = new Random();
            List<CodeASCII> allCharacters = CodeASCII.GetAll();

            string code = String.Empty;

            CodeASCII oldChosenChar = null;

            while (code.Length < 8)
            {
                var chosenIndex = random.Next(allCharacters.Count);

                var currentChar = allCharacters[chosenIndex];

                if (oldChosenChar == null ||
                    currentChar.Character != oldChosenChar?.Character)
                {
                    oldChosenChar = currentChar;
                    code += currentChar.Character;
                }
            }
            Code = code;
        }

        public bool CheckCode()
        {
            var allStringCharacters = CodeASCII.GetAll().Select(x => x.Character).ToList();

            char? oldChar = null;
            foreach (var character in Code)
            {
                if (!allStringCharacters.Contains(character.ToString()) ||
                    (oldChar != null && oldChar.Value == character))
                    return false;
                oldChar = character;
            }
            return true;
        }
    }
}