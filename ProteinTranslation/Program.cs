using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProteinTranslation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bir RNA dizisi giriniz");
            string str = Console.ReadLine();

            ProteinTranslation(str);
            Console.ReadLine();
        }

        public static void ProteinTranslation(string rna)
        {
            bool stop_status = false;
            
            if ((rna.Length % 3) != 0)
            {
                Console.WriteLine("You entered invalid RNA!");
            }
            else
            {
                for (int i = 0; i < rna.Length; i += 3)
                {
                    string codon = rna.Substring(i, Math.Min(3, rna.Length - i));

                    switch (codon)
                    {
                        case "AUG":
                            Console.WriteLine("Methionine");
                            break;
                        case "UUU":
                        case "UUC":
                            Console.WriteLine("Phenylalanine");
                            break;
                        case "UUA":
                        case "UUG":
                            Console.WriteLine("Leucine");
                            break;
                        case "UCU":
                        case "UCC":
                        case "UCA":
                        case "UCG":
                            Console.WriteLine("Serine");
                            break;
                        case "UAU":
                        case "UAC":
                            Console.WriteLine("Tyrosine");
                            break;
                        case "UGU":
                        case "UGC":
                            Console.WriteLine("Cysteine");
                            break;
                        case "UGG":
                            Console.WriteLine("Tryptophan");
                            break;
                        case "UAA":
                        case "UAG":
                        case "UGA":
                            Console.WriteLine("STOP Codon encountered!!");
                            stop_status = true;
                            break;
                        default:
                            Console.WriteLine("Unknown codon: " + codon);
                            break;
                    }

                    if (stop_status)
                    {
                        break;
                    }
                }

                Console.WriteLine("The work is completed!");
            }



        }
    }
}
