using System.Data;
namespace SCUMconsole {
    class Program {
        public static void Main() {
            Calculate myObject = new Calculate();
            myObject.Start();
        }
    }
    class Calculate {
        void Calc(string switch_left, string switch_right, int t) {
            if (t == 1) {
                    formulaLeft += switch_left;
                    formulaLeft = Double.Parse(new DataTable().Compute(formulaLeft, null).ToString()).ToString();
                    formulaRight += switch_right;
                    formulaRight = Double.Parse(new DataTable().Compute(formulaRight, null).ToString()).ToString();
                    formulaLeft = formulaLeft.Replace(",", ".");
                    formulaRight = formulaRight.Replace(",", ".");
            }
        }
        //Входные / выходные значения
        public float inValue;
        public float outValue_left;
        public float outValue_right;
        //Значения на экнанах
        public string[] switches = new string[16];

        public string formulaLeft = "0";
        public string formulaRight = "0";

        public int[] switchesActivate = new int[8];

        public void Start(){
            while (true){
                //ВВОД ЗНАЧЕНИЙ
                Console.WriteLine("-------------------------------");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("-------------Запуск------------");
                Console.Write("Вход:");
                inValue = Int32.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");
                Console.Write("Выход левый:");
                outValue_left = Int32.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");
                Console.Write("Выход правый:");
                outValue_right = Int32.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Значения на тумблерах:");
                for (int i = 0; i < switches.Length; i++) {
                    switches[i] = Console.ReadLine();
                }
                Console.WriteLine("-------------------------------");
                formulaLeft = inValue.ToString();
                formulaRight = inValue.ToString();
                for (switchesActivate[0] = 0; switchesActivate[0] <= 1; switchesActivate[0]++){
                    Calc(switches[0], switches[1], switchesActivate[0]);
                    string res1L = formulaLeft;
                    string res1R = formulaRight;
                    for (switchesActivate[1] = 0; switchesActivate[1] <= 1; switchesActivate[1]++){
                        Calc(switches[2], switches[3], switchesActivate[1]);
                        string res2L = formulaLeft;
                        string res2R = formulaRight;
                        for (switchesActivate[2] = 0; switchesActivate[2] <= 1; switchesActivate[2]++){
                            Calc(switches[4], switches[5], switchesActivate[2]);
                            string res3L = formulaLeft;
                            string res3R = formulaRight;
                            for (switchesActivate[3] = 0; switchesActivate[3] <= 1; switchesActivate[3]++){
                                Calc(switches[6], switches[7], switchesActivate[3]);
                                string res4L = formulaLeft;
                                string res4R = formulaRight;
                                for (switchesActivate[4] = 0; switchesActivate[4] <= 1; switchesActivate[4]++){
                                    Calc(switches[8], switches[9], switchesActivate[4]);
                                    string res5L = formulaLeft;
                                    string res5R = formulaRight;
                                    for (switchesActivate[5] = 0; switchesActivate[5] <= 1; switchesActivate[5]++){
                                        Calc(switches[10], switches[11], switchesActivate[5]);
                                        string res6L = formulaLeft;
                                        string res6R = formulaRight;
                                        for (switchesActivate[6] = 0; switchesActivate[6] <= 1; switchesActivate[6]++){
                                            Calc(switches[12], switches[13], switchesActivate[6]);
                                            string res7L = formulaLeft;
                                            string res7R = formulaRight;
                                            for (switchesActivate[7] = 0; switchesActivate[7] <= 1; switchesActivate[7]++){
                                                Calc(switches[14], switches[15], switchesActivate[7]);
                                                string valueL = formulaLeft;
                                                string valueR = formulaRight;
                                                int numberLeft;
                                                int numberRight;
                                                bool success1 = int.TryParse(valueL, out numberLeft);
                                                bool success2 = int.TryParse(valueR, out numberRight);
                                                if (success1 && success2) {
                                                    int valL = int.Parse(valueL);
                                                    int valR = int.Parse(valueR);
                                                    if (valL == outValue_left && valR == outValue_right) {
                                                        Console.WriteLine("-------------------------------");
                                                        string result = string.Join(", ", switchesActivate);
                                                        Console.WriteLine($"---{result}---");
                                                    }
                                                }
                                                formulaLeft = res7L;
                                                formulaRight = res7R;
                                            }
                                            formulaLeft = res6L;
                                            formulaRight = res6R;
                                        }
                                        formulaLeft = res5L;
                                        formulaRight = res5R;
                                    }
                                    formulaLeft = res4L;
                                    formulaRight = res4R;
                                }
                                formulaLeft = res3L;
                                formulaRight = res3R;
                            }
                            formulaLeft = res2L;
                            formulaRight = res2R;
                        }
                        formulaLeft = res1L;
                        formulaRight = res1R;
                    }
                }
            }
        }
    }
}