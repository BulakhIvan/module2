using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    class DataCollection
    {
        //var a = new Civic();
        public string[] WriteStr()
        {
            string[] carBodyValue = new string[carBodyC.Length+ carBodyG.Length + carBodyR.Length + 
                carBodyM.Length + carBodyE.Length + carBodyP.Length + carBodyCT.Length];
            for (int i = 0; i < carBodyValue.Length; i++)
            {
                for(int j = 0; j < 5;j++)
                    carBodyValue[i] = carBodyC[j];
                for (int j = 0; j < 5; j++)
                    carBodyValue[i] = carBodyG[j];
                for (int j = 0; j < 5; j++)
                    carBodyValue[i] = carBodyR[j];
                for (int j = 0; j < 5; j++)
                    carBodyValue[i] = carBodyM[j];
                for (int j = 0; j < 5; j++)
                    carBodyValue[i] = carBodyE[j];
                for (int j = 0; j < 5; j++)
                    carBodyValue[i] = carBodyP[j];
                for (int j = 0; j < 5; j++)
                    carBodyValue[i] = carBodyCT[j];
            }
            return carBodyValue;
        } 
        public int[] WriteInt()
        {
            int[] DVSValue = new int[dvsC.Length + dvsG.Length + dvsR.Length + dvsM.Length + dvsE.Length + dvsP.Length + dvsCT.Length];
            for (int i = 0; i < DVSValue.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                    DVSValue[i] = dvsC[j];
                for (int j = 0; j < 5; j++)
                    DVSValue[i] = dvsG[j];
                for (int j = 0; j < 5; j++)
                    DVSValue[i] = dvsR[j];
                for (int j = 0; j < 5; j++)
                    DVSValue[i] = dvsM[j];
                for (int j = 0; j < 5; j++)
                    DVSValue[i] = dvsE[j];
                for (int j = 0; j < 5; j++)
                    DVSValue[i] = dvsP[j];
                for (int j = 0; j < 5; j++)
                    DVSValue[i] = dvsCT[j];
            }
            return DVSValue;
        }
    }
    class Sort
    {
        public void SortInt(int i)
        {
            i--;
            if (i == 0)
            {
                for (int p = 0; p < 4; p++)
                {
                    for (int j = 0; j < DVSValue.Length; j++)//Consumption,Volume,Power,TopSpeed
                    {
                        for (; i < 7;)
                        {
                            i = i + 4;
                            if (DVSValue[i] > DVSValue[i + 4])
                            {
                                int o = DVSValue[i + 4];
                                DVSValue[i + 4] = DVSValue[i];
                                DVSValue[i] = o;
                            }
                        }
                    }
                    i++;
                }
            }
            else if (i == 1)
            {
                for (int p = 0; p < 3; p++)
                {
                    for (int j = 0; j < DVSValue.Length; j++)//Consumption,Volume,Power,TopSpeed
                    {
                        for (; i < 7;)
                        {
                            i = i + 4;
                            if (DVSValue[i] > DVSValue[i + 4])
                            {
                                int o = DVSValue[i + 4];
                                DVSValue[i + 4] = DVSValue[i];
                                DVSValue[i] = o;
                            }
                        }
                    }
                    i++;
                }
                i--;
                for (int j = 0; j < DVSValue.Length; j++)//Consumption,Volume,Power,TopSpeed
                {
                    for (; i < 7;)
                    {
                        i = i + 4;
                        if (DVSValue[i] > DVSValue[i + 4])
                        {
                            int o = DVSValue[i + 4];
                            DVSValue[i + 4] = DVSValue[i];
                            DVSValue[i] = o;
                        }
                    }
                }
            }
            else if(i == 2)
            {
                for (int p = 0; p < 2; p++)
                {
                    for (int j = 0; j < DVSValue.Length; j++)//Consumption,Volume,Power,TopSpeed
                    {
                        for (; i < 7;)
                        {
                            i = i + 4;
                            if (DVSValue[i] > DVSValue[i + 4])
                            {
                                int o = DVSValue[i + 4];
                                DVSValue[i + 4] = DVSValue[i];
                                DVSValue[i] = o;
                            }
                        }
                    }
                    i++;
                }
                for (int p = 0; p < 2; p++)
                {
                    for (int j = 0; j < DVSValue.Length; j++)//Consumption,Volume,Power,TopSpeed
                    {
                        for (; i < 7;)
                        {
                            i = i + 4;
                            if (DVSValue[i] > DVSValue[i + 4])
                            {
                                int o = DVSValue[i + 4];
                                DVSValue[i + 4] = DVSValue[i];
                                DVSValue[i] = o;
                            }
                        }
                    }
                    i--;
                }
            }
            else
            {
                for (int p = 0; p < 4; p++)
                {
                    for (int j = 0; j < DVSValue.Length; j++)//Consumption,Volume,Power,TopSpeed
                    {
                        for (; i < 7;)
                        {
                            i = i + 4;
                            if (DVSValue[i] > DVSValue[i + 4])
                            {
                                int o = DVSValue[i + 4];
                                DVSValue[i + 4] = DVSValue[i];
                                DVSValue[i] = o;
                            }
                        }
                    }
                    i--;
                }
            }
        } 
        public void SortStr(int i)
        {
            i--;
            if (i == 0)
            {
                for (int p = 0; p < 4; p++)
                {
                    for (int j = 0; j < carBodyValue.Length; j++)//Consumption,Volume,Power,TopSpeed
                    {
                        for (; i < 7;)
                        {
                            i = i + 5;
                            if (carBodyValue[i] > carBodyValue[i + 5])
                            {
                                string o = carBodyValue[i + 5];
                                carBodyValue[i + 5] = carBodyValue[i];
                                carBodyValue[i] = o;
                            }
                        }
                    }
                    i++;
                }
            }
            else if (i == 1)
            {
                for (int p = 0; p < 3; p++)
                {
                    for (int j = 0; j < carBodyValue.Length; j++)//Consumption,Volume,Power,TopSpeed
                    {
                        for (; i < 7;)
                        {
                            i = i + 5;
                            if (carBodyValue[i] > carBodyValue[i + 5])
                            {
                                string o = carBodyValue[i + 5];
                                carBodyValue[i + 5] = carBodyValue[i];
                                carBodyValue[i] = o;
                            }
                        }
                    }
                    i++;
                }
                i--;
                for (int j = 0; j < carBodyValue.Length; j++)//Consumption,Volume,Power,TopSpeed
                {
                    for (; i < 7;)
                    {
                        i = i + 5;
                        if (carBodyValue[i] > carBodyValue[i + 5])
                        {
                            string o = carBodyValue[i + 5];
                            carBodyValue[i + 5] = carBodyValue[i];
                            carBodyValue[i] = o;
                        }
                    }
                }
            }
            else if (i == 2)
            {
                for (int p = 0; p < 2; p++)
                {
                    for (int j = 0; j < carBodyValue.Length; j++)//Consumption,Volume,Power,TopSpeed
                    {
                        for (; i < 7;)
                        {
                            i = i + 5;
                            if (carBodyValue[i] > carBodyValue[i + 5])
                            {
                                string o = carBodyValue[i + 5];
                                carBodyValue[i + 5] = carBodyValue[i];
                                carBodyValue[i] = o;
                            }
                        }
                    }
                    i++;
                }
                for (int p = 0; p < 2; p++)
                {
                    for (int j = 0; j < carBodyValue.Length; j++)//Consumption,Volume,Power,TopSpeed
                    {
                        for (; i < 7;)
                        {
                            i = i + 5;
                            if (carBodyValue[i] > carBodyValue[i + 5])
                            {
                                string o = carBodyValue[i + 5];
                                carBodyValue[i + 5] = carBodyValue[i];
                                carBodyValue[i] = o;
                            }
                        }
                    }
                    i--;
                }
            }
            else
            {
                for (int p = 0; p < 4; p++)
                {
                    for (int j = 0; j < carBodyValue.Length; j++)//Consumption,Volume,Power,TopSpeed
                    {
                        for (; i < 7;)
                        {
                            i = i + 5;
                            if (carBodyValue[i] > carBodyValue[i + 5])
                            {
                                string o = carBodyValue[i + 5];
                                carBodyValue[i + 5] = carBodyValue[i];
                                carBodyValue[i] = o;
                            }
                        }
                    }
                    i--;
                }
            }
        }
    }
}