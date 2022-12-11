using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k.backend.app.domain.Enum
{
    public class CodeASCII
    {
        public static readonly CodeASCII A = new CodeASCII(65, "A");
        public static readonly CodeASCII C = new CodeASCII(67, "C");
        public static readonly CodeASCII D = new CodeASCII(68, "D");
        public static readonly CodeASCII E = new CodeASCII(69, "E");
        public static readonly CodeASCII F = new CodeASCII(70, "F");
        public static readonly CodeASCII G = new CodeASCII(71, "G");
        public static readonly CodeASCII H = new CodeASCII(72, "H");
        public static readonly CodeASCII K = new CodeASCII(75, "K");
        public static readonly CodeASCII L = new CodeASCII(76, "L");
        public static readonly CodeASCII M = new CodeASCII(77, "M");
        public static readonly CodeASCII N = new CodeASCII(78, "N");
        public static readonly CodeASCII P = new CodeASCII(80, "P");
        public static readonly CodeASCII R = new CodeASCII(82, "R");
        public static readonly CodeASCII T = new CodeASCII(84, "T");
        public static readonly CodeASCII X = new CodeASCII(88, "X");
        public static readonly CodeASCII Y = new CodeASCII(89, "Y");
        public static readonly CodeASCII Z = new CodeASCII(90, "Z");
        public static readonly CodeASCII Number2 = new CodeASCII(50, "2");
        public static readonly CodeASCII Number3 = new CodeASCII(51, "3");
        public static readonly CodeASCII Number4 = new CodeASCII(52, "4");
        public static readonly CodeASCII Number5 = new CodeASCII(53, "5");
        public static readonly CodeASCII Number7 = new CodeASCII(55, "7");
        public static readonly CodeASCII Number9 = new CodeASCII(57, "9");

        public static List<CodeASCII> GetAll()
        {
            return new List<CodeASCII>
            {
                A,C,D,E,F,G,H,K,L,M,N,P,R,T,X,Y,Z,
                Number2,Number3,Number4,Number5,Number7,Number9
            };
        }

        public long ASCII { get; private set; }

        public string Character { get; private set; }

        public CodeASCII()
        {
        }

        public CodeASCII(long ascii, string character)
        {
            ASCII = ascii;
            Character = character;
        }
    }
}