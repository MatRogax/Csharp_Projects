using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.models
{
    public class Calculator
    {
        public string Option{get; set; }
        public double Num{get; set; }
        public double NumPlus{get; set; }
        public double Result{get; set; }
    
        public Calculator(double Num,double NumPlus,string Option){

            this.Option = Option;
            this.Num = Num;
            this.NumPlus = NumPlus;
            
        }
        
        public double Choice(){
            
            switch (Option)
            {
                case "+":
                    Result = Num + NumPlus;
                    break;
                case "-":
                    Result = Num - NumPlus;
                    break;
                case "*":
                    Result = Num * NumPlus;
                    break;
                case "/":
                    Result = Num / NumPlus;
                    break;
                case "^":
                    Result = Math.Pow(Num, NumPlus);
                    break;
                case "%":
                    Result = Num % NumPlus;
                    break;
                default:
                    break;
            }

            return Result;
            
        } 

        public void PrintResult(){

            Console.WriteLine($" {Num} {Option} {NumPlus}  = {Result} ");

        }

    }
    
}

